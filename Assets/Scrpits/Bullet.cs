using UnityEngine;

public class Bullet : MonoBehaviour
{
    public string EnemyTag;

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
       gameObject.SetActive(false);
    }

 
}
