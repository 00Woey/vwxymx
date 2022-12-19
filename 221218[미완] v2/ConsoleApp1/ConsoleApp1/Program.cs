namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baseball game = new Baseball();
        }
    }

    class Baseball
    {
        int[] rdnum;
        int strike;
        int ball;
        int bout;
        int cntgame = 0;

        public Baseball()
        {
            Console.WriteLine("각 1~9 범위의 숫자를 각 세번 입력해주세요");
            while (true) //숫자입력
            {
                strike = 0;
                ball = 0;
                bout = 0;
                int[] usernum = new int[3];
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine((i + 1) + "번째 숫자를 입력해주세요.");
                    usernum[i] = Int32.Parse(Console.ReadLine());
                }
                if (usernum[0].Equals(usernum[1]) || usernum[0].Equals(usernum[2]) || usernum[1].Equals(usernum[2])) //중복값 체크
                {
                    Console.WriteLine("중복입력하셨습니다.");
                    continue;
                }
                Rdnums(); //랜덤숫자 생성
                cntgame++;
                for (int a = 0; a <= 2; a++)
                {
                    for(int b = 0; b<=2; b++)
                    {
                        if (usernum[a].Equals(rdnum[b]))
                        {
                            if (a == b) { strike++; } //위치랑 숫자가 전부같을경우 스트라이크
                            else { ball++; } //숫자는 같지만 위치는 다를경우 볼
                        }
                        if (!usernum[a].Equals(rdnum[b]) && a == b)
                        {

                            bout++; //전부 다르면 아웃
                        }
                    }
                }
                bout = bout - ball;
                Console.WriteLine("스트라이크: " + strike + " 볼: " + ball + " 아웃: " + bout + " 게임횟수: " + cntgame + " 게임구동시간: 미완성" );
                
            }

        }
        public void Rdnums() //랜덤숫자 생성
        {
            rdnum = new int[3];
            for (int i = 0; i <= 2; i++)
            {
                rdnum[i] = new Random().Next(1, 10);
            }
        }
    }
}