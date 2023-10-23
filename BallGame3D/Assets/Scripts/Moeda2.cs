using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda2 : MonoBehaviour
{
    public int velocidadeGiro = 150;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        transform.Rotate(Vector3.forward * velocidadeGiro * Time.deltaTime);
    }
}
