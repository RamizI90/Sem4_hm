// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// "Напишите ЦИКЛ" значит возводить в степень нужно циклом, 
// а не методом Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



Console.WriteLine("Введите число A: ");
string? numberstringA = Console.ReadLine();
int numberA = int.Parse(numberstringA!);

Console.WriteLine("Введите число B: ");
string? numberstringB = Console.ReadLine();
int numberB = int.Parse(numberstringB!);

int Method(int number, int degree)
{
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result = result * number;
        //Console.WriteLine(result);
    }
    return result;
}
int x = Method(numberA,numberB);
Console.WriteLine(x);
//