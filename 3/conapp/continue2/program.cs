
/*
int sum = 0;
int n = 1;
while(n ++ <= 1000)
{
    if((n % 2) == 0)
    {
        if ((n % 3) == 0)
        {
            if ((n % 5) == 0)
            {
                sum += n;
            }
        }
    }
}
위의 코드를 continue 활용
*/

int sum = 0;
int n = 1;
while(n ++ <= 1000)
{
    if ((n % 2) != 0) continue;
    if ((n % 3) != 0) continue;
    if ((n % 5) != 0) continue;

    sum += n;
}