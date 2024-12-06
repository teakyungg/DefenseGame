using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations: MonoBehaviour
{
    Player player;
    Animator animator;

    void Awake()
    {
        player = GetComponent<Player>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (player.Attack) animator.SetBool("attack", true);

        else if(!player.Attack)
        {
            animator.SetBool("attack", false);
            player.AttackAniFinish = false;
        }

    } 

    public void Attack_Ani_Finish()
    {
        player.AttackAniFinish = true;
    }



}
