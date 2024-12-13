using System.Collections.Generic;
using UnityEngine;


public class Rocation : MonoBehaviour , IRocation 
{
    bool enemyCheck = false;
    List<Transform> enemys = new List<Transform>();
    [SerializeField] Transform Target;
    Player player;

    public float RocationSpeed { get; set; }

    void Awake()
    {
        player = GetComponent<Player>();
        RocationSpeed = 10f;
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
        firstTarget();
    }

    void LateUpdate()
    {
        if(Target) rocation(Target);
    }


    public void rocation(Transform target)
    {
        if (target)
        {
            Quaternion targetLocation = Quaternion.LookRotation(target.transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetLocation, Time.deltaTime * RocationSpeed);

            player.Attack = true;
        }
    }


    public void firstTarget()
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



}
