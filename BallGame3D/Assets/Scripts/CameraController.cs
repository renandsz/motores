using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform alvo;
    private Vector3 offset;
    public float sensib = 2;
    private float yaw = 0;
    void Start()
    {
        alvo = GameObject.FindWithTag("Player").transform;
        offset = alvo.position - transform.position;
    }
    void Update() {
        transform.position = alvo.position - offset;
        yaw += sensib * Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0, yaw, 0);
    }
}
