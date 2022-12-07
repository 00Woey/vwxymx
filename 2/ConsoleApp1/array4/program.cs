//한번 정해진 배열의 크기는 변하지않는다

int [] txt = new int[60];
txt[0] = 50;
Console.writeLine(txt[0]); // 출력: 50

txt = new int[120]; //크기 변화 X, 단 마지막으로 배열을 선언한경우 초기화값을 가지게됨
Console.writeLine(txt[0]); // 출력: 0