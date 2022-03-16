using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class ImageCategoryInstantiator : MonoBehaviour
{

    [SerializeField] private ModelDataController dataController;
    [SerializeField] private GameObject thumbnailPrefab;
    [SerializeField] private GameObject imageButtonPrefab;
    [SerializeField] private GameObject rowObjectPrefab;
    [SerializeField] private GameObject uiCanvas;
    [SerializeField] private GameObject secondaryMenuCanvas;

    private Button activeButton;
    private List<Button> listOfButtons = new List<Button>();

    public int thumbnailsPerRow = 3;

    /// <summary>
    /// This function creates a new instance of a category button (e.g Hair Color, Gender) from an ImageCategory and adds it to the specified UI Canvas
    /// </summary>
    /// <param name="category">
    /// The category from which the button gets its name, icon, and file path for the secondary menu thumbnails
    /// </param>
    public void InstantiateButtonMenuItem(ImageCategory category)
    {
        GameObject buttonObjectInstance;
        Button _buttonInstance;
        Sprite categoryIconSprite;
        ButtonCategoryHolder buttonDataScript;

        buttonObjectInstance = Instantiate(imageButtonPrefab);
        _buttonInstance = buttonObjectInstance.GetComponent<Button>();
        buttonDataScript= buttonObjectInstance.GetComponent<ButtonCategoryHolder>();

        categoryIconSprite = Sprite.Create(category.categoryIcon, new Rect(0.0f, 0.0f, category.categoryIcon.width, category.categoryIcon.height), new Vector2(0.5f, 0.5f), 100.0f);
        buttonDataScript.iconImage.sprite = categoryIconSprite;

        //The name of the gameObject is used to pass the filepath to the OnButtonPressed subscriber function, since it cannot be passed as an argument
        buttonObjectInstance.name=category.assetFolderPath;

        listOfButtons.Add(_buttonInstance);

        buttonObjectInstance.GetComponent<ButtonCategoryHolder>().buttonImageCategory = category;
        buttonObjectInstance.transform.SetParent(uiCanvas.transform);
        _buttonInstance.onClick.AddListener(delegate {OnButtonPressed(_buttonInstance);});

    }

    public void InstantiateButtonMenuItem(SliderCategory category)
    {
        GameObject buttonObjectInstance;
        Button _buttonInstance;
        Sprite categoryIconSprite;
        ButtonCategoryHolder buttonDataScript;

        buttonObjectInstance = Instantiate(imageButtonPrefab);
        _buttonInstance = buttonObjectInstance.GetComponent<Button>();
        buttonDataScript= buttonObjectInstance.GetComponent<ButtonCategoryHolder>();


        categoryIconSprite = Sprite.Create(category.categoryIcon, new Rect(0.0f, 0.0f, category.categoryIcon.width, category.categoryIcon.height), new Vector2(0.5f, 0.5f), 100.0f);
        buttonDataScript.iconImage.sprite = categoryIconSprite;

        listOfButtons.Add(_buttonInstance);

        buttonObjectInstance.GetComponent<ButtonCategoryHolder>().buttonSliderCategory = category;
        buttonObjectInstance.transform.SetParent(uiCanvas.transform);
        _buttonInstance.onClick.AddListener(delegate {OnSliderButtonPressed(_buttonInstance);});

    }

    public void ResetButtonMenu()
    {
        foreach (Button _button in listOfButtons)
        {
            Destroy(_button.gameObject);
        }
        listOfButtons.Clear();
    }

    /// <summary>
    /// This function calls for the creation the secondary menu using the button generated from InstantiateButtonMenuItem. If it already exists, it clears its contents and appends new ones
    /// </summary>
    /// <param name="button">
    /// The button generated from InstantiateButtonMenuItem.
    /// </param>
    public void OnButtonPressed(Button button)
    {   
        if(activeButton!= button)
        {
            ButtonCategoryHolder buttonDataScript = button.gameObject.GetComponent<ButtonCategoryHolder>();
            UnloadSecondaryMenu();
            button.gameObject.GetComponent<Image>().color = buttonDataScript.activeBackgroundColor;

            string _buttonNameIsFolderPath;
            _buttonNameIsFolderPath= button.gameObject.name;
            CreateSecondaryImageMenu(_buttonNameIsFolderPath, button.GetComponent<RectTransform>().anchoredPosition);  
        }
        
        activeButton = button;
        
    }


    public void OnSliderButtonPressed(Button button)
    {   
        if(activeButton!= button)
        {
            ButtonCategoryHolder buttonDataScript = button.gameObject.GetComponent<ButtonCategoryHolder>();
            UnloadSecondaryMenu();
            button.gameObject.GetComponent<Image>().color = buttonDataScript.activeBackgroundColor;

            dataController.GenerateSlider(buttonDataScript.buttonSliderCategory,buttonDataScript.buttonSliderCategory.isSpecialSlider);
        }
        
        activeButton = button;
        
    }


    /// <summary>
    /// This function creates the secondary menu using a file path to load its assets dynamically.
    /// </summary>
    /// <param name="folderPath">
    /// the file path to the thumbnail folder for a specific category. 
    /// </param>
    public void CreateSecondaryImageMenu(string folderPath, Vector2 location)
    {
        Object[] secondaryMenuData;
        GameObject _menuRow=null;
        int numberOfIconsInRow = -1;


        //Dynamically load all textures in the folder, to prevent manual assignment and reassignment. 
        secondaryMenuData = Resources.LoadAll(folderPath, typeof(StageOneOptionObject));

        //RectTransform menuLocation = secondaryMenuCanvas.GetComponent<RectTransform>();
        //menuLocation.anchoredPosition = new Vector2(menuLocation.anchoredPosition.x,location.y);

        //Turn on the background
        secondaryMenuCanvas.GetComponent<Image>().enabled = true;

        foreach (StageOneOptionObject buttonData in secondaryMenuData)
        {
            //If no rows exist in the menu or the number of thumbnails exceeds the user-configurable thumbnailsPerRow, create a new row and append it. 
            if (numberOfIconsInRow >= thumbnailsPerRow || numberOfIconsInRow==-1)
            {
                _menuRow = Instantiate(rowObjectPrefab);
                _menuRow.transform.SetParent(secondaryMenuCanvas.transform); 
                numberOfIconsInRow=0;
            }

            InstantiateImageMenuItem(buttonData,_menuRow);
            numberOfIconsInRow++;
        }
    }

    /// <summary>
    /// This function creates a single image element for the secondary menu. 
    /// </summary>
    /// <param name="buttonData">
    /// the data required for the character creator that will be mounted on the Image Menu Item prefab
    /// </param>
    /// <param name="parentRow">
    /// the row that the image element will be attached as a child to
    /// </param>
    private void InstantiateImageMenuItem(StageOneOptionObject buttonData, GameObject parentRow)
    {
        GameObject ImageItemObjectInstance;
        Button _buttonInstance;
        Sprite thumbSprite;
        ImageItemObjectInstance = Instantiate(thumbnailPrefab);
        _buttonInstance = ImageItemObjectInstance.GetComponent<Button>();

        thumbSprite = Sprite.Create(buttonData.thumbnail, new Rect(0.0f, 0.0f, buttonData.thumbnail.width, buttonData.thumbnail.height), new Vector2(0.5f, 0.5f), 100.0f);

        ImageItemObjectInstance.transform.SetParent(parentRow.transform);
        ImageItemObjectInstance.GetComponent<Image>().sprite = thumbSprite;
        ImageItemObjectInstance.GetComponent<SecondaryMenuDataHolder>().buttonData=buttonData;

        _buttonInstance.onClick.AddListener(delegate {OnSecondaryButtonPressed(_buttonInstance);});

    }

    /// <summary>
    /// This event subscriber function switches between meshes depending on the specific option the user has selected from the secondary menu. 
    /// </summary>
    /// <param name="thumbnail">
    /// the button currently being pressed
    /// </param>
    public void OnSecondaryButtonPressed(Button _button)
    {
        //Todo: establish event system and subscribe the back button to it.
        StageOneEventManager.SelectedOptionChanged(_button);
    }

    /// <summary>
    /// This function works as a garbage collector for whenever the contents of the secondary menu change, usually due to button presses on the category menu. 
    /// </summary>
    public void UnloadSecondaryMenu()
    {
         
        for (int i = 0; i < secondaryMenuCanvas.transform.childCount; i++)
        {
            Destroy(secondaryMenuCanvas.transform.GetChild(i).gameObject);
        }

        if(activeButton!=null)
            activeButton.gameObject.GetComponent<Image>().color = activeButton.GetComponent<ButtonCategoryHolder>().inactiveBackgroundColor;

        secondaryMenuCanvas.GetComponent<Image>().enabled = false;
        Resources.UnloadUnusedAssets();
    }

    
}
