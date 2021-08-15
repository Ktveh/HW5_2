using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private int _angle;

    public void Move()
    {
        transform.Translate(0, 0, _speed * Time.deltaTime);
    }

    public void RotateLeft()
    {
        Rotate(-_angle);
    }

    public void RotateRight()
    {
        Rotate(_angle);
    }

    private void Rotate(float angle)
    {
        transform.Rotate(0, angle * Time.deltaTime, 0);
    }
}
