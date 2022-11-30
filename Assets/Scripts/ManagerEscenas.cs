using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerEscenas : MonoBehaviour
{

    //public string LevelName;
    public int nivel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider objeto)
    {
        if (objeto.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(nivel);
        }
            
    }

    public void EscenaJuego(int nivel)
    {
        SceneManager.LoadScene(nivel);
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Salio UWU");
    }
}