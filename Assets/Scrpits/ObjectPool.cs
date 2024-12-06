using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool objectpool;
    List<GameObject> bullet = new List<GameObject>();
    [SerializeField] GameObject Bullet;

    void Start()
    {
        objectpool = this;
        bullet.Clear();
    }

    public GameObject ReturnBullet()
    {
        GameObject target = null;

        for(int i=0; i < bullet.Count; i++)
        {
            if (bullet[i].activeSelf == false)
            {
                target = bullet[i];
                break;
            }
        }

        if (target == null)
        {
            target = CreateBullet();
        }

        target.SetActive(true);

        return target;
    }

    GameObject CreateBullet()
    {
        GameObject target = Instantiate(Bullet);
        bullet.Add(target);

        return target;
    }

}
