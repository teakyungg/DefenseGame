using UnityEngine;

interface ICharacter // 캐릭터 관련 인터페이스
{
    public int HP { get; set; }


    public void Damage(int num);
    public void Heal(int num);
}

interface IRocation  // 회전 관련 인터페이스
{
    public float RocationSpeed { get; set; }    // 회전 속도 조절


    public void firstTarget();                  // 범위의 적들 중 가장 가까운 적을 찾는 함수
    public void rocation(Transform target);     // target으로 방향으로 회전

}


interface IDamageUI     // 데미지 UI창에 띄우는거 관련 인터페이스
{
    public void GetUILocation();     // 오브젝트 위치에서 UI위치 찾는 함수
    public void SetDamage(int dmg);  // 받은 데미지를 띄우는 함수 

}

interface ISkill    // 스킬 관련 인터페이스
{
    public void MainSkillSet(); // 메인 스킬을 스킬 버튼있는 곳으로 세팅하는 함수 
    public void MainSkill();    // 메인 스킬 함수

}
