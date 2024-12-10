using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour , ICharacter
{
    [SerializeField] int StartHP;
    
    public string EnemyTag; // 적 태그
    public bool Attack; // true면 현재 공격 대상이 있다는 의미
    public bool AttackAniFinish; // true면 공격 애니메이션이 준비 되었다는 뜻

    public int HP { get; set; }

    DamageUI DamageUI;

    void Awake()
    {
        DamageUI = GetComponent<DamageUI>();
    }

    void Start()
    {
        HP = StartHP;
    }

    public void TakeDamage(int damage)
    {
        HP -= damage;
        if (HP < 0) HP = 0;

       if(DamageUI) DamageUI.DamageTextSetting(damage); // 데미지 이펙트 띄우기
    }


}
