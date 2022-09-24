using static System.Console;

WriteLine("Введите день недели от 1 до 7:");
int d = Convert.ToInt32(ReadLine());
string Day ="Неправильно ввели день недели";

if(d==1) Day= "Понедельник";
if(d==2) Day= "Вторник";
if(d==3) Day= "Среда";
if(d==4) Day= "Четверг";
if(d==5) Day= "Пятница";
if(d==6) Day= "суббота";
if(d==7) Day= "Воскресенье";

if (d > 5)
{ 
    WriteLine("Выходной");

}
else
WriteLine(Day);