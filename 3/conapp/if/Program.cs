//if문 (조건문)

int value = 5;
if (value <= 255)
{
    Console.WriteLine("byte 변환 가능");
}
else if (value <= 65535)
{
    Console.WriteLine("ushort 변환 가능");
}
else
{
    Console.WriteLine("int 타입");
}
//출력 byte 변환 가능
