using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inimigo : MonoBehaviour
{
    public int vidas = 5;
    public Controller controlador;
    public int pontos = 0;
    void Start()
    {
        controlador = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
    }
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bala")
        {
            vidas--;
            Destroy(collision.gameObject);
            if (vidas <= 0)
            {
                controlador.setPontos(pontos);
                Destroy(this.gameObject);
            }
        }
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Personagem>().vidas--;
        }
    }
}
