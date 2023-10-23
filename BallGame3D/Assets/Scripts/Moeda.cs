using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Moeda : MonoBehaviour
{
    public int velocidadeGiro = 100;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.Rotate(Vector3.forward, velocidadeGiro * Time.deltaTime );
    }
}
