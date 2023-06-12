using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    
    public GameObject tppCam;
    public GameObject fppCam;
    
    public bool IsFpp = false;

void Start()
{
    
}
void Update()
{
    

 if (Input.GetKeyDown(KeyCode.Q))
 {
    if(IsFpp == false)
    {
      Fpp();
    }
    else
    {
      Tpp();
    }
 }
       
}

private void Fpp()
{
    fppCam.SetActive(true);
    tppCam.SetActive(false);
    IsFpp = true;
}

private void Tpp()
{
    fppCam.SetActive(false);
    tppCam.SetActive(true);
    IsFpp = false;
}



}
