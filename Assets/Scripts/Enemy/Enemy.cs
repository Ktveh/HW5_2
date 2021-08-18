using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Player Target
    {
        get;
        private set;
    }

    private void Start()
    {
        Target = FindObjectOfType<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Lava>())
            Destroy(gameObject);
    }
}
