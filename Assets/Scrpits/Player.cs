using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour , ICharacter
{
    [SerializeField] int StartHP;
    
    public string EnemyTag; // �� �±�
    public bool Attack; // true�� ���� ���� ����� �ִٴ� �ǹ�
    public bool AttackAniFinish; // true�� ���� �ִϸ��̼��� �غ� �Ǿ��ٴ� ��

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

       if(DamageUI) DamageUI.DamageTextSetting(damage); // ������ ����Ʈ ����
    }


}
