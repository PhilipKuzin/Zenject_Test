using System;
using UnityEngine;
using Zenject;


public class DesktopInput : IInput, ITickable
{
    public event Action<Vector3> OnClickUp;
    public event Action<Vector3> OnClickDown;
    public event Action<Vector3> OnDrag;

    private bool _isSwiping;
    private Vector3 _prevMousePos;

    private const int LeftMouseBtn = 0;

    public void Tick()
    {
        ProcessClickUp();
        ProcessClickDown();
        ProcessDrag();
    }

    private void ProcessDrag()
    {
        if (_isSwiping == false)
            return;

        if (Input.mousePosition != _prevMousePos)
            OnDrag?.Invoke(Input.mousePosition);   

        _prevMousePos = Input.mousePosition;
     
    }

    private void ProcessClickDown()
    {
        if (Input.GetMouseButtonDown(LeftMouseBtn))
        {
            _isSwiping = true;
            _prevMousePos = Input.mousePosition; 
            OnClickDown?.Invoke(Input.mousePosition);
        }
    }

    private void ProcessClickUp()
    {
        if (Input.GetMouseButtonUp(LeftMouseBtn))
        {
            _isSwiping = false;
            OnClickUp?.Invoke(Input.mousePosition);
        }
    }
}
