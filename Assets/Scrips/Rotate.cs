using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 10f;


    void Update()
    {
        transform.Rotate(0, 0, 0.09f);
    }
}
