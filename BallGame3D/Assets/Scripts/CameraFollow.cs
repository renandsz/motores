using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform alvo;
    private Vector3 offset;
    
    void Start()
    {
        alvo = GameObject.FindWithTag("Player").transform;
        offset = alvo.position - transform.position;
    }
    void Update() {
        transform.position = alvo.position - offset;
    }
}
