//읽기전용 필드 - Readonly
//클래스 내부에도 읽기만 가능하게 하고싶거나 한번쓴 값을 재설정 못하게
public class Scheduler
{
    readonly int second = 1; //읽기전용 필드를 정의하고 값 대입
    readonly string name; //정의만

    public Scheduler()
    {
        this.name = "일정관리"; //생성자에서도 대입가능
    }

    public void Run()
    {
        //this.second = 5; //일반 메서드에서는 값 대입 물가
    }
}
namespace RonlyField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scheduler sched = new Scheduler();
            sched.Run();
        }
    }
}