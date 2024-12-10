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

    void Start()
    {
        rb.AddForce(transform.right * bulletspeed, ForceMode.Impulse);
        Invoke("DestoryBullet", 3f);
    }

    void OnTriggerEnter(Collider target)
    {
        if (target.tag != gameObject.tag)
        {
            target.GetComponent<Player>().TakeDamage(damage);
            gameObject.SetActive(false);
        }
    }

    void DestoryBullet()
    {
        ObjectPool.objectpool.DestoryObject(bullet);
    }

 
}
