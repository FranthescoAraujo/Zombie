using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public int velocidade =  1000;
    public GameObject PontoSaida;
    public GameObject Bala;
    public GameObject Personagem;
    public int municao = 20;
    public float tempo = 0;
    public bool podeRecarregar = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (municao < 20)
        {
            recarregar();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            if (municao > 0)
            {
                GameObject Tiro = Instantiate(Bala, PontoSaida.transform.position, Personagem.transform.rotation);
                Rigidbody CorpoBala = Tiro.GetComponent<Rigidbody>();
                CorpoBala.AddForce(Personagem.transform.forward * velocidade);
                municao--;
                Destroy(Tiro, 5f);
            }
        }
    }

    private void recarregar()
    {
        tempo += Time.deltaTime;
        if (tempo >= 5)
        {
            municao = 20;
            tempo = 0;
        }
    }
}
