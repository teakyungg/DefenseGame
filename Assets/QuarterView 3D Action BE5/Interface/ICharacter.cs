interface ICharacter // 이 인터페이스를 상속받으면 체력,체력에 데미지를 주는 함수 이 2개를 무조건 구현하겠다는 의미이다.
{
   public int HP { get; set; }  // 캐릭터의 체력
   public void TakeDamage(int damage);  // 데미지를 준다.
}