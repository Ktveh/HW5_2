using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{    
    [SerializeField] private int _speed;
    [SerializeField] private float _secondsBetweenSetTarget;

    private GameObject _target;
    private Vector3 _targetDistance;
    private Vector3 _targetPosition;
    private float _ellapsedTime;

    private void Start()
    {
        _target = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        _ellapsedTime += Time.deltaTime;
        if (_ellapsedTime >= _secondsBetweenSetTarget)
        {
            SetTargetPosition();
            _ellapsedTime = 0;
        }
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
    }

    private void SetTargetPosition()
    {
        _targetPosition = _target.transform.position;
        _targetDistance = transform.position - _targetPosition;
        _targetPosition -= _targetDistance;
    }
}
