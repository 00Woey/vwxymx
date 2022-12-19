namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Txttext rdtxt = new Txttext();
            rdtxt.wordcnt();
        }
    }

    class Txttext
    {
        string[] rdtxt;
        string fulltxt;
        int linecnt = 0; //라인수 체크용
        int wdcnt = 0; //단어수 체크용
        public Txttext()
        {
            rdtxt = File.ReadAllLines(@"course-1.txt"); //한줄씩 읽기
            for(int i = 0; i < rdtxt.Length; i++)
            {
                linecnt++;
                fulltxt += rdtxt[i] + "\n";
            }
            Console.WriteLine(fulltxt);
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
            wdcnt = fulltxt.Length - wdcnt;
            Console.WriteLine("단어수: " + wdcnt);
        }
    }


}