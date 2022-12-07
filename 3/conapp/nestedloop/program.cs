//중첩루프 ( 제어문 안에 제어문 )

for (int x = 2; x < 10; x ++)
    for (int y = 1; y < 10; y++)
        Console.writeLine(x + " * " + y + " = " + (x * y));

//또는 실행할 구분이 하나인 경우에도 다음과 같이 가독성을 높이기 위해 일부러 블록을 사용하기도한다.
/*
for (int x = 2; x < 10; x ++)
{
    for (int y = 1; y < 10; y ++)
    {
        Console.writeLine(x + " * " + y + " = " + (x * y));
    }
}
*/

/*
결과
2 * 1 = 2 
~(생략)
9 * 9 = 81
*/