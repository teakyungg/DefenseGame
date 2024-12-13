using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageUI : MonoBehaviour , IDamageUI
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
        GetUILocation();
    }

    void Update()
    {
        GetUILocation();
    }

    public void GetUILocation()
    {
        pos = transform.position;

        pos = Camera.main.WorldToScreenPoint(pos);
        pos.z = 0f;
        pos += Add;
    }

    public void SetDamage(int dmg)
    {
        Text damage_txt = ObjectPool.objectpool.GetObject(0).GetComponent<Text>();

        damage_txt.text = dmg.ToString();
        damage_txt.transform.position = pos;

        damage_txt.gameObject.SetActive(false);
        damage_txt.gameObject.SetActive(true);
    }

}
