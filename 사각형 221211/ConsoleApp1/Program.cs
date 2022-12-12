namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, w1, h1, x2, y2, w2, h2;
            int leftx1, rightx1, topy1, bottomy1;
            int leftx2, rightx2, topy2, bottomy2;
            bool numc;

            while (true)
            {
                Console.WriteLine("첫번째 도형의 X좌표값을 입력해주세요");
            x1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("첫번째 도형의 Y좌표값을 입력해주세요");
            y1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("첫번째 도형의 너비를 입력해주세요(왼쪽으로 길어지면 음수, 오른쪽으로 길어지면 양수)");
            w1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("첫번째 도형의 높이를 입력해주세요(위로 길어지면 양수, 아래로 길어지면 음수)");
            h1 = Int32.Parse(Console.ReadLine());

            if (w1 == 0 || h1 == 0) //0 적을시 안내
            {
                    Console.WriteLine("너비와 높이를 0으로 입력하지마세요. \n");
                    continue;
            }

                if (w1 < 0) //길이가 왼쪽으로 길어질때 가로 좌표 재정립
            {
                leftx1 = Math.Min(x1, x1 + w1); //왼쪽 꼭지점
                rightx1 = Math.Max(x1, x1 + w1); //오른쪽 꼭지점
            }
            else
            {
                leftx1 = x1;
                rightx1 = x1 + w1;
            }
            if (h1 < 0) //높이가 아래로 길어질때 세로 좌표 재정립
            {
                bottomy1 = Math.Min(y1, y1 + h1); //아래쪽 꼭지점
                topy1 = Math.Max(y1, y1 + h1); //위쪽 꼭지점
            }
            else
            {
                bottomy1 = y1;
                topy1 = y1 + h1;
            }

            Console.WriteLine("두번째 도형의 X좌표값을 입력해주세요");
            x2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("두번째 도형의 Y좌표값을 입력해주세요");
            y2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("두번째 도형의 너비를 입력해주세요(왼쪽으로 길어지면 음수, 오른쪽으로 길어지면 양수)");
            w2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("두번째 도형의 높이를 입력해주세요(위로 길어지면 양수, 아래로 길어지면 음수)");
            h2 = Int32.Parse(Console.ReadLine());

            if (w2 == 0 || h2 == 0) //0 적을시 안내
            {
                    Console.WriteLine("너비와 높이를 0으로 입력하지마세요. \n");
                    continue;
            }

                if (w2 < 0) //두번째 사각형 위와 동일
            {
                leftx2 = Math.Min(x2, x2 + w2);
                rightx2 = Math.Max(x2, x2 + w2);
            }
            else
            {
                leftx2 = x2;
                rightx2 = x2 + w2;
            }
            if (h2 < 0)
            {
                bottomy2 = Math.Min(y2, y2 + h2);
                topy2 = Math.Max(y2, y2 + h2);
            }
            else
            {
                bottomy2 = y2;
                topy2 = y2 + h2;
            }
            /*
            1. 첫번째 사각형의 왼쪽 꼭지점이 두번째 사각형 오른쪽 꼭지점과 닿는지 2L■R 1L■R

            2. 두번째 사각형의 왼쪽 꼭지점이 첫번째 사각형 오른쪽에 닿는지 1L■R 2L■R

            3. 첫번째 사각형의 맨위 꼭지점이 두번째 사각형의 아래 꼭지점과 닿는지
                T
              2■
                B
                T
              1■
                B

            4. 두번째 사각형의 맨위 꼭지점이 두번째 사각형의 아래 꼭지점과 닿는지
                T
              1■
                B
                T
              2■
                B
            */
            if (leftx1 < rightx2 && rightx1 > leftx2 && topy1 > bottomy2 && bottomy1 < topy2)
            {
                Console.WriteLine("두 사각형이 겹칩니다.\n");
                Console.WriteLine("\n첫번째 사각형\n");
                Console.WriteLine("(" + leftx1 + "," + topy1 + ")" + "  (" + rightx1 + "," + topy1 + ")" + "\n");
                Console.WriteLine("(" + leftx1 + "," + bottomy1 + ")" + "  (" + rightx1 + "," + bottomy1 + ")" + "\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n두번째 사각형\n");
                Console.WriteLine("(" + leftx2 + "," + topy2 + ")" + "  (" + rightx2 + "," + topy2 + ")" + "\n");
                Console.WriteLine("(" + leftx2 + "," + bottomy2 + ")" + "  (" + rightx2 + "," + bottomy2 + ")" + "\n");
                    continue;
            }
            else
            {
                Console.WriteLine("두 사각형이 겹치지않습니다.\n");
                Console.WriteLine("\n첫번째 사각형\n");
                Console.WriteLine("(" + leftx1 + "," + topy1 + ")" + "  (" + rightx1 + "," + topy1 + ")" + "\n");
                Console.WriteLine("(" + leftx1 + "," + bottomy1 + ")" + "  (" + rightx1 + "," + bottomy1 + ")" + "\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n두번째 사각형\n");
                Console.WriteLine("(" + leftx2 + "," + topy2 + ")" + "  (" + rightx2 + "," + topy2 + ")" + "\n");
                Console.WriteLine("(" + leftx2 + "," + bottomy2 + ")" + "  (" + rightx2 + "," + bottomy2 + ")" + "\n");
                    continue;
                }
        }
    }
    }
}