namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Txttext rdtxt = new Txttext();
            rdtxt.wordcnt(); //단어수
            rdtxt.wordrate(); //단어별 빈도
        }
    }

    class Txttext
    {
        string[] rdtxt;
        string fulltxt;
        int linecnt = 0; //라인수 체크용
        int wdcnt = 0; //단어수 체크용
        int swdcnt = 0; //특정 단어 체크용
        public Txttext()
        {
            rdtxt = File.ReadAllLines(@"course-1.txt"); //한줄씩 읽기
            for(int i = 0; i < rdtxt.Length; i++)
            {
                linecnt++;
                if (i < 1)
                {
                    fulltxt += rdtxt[i];
                }
                else
                { 
                    fulltxt += " \n" + rdtxt[i]; 
                }
            }
            //Console.WriteLine(fulltxt);
            Console.WriteLine("라인수: " + linecnt);
        }

        public void wordcnt()
        {
            for(int a = 0; a < fulltxt.Length; a++) //공백 개수로 단어수 예상
            {
                if (fulltxt[a] == ' ')
                {
                    wdcnt++;
                }
            }
            //wdcnt = fulltxt.Length - wdcnt;
            Console.WriteLine("단어수: " + (wdcnt+1));
        }

        public void wordrate()
        {
            Console.WriteLine(("찾을 단어를 입력해주세요:"));
            string searchwd = Console.ReadLine();
            string[] repfulltxt = fulltxt.Split(" ");
             for (int b = 0; b < repfulltxt.Length; b++) //
             {
                 if (repfulltxt[b].ToUpper().Equals(searchwd.ToUpper())) //대소문자 구분안하기 위한 대문자로 변환해서 비교
                 {
                     swdcnt++;
                 }
             }
            Console.WriteLine(searchwd + " 단어수: " + (swdcnt));
        }
    }


}