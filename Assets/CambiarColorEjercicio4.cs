using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColorEjercicio4 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
