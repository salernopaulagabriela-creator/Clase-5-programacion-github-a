using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverAdelanteEjercicio3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
        [SerializeField] float velocidad = 5f;

    void Update()
    {
        transform.Translate(transform.forward * velocidad * Time.deltaTime);
    }
    
}
