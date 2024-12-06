using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour // 공격 담당 
{
    public GameObject bullet;
    public Transform Gun;

    [SerializeField]float delay = 0.2f;
    float attacktrue = 0;
    Player player;
    
    // 공격 모션 부터 구현을 해야할거 같은데

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
