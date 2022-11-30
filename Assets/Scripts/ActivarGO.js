#pragma strict
 
var CameraWater : GameObject;

function Start()
{
    CameraWater.SetActive(false);
}

function OnTriggerEnter () 
 
{  
      
      
    
   CameraWater.SetActive (true);
}

function OnTriggerExit ()
{
    CameraWater.SetActive (false);
}