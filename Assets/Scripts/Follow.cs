using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private Vector3 _distance;

    private void Start()
    {
        transform.parent = _target.transform;
        transform.position = _target.transform.position + _distance;
    }
}
