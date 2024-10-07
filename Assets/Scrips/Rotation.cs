using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] Vector3 ejes;
    void Update()
    {
        transform.Rotate(ejes * Time.deltaTime, Space.World);
    }
}
