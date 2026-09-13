using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verificacionEjercicio1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("Awake");
    }

    void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        Debug.Log("Update");
    }

    void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
