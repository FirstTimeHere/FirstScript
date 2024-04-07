using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnlyX : MonoBehaviour
{
    private bool _isEnd;

    [SerializeField] private float _direction;
    [SerializeField] [Range(0, 1000)] private float _speed;

    private void MoveThisObject()
    {
        var nextPosition = transform.position;

        if (nextPosition.x <= _direction && _isEnd == false)
        {
            nextPosition.x += _speed * Time.deltaTime;
            transform.position = nextPosition;
        }
        else
        {
            _isEnd = true;
            nextPosition.x -= _speed * Time.deltaTime;
            transform.position = nextPosition;
        }

        if (nextPosition.x <= -_direction || nextPosition.x >= _direction)
        {
            _isEnd = !_isEnd;
        }
    }

    private void Update()
    {
        MoveThisObject();
    }
}
