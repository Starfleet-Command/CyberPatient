using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class ImageCategory
{
    public string categoryName;
    public Texture2D categoryIcon;
    public string assetFolderPath;
    [TextArea(3,10)]
    public string tooltip;
}
