//while문 - 간편하게 조건식만 있는 반복문이 필요할때

int sum = 0;
int n = 1;

while (n <= 1000)
{
    if (n % 2 == 0)
    {
        sum += n;
    }

    n ++;
}
Console.writeLine(sum); // 출력 결과 250500


//위의 코드를 for문을 사용해서 할때

int sum2 = 0;
for(int m = 1; m <= 1000; m ++)
{
    if (m % 2 == 0)
    {
        sum2 += m;
    }
}