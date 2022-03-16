using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetBoundTextOnEditEnd : MonoBehaviour
{
    private CategoryTextReferences buttonReferences;

    private void Start()
    {
        buttonReferences = this.gameObject.GetComponent<CategoryTextReferences>();
        buttonReferences.textBox.onEndEdit.AddListener(OnEditEnd);
    }

    public void OnEditEnd(string editedText)
    {
        float enteredValue;
        string boundValue;
        
        if(float.TryParse(editedText, out enteredValue))
        {
            
            foreach (VitalSignClassBounds bound in buttonReferences.categoryObject.bounds)
            {
                if(enteredValue>= bound.lowerBound && enteredValue<=bound.upperBound)
                {
                    boundValue = bound.rangeName;
                    buttonReferences.boundValue.text = boundValue;
                    break;
                }
            }

            
        }
    }
}
