using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DadoScript : MonoBehaviour
{

    public int dado;
    public int valorMultiplicador = 5;
    public Toggle multiplicador;
    public Text mensajeResultado;
    public Text nombreMod;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void LanzarDado()
    {
        if(multiplicador.isOn == false)
        {
            dado = Random.Range(1, 21);
            Debug.Log(dado);
            mensajeResultado.text = "El resultado es " + dado;
        }
        else
        {
            dado = Random.Range(1, 21);
            dado = dado * valorMultiplicador;
            Debug.Log(dado);
            mensajeResultado.text = "El total del resultado es de " + dado + " gracias al multiplicador";
        }
        
    }

    public void CambioDeTexto()
    {
        if(multiplicador.isOn == true)
        {
            nombreMod.text = "Se ha activado el multiplicador x5";
        }
        else
        {
            nombreMod.text = "";
        }
        
    }

}
