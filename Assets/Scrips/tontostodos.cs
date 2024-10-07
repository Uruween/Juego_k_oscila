using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tontostodos : MonoBehaviour
{
    [SerializeField] List<Transform> puntos;
    int i = 0;
        
    [SerializeField] float velocidad;
    private void Start()
    {
        foreach (var item in puntos) 
        {
            item.SetParent(null);
        }
    }
    void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, puntos[i].rotation, velocidad * Time.deltaTime);

        if (transform.rotation == puntos[i].rotation)
        {
            if (i + 1 > puntos.Count -1)
            {
                i = 0;
            }
            else 
            {
               i++;
            }
        }
    }
}
