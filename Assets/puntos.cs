using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntos : MonoBehaviour
{
    Text Textito;
    int puntitos;
    private void Awake()
    {
        Textito = GetComponent<Text>();
    }
    private void Start()
    {
        Aumentar_puntos(0);
    }
    public void Aumentar_puntos(int puntos)
    {
        puntitos = puntitos + puntos;
        Textito.text = "Puntos : " + puntitos;
    }

}
