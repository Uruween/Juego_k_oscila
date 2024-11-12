using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruta : MonoBehaviour
{
    private Animator Suguru;
    [SerializeField] private float puntosRecolectados;
    [SerializeField] private Puntos puntos;
    private void Update()
    {
        Suguru = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Suguru.SetTrigger("tocaFruta");
        if (collision.CompareTag("Player"))
        {
            puntos.Sumarpuntos(puntosRecolectados);
            Destroy(gameObject, 0.60f);
        }
    }
}
