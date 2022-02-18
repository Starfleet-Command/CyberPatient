using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StageOneEventManager : MonoBehaviour
{
    public delegate void OptionSelected(Button _button);
    
    public static event OptionSelected OnOptionSelected;

    public static void SelectedOptionChanged(Button _button)
    {
        OnOptionSelected(_button);
    }

    public delegate void MeshChanged(GameObject _mesh);

    public static event MeshChanged OnMeshChanged;

    public static void SelectedMeshChanged(GameObject _mesh)
    {
        OnMeshChanged(_mesh);
    }

}
