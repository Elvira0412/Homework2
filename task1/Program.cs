// Принимает на вход трехзначное число, и на выходе показывает втору. цифру этого числа
Console.WriteLine("Введите трехзначное число:");
int number1=Convert.ToInt32(Console.ReadLine());
int number2=number1/10;
int number3=number2%10;
Console.WriteLine(number3); 