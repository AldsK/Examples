// Console.Write:() в одну строку
// Console.WriteLine:() В конце перейти на новую строку
// Console.ReadLine:() Считать строку от пользователя

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе числе: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int sum = numberOne + numberTwo;
Console.Write(sum);