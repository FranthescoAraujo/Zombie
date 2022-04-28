using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public int pontos;

    public void setPontos(int ponto)
    {
        pontos += ponto;
    }

    public int getPontos()
    {
        return pontos;
    }



}
