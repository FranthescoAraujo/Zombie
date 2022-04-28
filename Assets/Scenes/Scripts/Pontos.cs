using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour
{
    private Text texto;
    public int pontos;

    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        pontos = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>().getPontos();
        texto.text = "Pontos: " + pontos.ToString();
    }
}
