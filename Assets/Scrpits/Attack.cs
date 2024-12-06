using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour // ���� ��� 
{
    public GameObject bullet;
    public Transform Gun;

    [SerializeField]float delay = 0.2f;
    float attacktrue = 0;
    Player player;
    
    // ���� ��� ���� ������ �ؾ��Ұ� ������

    void Awake()
    {
        player = GetComponent<Player>();
    }

    void Update()
    {

        if(player.AttackAniFinish && attacktrue < 0)
        {
            attacktrue = delay;
            Vector3 start_pos = Gun.position + new Vector3(1,0.7f,1);
            Quaternion pos = Gun.rotation;
            pos.z = 0f;

            Instantiate(bullet, start_pos, pos);
        }

    }

    void FixedUpdate()
    {
        attacktrue -= Time.deltaTime;
    }

}
