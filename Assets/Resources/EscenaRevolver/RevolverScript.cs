using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolverScript : MonoBehaviour
{

    int balas = 6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Disparar();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(Recargar());
            return;
        }


    }


    public void Disparar()
    {
        if(balas > 0)
        {
            Debug.Log("Has disparado una bala");
            balas--;
        }else if(balas == 0)
        {
            StartCoroutine(Recargar());
            return;
        }
        
    }

 

    IEnumerator Recargar()
    {
        
        while(balas < 6)
        {
            yield return new WaitForSeconds(1);
            balas++;
            Debug.Log("Se ha recargado una bala, Tienes " + balas + " balas");
            
        }

    }

}
