using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private Transform _transform;
    
    private List<ICommand> _commandsExecuted = new List<ICommand>();

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    public void MoveForward()
    {
        var move = new MoveForwardCommand(_transform, _speed);
        
        move.Execute();
        _commandsExecuted.Add(move);
        
        Debug.Log("Step Forward");
    }
    public void MoveDiagonal()
    {
        var move = new MoveDiagonalCommand(_transform, _speed);
        
        move.Execute();
        _commandsExecuted.Add(move);
        
        Debug.Log("Step Diagonal");
    }
    
    public void Undo()
    {
        if (_commandsExecuted.Count > 0)
        {
            var lastMove = _commandsExecuted.Last();
            lastMove.Undo();
            _commandsExecuted.Remove(lastMove);
            
            Debug.Log("Undo");
        }
        
    }
}