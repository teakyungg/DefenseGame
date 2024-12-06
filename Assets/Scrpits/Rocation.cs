using System.Collections.Generic;
using UnityEngine;

public class Rocation : MonoBehaviour   // 가장 가까운 적 방향으로 회전하는 클래스
{
    bool enemyCheck = false;
    List<Transform> enemys = new List<Transform>();
    [SerializeField] Transform Target;
    Player player;
    Quaternion startRocation;

    public float RocationSpeed = 10f;

    void Awake()
    {
        player = GetComponent<Player>();
        startRocation = transform.rotation;
    }

    void Reset()
    {
        enemyCheck = false;
        Target = null;
        player.Attack = false;

        enemys.Clear();
    }

    void OnTriggerStay(Collider other)
    {
        if (enemyCheck) return;
        if (other.tag == player.EnemyTag) enemys.Add(other.transform);
    }

    void Update()
    {
        if (Target && Target.gameObject.activeSelf == false) Reset();     // 공격하던 적이 비활성화 됬을때
        if (enemyCheck || enemys.Count == 0) return;

        enemyCheck = true;

        Target = enemys[0];
        float min = (transform.position - enemys[0].position).sqrMagnitude;

        for (int i = 0; i < enemys.Count; i++)
        {
            float enemy = (transform.position - enemys[i].position).sqrMagnitude;

            if (enemy < min)
            {
                min = enemy;
                Target = enemys[i];
            }

        }

    }

    void LateUpdate()
    {
        if (Target)
        {
            Quaternion targetLocation = Quaternion.LookRotation(Target.transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetLocation, Time.deltaTime * RocationSpeed);

            player.Attack = true;
        }

        else if(!Target)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, startRocation, Time.deltaTime * RocationSpeed);
        }


    }

}
