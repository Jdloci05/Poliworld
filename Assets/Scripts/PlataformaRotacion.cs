using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaRotacion : MonoBehaviour
{
    public Rigidbody platRotacion;
    public float velocidadRota;
    public Transform centroRotacion;

    void rotacionPlataforma()
    {
        platRotacion.transform.RotateAround(centroRotacion.transform.position, centroRotacion.TransformVector(new Vector3(0, 1, 0)), (velocidadRota) * Time.deltaTime);
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotacionPlataforma();
    }
}
