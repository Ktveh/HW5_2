using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform _startPosition;

    private void Start()
    {
        SetNewPosition();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Lava>())
            SetNewPosition();
    }

    private void SetNewPosition()
    {
        transform.position = _startPosition.position;
    }
}
