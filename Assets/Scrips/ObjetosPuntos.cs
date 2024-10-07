using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlataformaMovimiento : MonoBehaviour
{
    [SerializeField] float Velocidad;
    [SerializeField] Transform[] puntosDeMovimiento;
    [SerializeField] float rotationVelocity;
    private int i = 0;
    void Start()
    {
        
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntosDeMovimiento[i].transform.position, Velocidad * Time.deltaTime);

        if (Vector2.Distance(transform.position, puntosDeMovimiento[i].transform.position) < 0.1f)
        {
            if (puntosDeMovimiento[i] != puntosDeMovimiento[puntosDeMovimiento.Length - 1])
            {
                i++;
            }
            else
            {
                i = 0;
            }
        }
       
        transform.Rotate((Vector3.forward * rotationVelocity * Time.deltaTime), Space.World);
    }
}
