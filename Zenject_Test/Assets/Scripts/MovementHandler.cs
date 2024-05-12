using System;
using UnityEngine;

public class MovementHandler : IDisposable
{
    private IInput _input;

    public MovementHandler(IInput input)
    {
        _input = input;

        Debug.Log(_input.GetType());

        _input.OnClickUp += OnClickUp;
        _input.OnClickDown += OnCLickDown;
        _input.OnDrag += OnDrag;
    }

    public void Dispose()
    {
        _input.OnClickUp -= OnClickUp;
        _input.OnClickDown -= OnCLickDown;
        _input.OnDrag -= OnDrag;
    }

    private void OnCLickDown(Vector3 vector)
    {
        Debug.Log("Down");
    }

    private void OnClickUp(Vector3 vector)
    {
        Debug.Log("Up");
    }

    private void OnDrag(Vector3 vector)
    {
        Debug.Log("Drag");
    }
}
