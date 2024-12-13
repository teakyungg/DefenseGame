using UnityEngine;

public class Bullet : MonoBehaviour
{
    public string EnemyTag;
    [SerializeField] float bulletspeed = 30f;
    [SerializeField] int damage = 10;

    Component bullet;
    Rigidbody rb;

    void Awake()
    {
        bullet = GetComponent<Bullet>();
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.velocity = transform.forward * bulletspeed;
    }

    void OnTriggerEnter(Collider target)
    {
       
        if (target.tag == EnemyTag)
        {
            target.GetComponent<Player>().Damage(damage);
            gameObject.SetActive(false);
        }
        
    }

    void DestoryBullet()
    {
        ObjectPool.objectpool.DestoryObject(bullet);
    }

 
}
