using System.Collections;
using UnityEngine;

public class Attack : MonoBehaviour // 공격 담당 
{
    [SerializeField] Transform Gun;

    [SerializeField] int bulletType;
    [SerializeField] float delay = 0.2f;
    float attacktrue = 0;
    Player player;

    void Awake()
    {
        player = GetComponent<Player>();
    }

    void Update()
    {

        if(player.AttackAniFinish && attacktrue < 0)
        {
            attacktrue = delay;
            Quaternion pos = Gun.rotation;
           

            GameObject bullet = ObjectPool.objectpool.GetObject(bulletType);
            bullet.transform.position = Gun.position;
            bullet.transform.rotation = Gun.rotation;
          


            bullet.GetComponent<Bullet>().EnemyTag = player.EnemyTag;
        }

        
    }

    void FixedUpdate()
    {
        attacktrue -= Time.deltaTime;
    }

}
