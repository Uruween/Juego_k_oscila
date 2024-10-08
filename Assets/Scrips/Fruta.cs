using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Fruta : MonoBehaviour
{
    private Animator satoru;
    void Start()
    {
        satoru = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        satoru.SetTrigger("Fruta");
    }

}
