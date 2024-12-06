using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float bulletspeed = 30f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        rb.AddForce(transform.right * bulletspeed , ForceMode.Impulse);

        Destroy(gameObject, 3f);
    }

}
