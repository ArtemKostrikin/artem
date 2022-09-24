using static System.Console;
Clear();

Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(ReadLine()!);

int a0 = number%10;
int a2 = number/100;
int a1 = number/10;

int result = a1;

WriteLine(result);
