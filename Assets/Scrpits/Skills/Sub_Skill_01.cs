using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Sub_Skill_01 : MonoBehaviour , ISkill , IPointerDownHandler
{

    Button button;

    void Start()
    {
        MainSkillSet();
    }

    public void MainSkillSet()  
    {
        int index = transform.GetSiblingIndex();
        button = GameObject.Find("Skills UI").transform.GetChild(index).GetComponent<Button>();

        button.onClick.AddListener(MainSkill);

    }

    public void MainSkill()
    {
        Debug.Log($"{gameObject.name} 메인 스킬 발동");
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("버튼 눌림");
    }

}
