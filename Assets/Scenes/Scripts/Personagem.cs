using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public float velocidadeL;
    public float velocidadeF;
    public Rigidbody Corpo;
    public int vidas = 10;

    // Start is called before the first frame update
    void Start()
    {
        Corpo = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Andar();
    }

    void Andar()
    {
        velocidadeF = Input.GetAxis("Vertical");
        velocidadeF = velocidadeF * 4;

        velocidadeL = Input.GetAxis("Horizontal");
        velocidadeL = velocidadeL * 4;

        Corpo.velocity = transform.forward * velocidadeF + transform.right * velocidadeL -  transform.up;
    }
}
