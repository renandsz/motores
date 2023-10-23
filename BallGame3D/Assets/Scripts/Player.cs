using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public int forcaPulo = 7;
    private Rigidbody rb;
    public bool noChao;
    public Transform cameraPivot;
    void Start() {
        TryGetComponent(out rb);
        cameraPivot = GameObject.Find("CameraPivot").transform;
    }
    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Chão") {
            noChao = true;
        }
    }
    void Update() {
        float h = Input.GetAxis("Horizontal"); //-1 esquerda,0 nada, 1 direita
        float v = Input.GetAxis("Vertical");// -1 pra tras, 0 nada, 1 pra frente
        
        Vector3 direcao = cameraPivot.forward * v + cameraPivot.right * h;
        rb.AddForce(direcao * velocidade * Time.deltaTime,ForceMode.Impulse);
        
        if (Input.GetKeyDown(KeyCode.Space) && noChao ) {
            rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse); //pulo
            noChao = false;
        }
        if(transform.position.y <= -10) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}