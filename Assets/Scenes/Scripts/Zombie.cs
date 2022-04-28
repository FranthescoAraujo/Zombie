using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public GameObject Personagem;
    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        Personagem = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Personagem.transform.position) < 8)
        {
            transform.position = Vector3.MoveTowards(transform.position, Personagem.transform.position, velocidade);
            transform.LookAt(Personagem.transform.position);
        }
    }
}
