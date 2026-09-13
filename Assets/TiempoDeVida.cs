using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoDeVida : MonoBehaviour
{
    [SerializeField] float tiempoRestante = 200f;

    void Update()
    {
        tiempoRestante -= Time.deltaTime;
        Debug.Log(tiempoRestante);
    }
}
