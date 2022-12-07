//실수형
float f = 5.2f; //4바이트 연산 값, 값 뒤에 f를 붙여줘야함
double d = 10.5; //8바이트 연산 값
decimal money = 200.099m; //16바이트 연산 값, 소수점 포함할경우 뒤에m을 붙여줘야함, 정밀도가 높음

Console.WriteLine(f); //5.2출력
Console.WriteLine(d); //10.5출력
Console.WriteLine(money); //200.099출력