using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerV2 : MonoBehaviour
{
    public int velocidade = 10;
    public int forcaPulo = 7;
    Rigidbody rb;

    public bool noChao;
    void Start()
    {
        TryGetComponent(out rb);
    }
    private void OnCollisionEnter(Collision collision) {
        noChao = true;
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); //-1 esquerda,0 nada, 1 direita
        float v = Input.GetAxis("Vertical");// -1 pra tras, 0 nada, 1 pra frente

        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime,ForceMode.Impulse);
        
        
        //pulo
        if (noChao && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * forcaPulo,ForceMode.Impulse);
            noChao = false;
        }
    }
    
    
   
}
