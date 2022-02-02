using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PruebaTexto : MonoBehaviour
{
    public TextMeshProUGUI textoEditable;
    public Color colorText;

    void Start()
    {
        textoEditable.text = "Hola me gusta programar";
        textoEditable.color = colorText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
