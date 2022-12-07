//for문 앞에서 미리 초기화하면 생략가능

int n = 1;

for(; n <= 9; n++) //n = 1 이 생략됨
{
    Console.writeLine(n);
}

//조건식도 if문등으로 생략가능

int m = 1;

for (; ; m++) //m = 1, m <= 9가 생략됨
{
    if (m>9) break;
    Console.writeLine(m);
}

//전부생략

int i = 1;

for (;;)
{
    if (i>9) break;
    Console.writeLine(i);
    i++
}