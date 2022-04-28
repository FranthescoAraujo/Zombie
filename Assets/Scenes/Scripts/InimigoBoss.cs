using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoBoss : MonoBehaviour
{
    public int vidas = 50;
    public Controller controlador;
    public int pontos = 50;

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
                GameObject.FindGameObjectWithTag("Menu").GetComponent<Menu>().vitoria = true;
                Destroy(this.gameObject);
            }
        }
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Personagem>().vidas--;
        }
    }
}
