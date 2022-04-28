using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamera : MonoBehaviour
{
    public float velocidadeHorizontal;
    public float velocidadeVertical;
    public float velH;
    public float velV;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }

    void Mover()
    {
        velocidadeHorizontal = Input.GetAxis("Mouse X");
        velH += velocidadeHorizontal * 8.0f;

        velocidadeVertical = Input.GetAxis("Mouse Y");
        velV -= velocidadeVertical * 2.0f;

        transform.eulerAngles = new Vector3(0, velH, 0);
    }
}
