// выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");
int number1=Convert.ToInt32(Console.ReadLine());
string number1Text = Convert.ToString(number1);
if (number1Text.Length > 2)
{
  Console.WriteLine("третья цифра : " + number1Text[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
} 