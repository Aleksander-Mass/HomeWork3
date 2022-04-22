/*
Задача 19 (1) Семинар Урок 3. Массивы и функции в программировании
Палиндром-число или текст, который читается одинаково как слева так и справа:939; 49094; 11311.
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да


Console.WriteLine("Введите пятизначное целое положительное число число");
int num = Convert.ToInt32(Console.ReadLine());
string n = num.ToString();

    if(n[0] == n[4] && n[1] == n[3])
    {
		Console.WriteLine(n + " -> да");
    }
    else
    {
		Console.WriteLine(n + "-> нет");
    }
    */


/*
Задача 21(2) Семинар Урок 3. Массивы и функции в программировании
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координату х первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату х второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance(int x1, int y1, int z1, int x2, int y2, int z2)

{
    return Math.Sqrt((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1) + (z2-z1) * (z2-z1));
}

Console.WriteLine("A ("+x1+","+y1+","+z1+"); B ("+x2+","+y2+","+z2+") -> " + Math.Round(distance(x1,y1,z1,x2,y2,z2),2));

*/

/*
Задача 23(3) Семинар Урок 3. Массивы и функции в программировании
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите целое положительное число число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
   Sqrt1(num);
else
  Console.WriteLine("Введите целое положительное число число: ");
void Sqrt1(int N)
{
    int count = 1;
    Console.Write(N + " -> ");
    while(count <= N)
    {
        Console.Write(count*count*count + ", ");
        count++;
    }
}
*/
