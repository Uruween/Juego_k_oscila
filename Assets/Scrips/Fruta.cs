using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Fruta : MonoBehaviour
{
    [SerializeField] private GameObject tontostodos;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            Instantiate(tontostodos, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
