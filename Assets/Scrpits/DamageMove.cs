using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMove : MonoBehaviour
{
    RectTransform RectTransform;
    Vector3 pos;
    [SerializeField] Vector3 add = new Vector3(2f, 2f, 0);
    [SerializeField] float DestoryTime = 0.2f;

    float Destorytime;

    void Start()
    {
        RectTransform = GetComponent<RectTransform>();
    }

    void OnEnable()
    {
        Destorytime = DestoryTime;
    }

    void Update()
    {
        Destorytime -= Time.deltaTime;
        pos = RectTransform.anchoredPosition3D;
        pos += add;
    }

    void LateUpdate()
    {
        if(Destorytime < 0) gameObject.SetActive(false);
        RectTransform.anchoredPosition3D = pos;
    }



}
