using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Meta : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;

    [SerializeField]
    TextMeshProUGUI textTime;

    float tiempoDePartida = 0.0f;
    bool enPartida = true;

    private void Update()
    {
        if ( enPartida == true )
        {
            tiempoDePartida = tiempoDePartida + Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
        pantallaFinal.SetActive(true);
            col.GetComponent<MovimientoJugador>().enabled = false;
            enPartida = false;
            textTime.text = tiempoDePartida.ToString();
        }
    }

}
