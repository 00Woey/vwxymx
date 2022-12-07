//가변배열 - 배열의 배열

int [][] arr = new int[5][]; //2차원 가변 배열
arr[0] = new int[10];
arr[1] = new int [9];
arr[2] = new int[8];
arr[3] = new int [3];
arr[4] = new int[5];

/*
[0] ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
[1] ■ ■ ■ ■ ■ ■ ■ ■ ■ 
[2] ■ ■ ■ ■ ■ ■ ■ ■
[3] ■ ■ ■
[4] ■ ■ ■ ■ ■
*/
//필요한 만큼만 사용 가능해서 메모리 최적화


//일반 2차원 배열일 경우
// int [,] arr = new int[5, 10];

/*
[0] ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
[1] ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ 
[2] ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
[3] ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
[4] ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
*/