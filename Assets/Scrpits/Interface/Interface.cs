using UnityEngine;

interface ICharacter // ĳ���� ���� �������̽�
{
    public int HP { get; set; }


    public void Damage(int num);
    public void Heal(int num);
}

interface IRocation  // ȸ�� ���� �������̽�
{
    public float RocationSpeed { get; set; }    // ȸ�� �ӵ� ����


    public void firstTarget();                  // ������ ���� �� ���� ����� ���� ã�� �Լ�
    public void rocation(Transform target);     // target���� �������� ȸ��

}


interface IDamageUI     // ������ UIâ�� ���°� ���� �������̽�
{
    public void GetUILocation();     // ������Ʈ ��ġ���� UI��ġ ã�� �Լ�
    public void SetDamage(int dmg);  // ���� �������� ���� �Լ� 

}

interface ISkill    // ��ų ���� �������̽�
{
    public void MainSkillSet(); // ���� ��ų�� ��ų ��ư�ִ� ������ �����ϴ� �Լ� 
    public void MainSkill();    // ���� ��ų �Լ�

}
