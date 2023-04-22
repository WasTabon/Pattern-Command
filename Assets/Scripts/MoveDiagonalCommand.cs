using UnityEngine;
public class MoveDiagonalCommand : ICommand
{
    private float _distance;
    private Transform _transform;

    public MoveDiagonalCommand(Transform transform, float distance)
    {
        _distance = distance;
        _transform = transform;
    }

    public void Execute()
    {
        _transform.position += Vector3.right * _distance;
        _transform.position += Vector3.down * _distance;
    }

    public void Undo()
    {
        _transform.position -= Vector3.right * _distance;
        _transform.position -= Vector3.down * _distance;
    }
}