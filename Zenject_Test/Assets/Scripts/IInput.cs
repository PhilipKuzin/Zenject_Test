using System;
using UnityEngine;

public interface IInput 
{
    event Action <Vector3> OnClickUp;
    event Action <Vector3> OnClickDown;
    event Action <Vector3> OnDrag;
}
