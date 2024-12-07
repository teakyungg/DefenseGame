using System.Collections;
using UnityEngine;

public class Attack : MonoBehaviour // 공격 담당 
{
    [SerializeField] Transform Gun;

    [SerializeField] int bulletType;
    [SerializeField] float bulletspeed = 30f;
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
            Vector3 start_pos = Gun.position + new Vector3(0,1,0);
            Quaternion pos = Gun.rotation;
            pos.z = 0f;

            GameObject bullet = ObjectPool.objectpool.GetObject(bulletType);

            bullet.transform.position = start_pos;
            bullet.transform.rotation = pos;

            bullet.GetComponent<Bullet>().EnemyTag = player.EnemyTag; 
            bullet.GetComponent<Bullet>().DestoryDelay();

            bullet.GetComponent<Rigidbody>().velocity = Vector3.zero;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletspeed, ForceMode.Impulse);
        }

        
    }

    void FixedUpdate()
    {
        attacktrue -= Time.deltaTime;
    }

}
