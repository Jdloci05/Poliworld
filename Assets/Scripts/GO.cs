using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO : MonoBehaviour
{
    public GameObject CameraWater;
    // Start is called before the first frame update
    void Start()
    {
        CameraWater.SetActive(false);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay()
    {
        CameraWater.SetActive(true);
    }

    private void OnTriggerExit()
    {
        CameraWater.SetActive(false);
    }
}