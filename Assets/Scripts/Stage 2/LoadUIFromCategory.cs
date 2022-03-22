using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadUIFromCategory : MonoBehaviour
{
    [SerializeField] private GameObject uiParentObject;
    [SerializeField] private GameObject dropdownPrefab;
    [SerializeField] private GameObject tabButtonParentObject;
    [SerializeField] private GameObject tabButtonPrefab;
    [SerializeField] private GameObject vitalSignsParentObject;
    [SerializeField] private GameObject vitalCategoryPrefab;
    private AvatarPhaseTwoInfo carryoverModelData;
    private StageTwoStaticData levelData;
    private Font uiFont;
    private int currentTab = -1;
    private List<bool> hasTabBeenGeneratedBefore = new List<bool>();

    // Start is called before the first frame update
    void Start()
    {
        levelData = StageTwoStaticData.Instance;
        carryoverModelData = GameObject.FindWithTag("Player").GetComponent<AvatarPhaseTwoInfo>();
        uiFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");

    /* foreach (StageTwoCategoryObject cat in levelData.listOfCategories)
    {
        GenerateCategory(cat);
    } */
        CreateTabs();
        SwitchTab(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateTabs()
    {
        for (int i = 0; i < levelData.listOfCategories.Length+1; i++)
        {
            GameObject tabInstance = Instantiate(tabButtonPrefab);
            tabInstance.transform.SetParent(tabButtonParentObject.transform);
            Button instanceButton = tabInstance.GetComponent<Button>();

            hasTabBeenGeneratedBefore.Add(false);
            instanceButton.onClick.AddListener(delegate {SwitchTab(tabInstance.transform.GetSiblingIndex());});
        }
    }

    public void SwitchTab(int tabIndex)
    {
        if(tabIndex <= levelData.listOfCategories.Length && tabIndex!=currentTab)
        {
            if(!hasTabBeenGeneratedBefore[tabIndex])
            {
                HideAllChildren(uiParentObject);

                if(tabIndex == 0)
                {
                    GenerateVitalSignsUI(levelData.vitalSignData);
                }
                else
                {
                    vitalSignsParentObject.transform.parent.gameObject.SetActive(false);
                    GenerateCategory(levelData.listOfCategories[tabIndex-1]);
                }

                hasTabBeenGeneratedBefore[tabIndex] = true;
            }

            else
            {
                HideAllChildren(uiParentObject);

                if(tabIndex ==0)
                {
                   vitalSignsParentObject.transform.parent.gameObject.SetActive(true);
                }

                else
                {
                    vitalSignsParentObject.transform.parent.gameObject.SetActive(false);
                    UnhideChildAtIndex(uiParentObject,tabIndex-1);
                }


            }

            currentTab = tabIndex;
            
        }
        
    }

    private void GenerateVitalSignsUI(VitalSignsConfigurationObject signsData)
    {
        if(!vitalSignsParentObject.transform.parent.gameObject.activeSelf)
        {
            vitalSignsParentObject.transform.parent.gameObject.SetActive(true);
        }
        for (int i = 0; i < signsData.Categories.Count; i++)
        {
            GameObject categoryInstance = Instantiate(vitalCategoryPrefab);
            categoryInstance.transform.SetParent(vitalSignsParentObject.transform);
            InitialCategorySetup(categoryInstance,signsData.Categories[i]);
        }

        Dictionary<string,float> carryoverVariables = carryoverModelData.phaseInfo;

        if(carryoverVariables.Count == signsData.nonEditableCategories.Count)
        {
            for (int i = 0; i < signsData.nonEditableCategories.Count; i++)
            {
                GameObject categoryInstance = Instantiate(vitalCategoryPrefab);
                categoryInstance.transform.SetParent(vitalSignsParentObject.transform);
                NonEditableCategorySetup(categoryInstance,signsData.nonEditableCategories[i],carryoverVariables[signsData.nonEditableCategories[i].categoryName]);
            }
        }
        
        
    }

    private void InitialCategorySetup(GameObject categoryInstance,VitalSignCategory currentCategory)
    {
        CategoryTextReferences textReferences = categoryInstance.GetComponent<CategoryTextReferences>();
        textReferences.categoryName.text = currentCategory.categoryName;
        textReferences.categoryUnit.text = currentCategory.unitOfMeasurement;
        textReferences.categoryObject = currentCategory;

        if(currentCategory.defaultValue> 0)
        {
            if(!carryoverModelData.characterSelectInfo.ContainsKey(currentCategory.categoryName))
            {
                carryoverModelData.characterSelectInfo.Add(currentCategory.categoryName,currentCategory.defaultValue.ToString()+" ["+currentCategory.unitOfMeasurement+"]");
            }

            textReferences.textBoxDefaultValue.text = currentCategory.defaultValue.ToString();
        }
        else
        {
            if(!carryoverModelData.characterSelectInfo.ContainsKey(currentCategory.categoryName))
            {
                carryoverModelData.characterSelectInfo.Add(currentCategory.categoryName,"0 "+" ["+currentCategory.unitOfMeasurement+"]");
            }
        }
    }

    private void NonEditableCategorySetup(GameObject categoryInstance,VitalSignCategory currentCategory,float carryoverAttribute)
    {
        CategoryTextReferences textReferences = categoryInstance.GetComponent<CategoryTextReferences>();
        textReferences.categoryName.text = currentCategory.categoryName;
        textReferences.categoryUnit.text = currentCategory.unitOfMeasurement;
        textReferences.categoryObject = currentCategory;

        textReferences.textBoxDefaultValue.text = carryoverAttribute.ToString();
        textReferences.textBox.interactable=false;
        
    }

    public void GenerateCategory(StageTwoCategoryObject categories)
    {
        GameObject categoryObject = new GameObject("MainCategory");
        categoryObject.transform.SetParent(uiParentObject.transform);

        Text categoryText = InitTextElement(categoryObject,50, categories.title);
        SetTextPosition(categoryText,new Vector3(-50,500,0), new Vector2(300,300));

        for (int i = 0; i < categories.subcategories.Length; i++)
        {
            GenerateSubcategory(categories.subcategories[i],categoryObject);
        }
    }

    private void GenerateSubcategory(Section _subcategory, GameObject categoryParent)
    {
        GameObject subcategoryObject = new GameObject("Subcategory");
        subcategoryObject.transform.SetParent(categoryParent.transform);

        Text subcategoryText = InitTextElement(subcategoryObject,40, _subcategory.title);
        SetTextPosition(subcategoryText,new Vector3(0,-100,0), new Vector2(150,150));

        for (int i = 0; i < _subcategory.properties.Length; i++)
        {
            GenerateProperty(_subcategory.properties[i],subcategoryObject);
        }
    }

    private void GenerateProperty(Property _property, GameObject subcategoryParent)
    {
        GameObject propertyObject = new GameObject("Property");
        propertyObject.transform.SetParent(subcategoryParent.transform);

        Text propertyText = InitTextElement(propertyObject,32, _property.name);
        SetTextPosition(propertyText,new Vector3(0,-100,0), new Vector2(100,100));

        for (int i = 0; i < _property.subproperties.Length; i++)
        {
            GenerateSubproperty(_property.subproperties[i],propertyObject);
        }
    }

    private void GenerateSubproperty(SubProperty _subproperty, GameObject propertyParent)
    {
        GameObject subpropertyObject = new GameObject("Subproperty");
        subpropertyObject.transform.SetParent(propertyParent.transform);

        Text subpropertyText = InitTextElement(subpropertyObject,16, _subproperty.title);
        SetTextPosition(subpropertyText,new Vector3(0,-100,0), new Vector2(90,90));
        
        if(!carryoverModelData.characterSelectInfo.ContainsKey(_subproperty.title))
        {
            carryoverModelData.characterSelectInfo.Add(_subproperty.title,"normal");
        }

        BuildDropdown(_subproperty.title,_subproperty.options, subpropertyObject,_subproperty.type);
    }

    private void BuildDropdown(string _subpropertyName,Option[] dropdownOptions, GameObject subpropertyParent, PropertyTypes subpropertyType)
    {
        List<string> items = new List<string>();
        GameObject dropdownObject = Instantiate(dropdownPrefab);
        dropdownObject.transform.SetParent(subpropertyParent.transform);
        Dropdown uiDropdown = dropdownObject.GetComponent<Dropdown>();
        DropdownOptionHolder optionHolderScript = dropdownObject.GetComponent<DropdownOptionHolder>();

        SetUIObjectPosition(dropdownObject, new Vector3(0,-100,0));

        optionHolderScript.currentDropdownOptions.Clear();
        optionHolderScript.dropdownType = subpropertyType;
        optionHolderScript.subpropertyName = _subpropertyName;

        foreach (Option _option in dropdownOptions)
        {
            items.Add(_option.title);
            optionHolderScript.currentDropdownOptions.Add(_option);
        }

        foreach(string item in items)
        {
            uiDropdown.options.Add(new Dropdown.OptionData(){text = item});
        }

        uiDropdown.onValueChanged.AddListener(delegate {OnEnumOptionChanged(uiDropdown);});
    }

    public void OnEnumOptionChanged(Dropdown _dropdown)
    {   
        DropdownOptionHolder optionHolderScript = _dropdown.gameObject.GetComponent<DropdownOptionHolder>();
        Option chosenOption = Option.FindByTitle(_dropdown.captionText.text,optionHolderScript.currentDropdownOptions);
        levelData.avatarEffectsOnOptionSelectScript.WhenDropdownOptionSelected(chosenOption, optionHolderScript.dropdownType);

        carryoverModelData.ModifyCharacterInfo(optionHolderScript.subpropertyName,chosenOption.title);
            

    }

        private Text InitTextElement(GameObject parent, int fontSize, string text)
    {
        Text propertyText = parent.AddComponent<Text>();
        propertyText.text = text;
        propertyText.font = uiFont;
        propertyText.color = Color.black;
        propertyText.fontSize = fontSize;
        propertyText.alignment = TextAnchor.MiddleLeft;
        return propertyText;
    }

    private void SetTextPosition(Text _textElement, Vector3 newPosition, Vector2 newSize)
    {
        RectTransform rectTransform;
        rectTransform = _textElement.GetComponent<RectTransform>();
        rectTransform.localPosition = newPosition;
        rectTransform.sizeDelta = newSize;
    }

    private void SetUIObjectPosition(GameObject uiObject, Vector3 newPosition)
    {
        RectTransform rectTransform;
        rectTransform = uiObject.GetComponent<RectTransform>();
        rectTransform.localPosition = newPosition;
    }

    private void ClearAllChildren(GameObject parent)
    {
        foreach (Transform child in parent.transform)
        {
            Destroy(child.gameObject);
        }

    }

    private void HideAllChildren(GameObject parent)
    {
        foreach (Transform child in parent.transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    private void UnhideChildAtIndex(GameObject parent, int index)
    {
        if(parent.transform.childCount>index)
        {
            parent.transform.GetChild(index).gameObject.SetActive(true);
        }

        else
        {
            Debug.LogWarning("Attempting to show a tab that doesn't exist");
        }
    }

    private void UnhideAllChildren(GameObject parent)
    {
        foreach (Transform child in parent.transform)
        {
            child.gameObject.SetActive(true);
        }
    }


}
