using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour
{
    public int velocidade = 10;
    private Rigidbody rb;
    private void Start() {
        TryGetComponent(out rb);
    }
    private void Update() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(h,0,v) * velocidade * Time.deltaTime, ForceMode.Impulse);
        if (transform.position.y <= -10){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
