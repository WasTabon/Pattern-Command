using UnityEngine;

public class MoveForwardCommand : ICommand
{
    private float _distance;
    private Transform _transform;

    public MoveForwardCommand(Transform transform, float distance)
    {
        _distance = distance;
        _transform = transform;
    }

    public void Execute()
    {
        _transform.position += Vector3.right * _distance;
    }

    public void Undo()
    {
        _transform.position -= Vector3.right * _distance;
    }
}