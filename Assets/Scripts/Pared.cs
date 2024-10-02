using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pared : MonoBehaviour
{
    [SerializeField]
    Material paredVerde;

    [SerializeField]
    Material paredRoja;

    bool paredTocada = false;

    float tiempoTocada = 5f;
   
    private void Update()
    {
        if (paredTocada == true)
        {
            tiempoTocada = tiempoTocada - Time.deltaTime;
            if (tiempoTocada < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = paredVerde;
                paredTocada = false;
                tiempoTocada = 5f;
            }
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = paredRoja;
            paredTocada = true;
        }
    }

}
