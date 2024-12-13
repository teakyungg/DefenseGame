using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
    public GameObject Damage;
   
    void Awake()
    {
        Application.targetFrameRate = 60;
        Screen.SetResolution(1920, 1080, true);
    }


}
