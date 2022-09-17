// Очищается консоль
Console.Clear();
// Отступ рисовать
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");

int xa = 5, ya = 1,
    xb = 1, yb = 5,
    xc = 10, yc = 5;
int count = 0;
while (count < 10)
{
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
count += 1;
}