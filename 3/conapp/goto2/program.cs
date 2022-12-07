/*
bool exitLoop = false;

for (int x = 2; x < 10; x ++)
{
    for (int y =1; y < 10; y++)
    {
        Console.writeLine(x + " * " + y + " = " + (x * y));
        {
            exitLoop = x == 5 && y == 8;
            if (exitLoop == true)
            {
                break;
            }
        }

        if (exitLoop == true)
        {
            break;
        }
    }
}
*/
//위 코드를 goto활용
for (int x = 2; x < 10; x++)
{
    for (int y = 1; y < 10; y++)
    {
        Console.writeLine(x + " * " + y + " = " + (x * y));

        if (x == 5 && y == 0) goto LOOP_EXIT;
    }
}
LOOP_EXIT: ;