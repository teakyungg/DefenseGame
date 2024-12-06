using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string EnemyTag; // 적 태그
    public bool Attack; // true면 현재 공격 대상이 있다는 의미
    public bool AttackAniFinish; // true면 공격 애니메이션이 준비 되었다는 뜻
}
