using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Daño : MonoBehaviour
{
    [SerializeField] float DMG;
    private void OnCollisionEnter2D (Collision2D collision)
    {
       if (collision.gameObject.GetComponent<ControladorVida>()) 
       {
           collision.gameObject.GetComponent<ControladorVida>().RecibirDaño(DMG);
       } 
    }
}
