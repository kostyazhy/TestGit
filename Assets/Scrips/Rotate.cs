using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 10f;

    void Start(){
        speed = Random.Range(0, 1);
    }

    void Update()
    {
        transform.Rotate(0, 0, speed);
    }
}
