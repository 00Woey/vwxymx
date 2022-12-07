//continue 문
//break는 루프를 완전이 벗어나고 continue는 루프조건으로 넘어감

int sum = 0;
int n = 1;

while (n ++ <= 1000)
{
    if ((n % 2) != 0)
    {
        continue; // sum += n; 구문을 건너뛰고, while문의 조건식 평가로 실행을 옮긴다.
    }
    sum += n;
}