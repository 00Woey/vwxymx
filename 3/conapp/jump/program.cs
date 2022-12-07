//점프문
//break - switch, for, foreach, while, do 반복문 내에서만 사용가능
//구구단
int i = 2;
while(true)
{
    int j = 1;
    while (true){
        Console.writeLine(i + " * " + j + " = " + (i + j));

        if (++k >9){
            break;
        }
    }
    if (++i >9){
        break;
    }
}