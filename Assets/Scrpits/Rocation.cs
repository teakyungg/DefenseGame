using System.Collections.Generic;
using UnityEngine;

public class Rocation : MonoBehaviour   // ���� ����� �� �������� ȸ���ϴ� Ŭ����
{
    bool enemyCheck = false;
    List<Transform> enemys = new List<Transform>();
    Transform Target;
    Player player;

    public float RocationSpeed = 10f;

    void Awake()
    {
        player = GetComponent<Player>();
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

    void OnTriggerExit(Collider other)
    {

        if(Target && other.gameObject == Target.transform.gameObject) // �����ϴ� ���� ������ ������ �� 
        {
            Reset();
        }

    }

    void Update()
    {
        if (Target && Target.gameObject.activeSelf == false) Reset();     // �����ϴ� ���� ��Ȱ��ȭ ������
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
    }

}