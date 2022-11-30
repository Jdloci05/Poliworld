using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas : MonoBehaviour
{
    public Rigidbody platMovimiento;
    
    public Transform[] posiciones;

    public float velocidadPla;

    private int posicionActual = 0;
    private int siguientePosicion = 1;

    void movimientoPlataforma()
    {                                                       // Punto 0 sera la posición inicial de la plataforma
        platMovimiento.MovePosition(Vector3.MoveTowards(platMovimiento.position, posiciones[siguientePosicion].position, velocidadPla * Time.deltaTime));

        if( Vector3.Distance(platMovimiento.position, posiciones[siguientePosicion].position) <= 0) // SI la distancia entre la plataforma y
                                                                                                    // el punto a desplazarse estan juntos( = 0)
        {
            posicionActual = siguientePosicion;
            siguientePosicion++;        // Permitiendo añadir mas puntos de referencia de movimiento OWO

            if( siguientePosicion > posiciones.Length - 1)          //evita el error de superar el tamaño de la lista
            {
                siguientePosicion = 0; // Posición inicial donde arranco
            }
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimientoPlataforma();
       
    }
}
