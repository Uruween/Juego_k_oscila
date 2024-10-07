using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorVida : MonoBehaviour
{
    [SerializeField] float vida;
    [SerializeField] float vidaMaxima;


    public void RecibirDaño (float daño) 
    {
        vida -= daño;

        if (vida <= 0)
        {
            Debug.Log("Muelto");
            Destroy(gameObject);
        }
    }

    public void RecibirCura (float cura) 
    {
        vida += cura;
        if (vida >= vidaMaxima) 
        {
            vida = vidaMaxima;
        }
    }
}
