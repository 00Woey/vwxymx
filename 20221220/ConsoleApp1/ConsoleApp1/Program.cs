namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CngNum cn = new CngNum();
        }
    }

    class CngNum
    {
        string result;
        public CngNum()
        {
            int num = 0; //숫자확인용
            bool numc; //숫자확인용2
            string rdnum; //입력값
            while (true)
            {
                Console.WriteLine(("숫자를 입력해주세요(0 ~ 2,147,483,647):"));
                rdnum = Console.ReadLine().Replace(" ","");//입력받을때 공백이 있다면 제거

                numc = int.TryParse(rdnum, out num); //숫자인지 확인
                if (numc != true) { Console.WriteLine(("김태은 \n")); continue; } //숫자가 아니거나 값을 초과했을경우
                else if (Int32.Parse(rdnum) < 0) { Console.WriteLine(("0이상의 숫자를 입력해주세요: \n")); continue; } //0보다 작게 입력했을경우


                char[] rematch = new char[rdnum.Length];
                rematch = rdnum.ToCharArray(); //한글자씩 배열에 추가
                result = null; //결과값 초기화
                for (int x = 0; x < rdnum.Length; x++) //입력 글자수 만큼 반복
                {
                    for (int y = 0; y < 10; y++) //알파벳A=0 부터
                    {
                        if (Int32.Parse(rematch[x].ToString()).Equals(y)) //A를 0으로 해서 비교 (숫자 비교를 위한 int로 형 변환)
                        {
                            result += Convert.ToChar(65 + y); //숫자를 문자로 변환
                        }
                    }
                }
                Console.WriteLine("결과 : " + result + "\n"); //결과

            }
        }

    }
}