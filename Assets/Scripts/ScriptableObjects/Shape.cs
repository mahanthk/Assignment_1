using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Shape", menuName = "Custom Props/Shapes")]
public class Shape : ScriptableObject
{
    public string ShapeName;
    public string VolumeFormula;
    public string SurfaceareaFormula;
}
