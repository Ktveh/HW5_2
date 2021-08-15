using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMover _mover;

    private void Start()
    {
        _mover = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            _mover.Move();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _mover.RotateLeft();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _mover.RotateRight();
        }
    }
}
