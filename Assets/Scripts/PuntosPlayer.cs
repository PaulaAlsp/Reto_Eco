using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PuntosPlayer : MonoBehaviour
{
    public int puntosPlayerActual;
    public TextMeshProUGUI verPuntos;

    // Start is called before the first frame update
    void Start()
    {
        verPuntos.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void puntos(int puntosRecividos ) {
        puntosPlayerActual += puntosRecividos;
        verPuntos.text = puntosPlayerActual.ToString();
    }
}
