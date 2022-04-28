using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Iniciar;
    public GameObject GameOver;
    public GameObject Vitoria;

    public GameObject ReiniciarBotao;
    public GameObject IniciarBotao;
    public GameObject SairBotao;

    public GameObject Personagem;
    public GameObject Boss;

    public bool vitoria = false;

    void Start()
    {
        Time.timeScale = 0;
        Iniciar.SetActive(true);
        GameOver.SetActive(false);
        Vitoria.SetActive(false);
        ReiniciarBotao.SetActive(false);
        IniciarBotao.SetActive(true);
        SairBotao.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        FimDeJogo();
        Venceu();
    }

    public void Sair()
    {
        Application.Quit();
    }

    public void IniciarGame()
    {
        Time.timeScale = 1;
        Iniciar.SetActive(false);
        IniciarBotao.SetActive(false);
        SairBotao.SetActive(false);
    }

    public void Reiniciar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
        GameOver.SetActive(false);
        ReiniciarBotao.SetActive(false);
        SairBotao.SetActive(false);
    }

    public void FimDeJogo()
    {
        if (Personagem.GetComponent<Personagem>().vidas <= 0)
        {
            Time.timeScale = 0;
            GameOver.SetActive(true);
            ReiniciarBotao.SetActive(true);
            SairBotao.SetActive(true);
        }
    }

    public void Venceu()
    {
        if (vitoria == true)
        {
            Time.timeScale = 0;
            Vitoria.SetActive(true);
            ReiniciarBotao.SetActive(true);
            SairBotao.SetActive(true);
        }
    }
}
