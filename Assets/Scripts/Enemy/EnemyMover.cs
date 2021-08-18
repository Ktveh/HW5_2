using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyMover : MonoBehaviour
{    
    [SerializeField] private int _speed;
    [SerializeField] private float _secondsBetweenSetTarget;

    private Enemy _enemy;
    private Vector3 _targetPosition;
    private float _ellapsedTime;

    private void Start()
    {
        _enemy = GetComponent<Enemy>();
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
        _targetPosition = _enemy.Target.transform.position;
        Vector3 targetDistance = transform.position - _targetPosition;
        _targetPosition -= targetDistance;
    }
}
