using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Zombie;
    public GameObject SpawnZombie = null;
    public float tempo;
    public int contadorInimigo = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (tempo>= 5.0f && SpawnZombie == null)
        {
            SpawnZombie = Instantiate(Zombie, transform.position, Quaternion.identity);
            contadorInimigo++;
            tempo = 0;
        } 
        tempo += Time.deltaTime;
    }
}
