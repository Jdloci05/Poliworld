using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Coordenas : MonoBehaviour
{
    string pathFile;
    public Vector3[] posiciones;
    public GameObject palmera1;
    public GameObject palmera2;
    public GameObject palmera3;
    public GameObject palmera4;
    public GameObject palmera5;
    public GameObject palmera6;
    public GameObject palmera7;
    public GameObject palmera8;
    public GameObject palmera9;
    public GameObject palmera10;
    public GameObject palmera11;
    public GameObject palmera12;
    public GameObject palmera13;
    public GameObject palmera14;
    public GameObject palmera15;
    public GameObject palmera16;
    public GameObject palmera17;
    public GameObject palmera18;
    public GameObject palmera19;
    public GameObject palmera20;
    public GameObject palmera21;
    public GameObject palmera22;
    public GameObject palmera23;
    public GameObject palmera24;
    public GameObject palmera25;


    // Start is called before the first frame update
    void Start()
    {
        pathFile = "Assets/Archivo_coordenadas/Coordenadas.txt";
        lectura();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void lectura()
    {
        string[] fileline = File.ReadAllLines(pathFile);
        posiciones = new Vector3[fileline.Length];
        for (int i = 0; i < fileline.Length;)
        {
            string[] partes = fileline[i].Split("/"[0]);
            float x = float.Parse(partes[0]);
            float y = float.Parse(partes[1]);
            float z = float.Parse(partes[2]);
            posiciones[i] = new Vector3(x, y, z);


            palmera1.transform.Translate(new Vector3(posiciones[0].x, posiciones[0].y, posiciones[0].z));
            palmera2.transform.Translate(new Vector3(posiciones[1].x, posiciones[1].y, posiciones[1].z));
            palmera3.transform.Translate(new Vector3(posiciones[2].x, posiciones[2].y, posiciones[2].z));
            palmera4.transform.Translate(new Vector3(posiciones[3].x, posiciones[3].y, posiciones[3].z));
            palmera5.transform.Translate(new Vector3(posiciones[4].x, posiciones[4].y, posiciones[4].z));
            palmera6.transform.Translate(new Vector3(posiciones[5].x, posiciones[5].y, posiciones[5].z));
            palmera7.transform.Translate(new Vector3(posiciones[6].x, posiciones[6].y, posiciones[6].z));
            palmera8.transform.Translate(new Vector3(posiciones[7].x, posiciones[7].y, posiciones[7].z));
            palmera9.transform.Translate(new Vector3(posiciones[8].x, posiciones[8].y, posiciones[8].z));
            palmera10.transform.Translate(new Vector3(posiciones[9].x, posiciones[9].y, posiciones[9].z));
            palmera11.transform.Translate(new Vector3(posiciones[10].x, posiciones[10].y, posiciones[10].z));
            palmera12.transform.Translate(new Vector3(posiciones[11].x, posiciones[11].y, posiciones[11].z));
            palmera13.transform.Translate(new Vector3(posiciones[12].x, posiciones[12].y, posiciones[12].z));
            palmera14.transform.Translate(new Vector3(posiciones[13].x, posiciones[13].y, posiciones[13].z));
            palmera15.transform.Translate(new Vector3(posiciones[14].x, posiciones[14].y, posiciones[14].z));
            palmera16.transform.Translate(new Vector3(posiciones[15].x, posiciones[15].y, posiciones[15].z));
            palmera17.transform.Translate(new Vector3(posiciones[16].x, posiciones[16].y, posiciones[16].z));
            palmera18.transform.Translate(new Vector3(posiciones[17].x, posiciones[17].y, posiciones[17].z));
            palmera19.transform.Translate(new Vector3(posiciones[18].x, posiciones[18].y, posiciones[18].z));
            palmera20.transform.Translate(new Vector3(posiciones[19].x, posiciones[19].y, posiciones[19].z));
            palmera21.transform.Translate(new Vector3(posiciones[20].x, posiciones[20].y, posiciones[20].z));
            palmera22.transform.Translate(new Vector3(posiciones[21].x, posiciones[21].y, posiciones[21].z));
            palmera23.transform.Translate(new Vector3(posiciones[22].x, posiciones[22].y, posiciones[22].z));
            palmera24.transform.Translate(new Vector3(posiciones[23].x, posiciones[23].y, posiciones[23].z));
            palmera25.transform.Translate(new Vector3(posiciones[24].x, posiciones[24].y, posiciones[24].z));



            Debug.Log("Las coordenadas son: " + posiciones[i].ToString());

            i++;
        }


    }
    public void posicionar()
    {


    }
}
