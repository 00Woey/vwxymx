using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NearTxt nt = new NearTxt();
        }
    }
    class NearTxt
    {
        public NearTxt()
        {
            decimal num = 0.0m; //문자확인용
            bool numc; //문자확인용2
            string s; //문자 입력
            int txtcnt1 = 0; //앞에서
            //int txtcnt2 = 0; //뒤에서
            string resultspl; //쉼표 구분


            while (true)
            {
                Console.WriteLine(("문자를입력해주세요"));
                s = Console.ReadLine().Replace(" ", "").ToLower();//입력받을때 공백제거, 값 소문자 변환
                numc = decimal.TryParse(s, out num);
                if (numc == true) { Console.WriteLine(("문자를 적어주세요 \n")); continue; } //문자가 아닐경우
                else if (s.Length < 1 || s.Length > 10000) { Console.WriteLine(("1~10000자 이내로 적어주세요 \n")); continue; } //길이가 1~10000자가 아닐경우
                break;
            }
           
            int[] result = new int[s.Length]; //결과

            //Console.WriteLine(s);
            for (int i = 0; i < s.Length; i++) //맨앞부터 글자길이만큼 반복
            {
                if (i == 0) { result[i] = -1; continue;} //맨 앞 글자일 경우엔 무조건 -1
                for (int x = i - 1; x > -1; x--) //기존 글자 바로 앞글자부터 순서로 역으로 읽기
                {
                    if (s[i] == s[x])
                    {
                        txtcnt1 = (i-x); //두 글자간 사이 계산
                       // Console.WriteLine(s[i] + " . " + s[x] + " : "+ txtcnt1);
                        break;
                    }
                    else
                    {
                        txtcnt1 = -1; //위에 조건 일치하지 않으면(동일한 글자x) -1
                    }

                }

                result[i] = txtcnt1;

                /*
                if (txtcnt1 == txtcnt2)
                {
                    result[i] = -1;
                    Console.WriteLine(txtcnt1 + " " + txtcnt2 + " " + result[i]);
                }
                else if(txtcnt1 < txtcnt2)
                {
                    result[i] = txtcnt1 - txtcnt2 +1 ;
                    Console.WriteLine(txtcnt1 + " " + txtcnt2 + " " + result[i]);
                }
                */
            }
            resultspl = string.Join(", ", result); //배열 , 로 구분
            Console.WriteLine("[" + resultspl + "]");
           



        }
    }
}