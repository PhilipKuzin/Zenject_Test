using System;
using UnityEngine;
using Zenject;

public class MobileInput : IInput, ITickable
{
    public event Action<Vector3> OnClickUp;
    public event Action<Vector3> OnClickDown;
    public event Action<Vector3> OnDrag;

    public void Tick()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    OnClickUp?.Invoke(touch.position);
                break;

                case TouchPhase.Ended:
                    OnClickDown?.Invoke(touch.position);
                break;

                case TouchPhase.Moved:
                    OnDrag?.Invoke(touch.position);
                break;
            }
        }
    }


}
