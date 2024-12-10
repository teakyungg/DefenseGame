using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageUI : MonoBehaviour
{
    GameManager gameManager;
    GameObject UI;

    [SerializeField] Vector3 Add;
    Vector3 pos;
    Transform damage_pos;
    Text damage_txt;

    void Awake()
    {
        UI = GameObject.Find("Damage UI");
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Start()
    {
        PositonSetting();
        damage_pos = Instantiate(gameManager.Damage, pos, Quaternion.identity, UI.transform).transform;
        damage_txt = damage_pos.GetComponent<Text>();
    }

    void Update()
    {
        PositonSetting();
        damage_pos.position = pos;
    }

    public void DamageTextSetting(int damage)
    {
        damage_txt.text = damage.ToString();
        Debug.Log($"{damage}데미지 입음 여기 부분에 데미지 올라가는거 구현하기");
    }

    void PositonSetting()
    {
        pos = transform.position;

        pos = Camera.main.WorldToScreenPoint(pos);
        pos.z = 0f;
        pos += Add;
    }



}
