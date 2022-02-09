using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private string[] palabrasGuardadas;
    [SerializeField] private string[] preguntas;
    [SerializeField] private string historia;

    [SerializeField] TextMeshProUGUI textoPreguntas;
    [SerializeField] TextMeshProUGUI textoHistoria;
    [SerializeField] TMP_InputField inputRespuesta;
    [SerializeField] GameObject botonRespuesta;

    int indicePregunta = 0;

    void Start()
    {
        textoPreguntas.text = preguntas[indicePregunta];
        
        palabrasGuardadas = new string[preguntas.Length];
    }

    public void GuardarRespuesta()
    {
        palabrasGuardadas[indicePregunta] = inputRespuesta.text;
        inputRespuesta.text = "";
        indicePregunta++;

        if (indicePregunta >= preguntas.Length)
        {
            MostrarHistoria();
            return;
        }

        textoPreguntas.text = preguntas[indicePregunta];
    }

    void MostrarHistoria()
    {
        textoHistoria.gameObject.SetActive(true);
        textoHistoria.text = historia;

        textoPreguntas.gameObject.SetActive(false);
        botonRespuesta.gameObject.SetActive(false);
        inputRespuesta.gameObject.SetActive(false);
    }
}
