using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour   // 캐릭터 움직임 제어
{
    [SerializeField] float Speed = 10f;
    Rigidbody rb;

    Player player;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        player = GetComponent<Player>();
    }

    void Start()
    {
        if (gameObject.tag == "enemy") Speed = -Speed;
    }

    void FixedUpdate()
    {
        if (player.Attack) return;

        rb.MovePosition(rb.position + new Vector3(0,0,1) * Speed * Time.fixedDeltaTime);
    }



}
