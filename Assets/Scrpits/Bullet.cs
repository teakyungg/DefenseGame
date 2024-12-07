using UnityEngine;

public class Bullet : MonoBehaviour
{
    public string EnemyTag;
    Component bullet;

    void Start()
    {
        bullet = GetComponent<Bullet>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == EnemyTag) gameObject.SetActive(false);
    }

    public void DestoryDelay()
    {
        Invoke("DestoryBullet", 3f);
    }

    void DestoryBullet()
    {
        ObjectPool.objectpool.DestoryObject(bullet);
    }

 
}
