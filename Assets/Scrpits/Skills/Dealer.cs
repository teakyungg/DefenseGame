using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dealer : MonoBehaviour , IPointerDownHandler ,IPointerUpHandler ,IPointerEnterHandler ,IPointerExitHandler
{
    [SerializeField] private bool skillClick;     // true면 클릭 중, false면 손땜
    [SerializeField] private bool skill_revert;   // true면 현재 스킬창에 마우스 있음
    GameObject SkillArrow;
    Vector3 ResetPostion = new Vector3(0, 999, 0);

    void Start()
    {
        Debug.Log("버튼에 접근해서 스킬 세팅하기");
        SkillArrow = GameObject.Find("skill arrow");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        skillClick = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        skillClick = false;

        if(!skill_revert)
        {
            Debug.Log("스킬 실행하기");
        }

        else if(skill_revert)
        {
            Debug.Log("스킬 취소하기");
        }

        SkillArrow.transform.position = ResetPostion;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        skill_revert = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        skill_revert = false;
    }

    private void Update()
    {
        

        if (skillClick)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SkillArrow.transform.position = pos;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100f, LayerMask.GetMask("Floor")))
            {
                Vector3 hitpostion = hit.point;
                hitpostion.y = 2f;

                SkillArrow.transform.position = hitpostion;
            }

            
        }

       

    }



}
