using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathUtilities : MonoBehaviour
{
    /// <summary>
    //This calculation translates the value given from a certain scale to another, defined by a linear equation. For example, converting weight in kg to the slider scale of 0 and 100.
    /// </summary>
    /// <param name="oldScaleValue">
    /// The value to be converted.
    /// </param>
    /// <param name="slope">
    /// The slope of the linear equation to be used.
    /// </param>
    /// <param name="intercept">
    /// The intercept of the linear equation to be used.
    /// </param>
    /// <returns >
    /// The value given, converted to a different scale.
    /// </returns>
    public static float LinearValueConversion(float oldScaleValue, float slope, float intercept)
    {
        float newNormalizedValue = 0f;
        newNormalizedValue = (slope*oldScaleValue)+intercept;

        return newNormalizedValue;
    }
}
