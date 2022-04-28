using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Painel : MonoBehaviour
{
    public Personagem personagem;
    public Image image;
    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        float trans = (10 - (float)(personagem.GetComponent<Personagem>().vidas)) / 10;
        image.color = new Vector4(1, 1, 1, trans);
    }
}
