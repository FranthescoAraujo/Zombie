using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Municao : MonoBehaviour
{
    private Text texto;
    public Arma Balas;

    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent <Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = "Munição: " + Balas.municao.ToString() + "/20";
    }
}
