using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cura : MonoBehaviour
{
    [SerializeField] float Heal;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<ControladorVida>())
        {
            collision.gameObject.GetComponent<ControladorVida>().RecibirCura(Heal);
        }
    }
}
