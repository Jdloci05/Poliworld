using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransporte : MonoBehaviour
{
    public Transform teletransporte;
    public GameObject Jugador;

    private void OnTriggerEnter(Collider other)
    {
        Jugador.transform.position = teletransporte.transform.position;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
