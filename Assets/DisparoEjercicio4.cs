using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEjercicio4 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("La flecha toco a: " + collision.gameObject.name);
        gameObject.SetActive(false);
    }
}
