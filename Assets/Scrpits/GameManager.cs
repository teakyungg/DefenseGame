using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour 
{
    public GameObject Damage;

    public string[] CharName;   // 캐릭터의 순서와 이름
    public GameObject UISkill;


    void Awake()
    {
        Application.targetFrameRate = 60;
        Screen.SetResolution(1920, 1080, true);
    }

    void Start()
    {
        SkillSetting();
    }

    void SkillSetting()
    {
        for(int i = 0; i < CharName.Length; i++)
        {
            GameObject child = UISkill.transform.GetChild(i).gameObject;

            Type type = Type.GetType(CharName[i]);
            child.AddComponent(type);
        }

    }


}
