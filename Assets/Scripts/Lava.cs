using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0, Time.deltaTime, 0);
    }
}
