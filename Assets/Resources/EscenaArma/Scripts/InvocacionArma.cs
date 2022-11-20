using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvocacionArma : MonoBehaviour
{

    public GameObject arma;
    public Transform spawn;
    public InputField inputArma;
    public Text instruccion;
    public string nombreArma;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void InvArma()
    {
        nombreArma = inputArma.text;
        switch (nombreArma)
        {
            case "espada":
                arma = Resources.Load<GameObject>("EscenaArma/Armas/espada");
                Instantiate(arma, spawn.position, spawn.rotation);
                instruccion.text = "Has invocado una espada";
                break;
            case "arco":
                arma = Resources.Load<GameObject>("EscenaArma/Armas/arco");
                Instantiate(arma, spawn.position, spawn.rotation);
                instruccion.text = "Has invocado un arco";
                break;
            case "daga":
                arma = Resources.Load<GameObject>("EscenaArma/Armas/daga");
                Instantiate(arma, spawn.position, spawn.rotation);
                instruccion.text = "Has invocado una daga";
                break;
            case "hacha":
                arma = Resources.Load<GameObject>("EscenaArma/Armas/hacha");
                Instantiate(arma, spawn.position, spawn.rotation);
                instruccion.text = "Has invocado un hacha";
                break;
            case "lanza":
                arma = Resources.Load<GameObject>("EscenaArma/Armas/lanza");
                Instantiate(arma, spawn.position, spawn.rotation);
                instruccion.text = "Has invocado una lanza";
                break;
            default:
                arma = Resources.Load<GameObject>("EscenaArma/Armas/espada");
                Instantiate(arma, spawn.position, spawn.rotation);
                instruccion.text = "Has invocado una espada, ingresa otro nombre";
                break;
        }
    }


}
