/* №1 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void FillArr (int[] array)
{   int length = array.Length;
        for (int i=0; i<length; i++){
        array[i] = int.Parse(Console.ReadLine());}
} 
Console.WriteLine("Введите число элементов массива");
int len = int.Parse(Console.ReadLine());

int[] massiv = new int [len];
Console.WriteLine("Введите массив целых чисел");
FillArr(massiv);

int kol=0;
for (int j=0; j<massiv.Length; j++)
{   if (massiv[j]>0) 
    kol++;
}
Console.WriteLine();
Console.WriteLine(kol);
*/

/* №2 точка пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2

double x=0;
double y=0;

Console.WriteLine("Введите коэффициенты k1, b1, k2, b2 для двух прямых, заданным уравнением y=k*x+b");
double k1 = double.Parse(Console.ReadLine());
double b1 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());

if (k1==k2) Console.WriteLine("прямые не пересекаются");
else
{   x=(b2-b1)/(k1-k2);
    y=k1*x + b1;
    Console.WriteLine($"точка пересечения прямых ({x}; {y})");}
    */

Console.WriteLine("Введите действительное положительное число a и целое неотрицательное число n");
double a = double.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

double Power(double a, int n){
    if (n<0) {Console.WriteLine("ошибка");}
    if (n==0) return 1; else{
    while (n>0)
    {return a*Power(a, n-1);}}
    return 0;
}
Console.WriteLine(Power(a,n));


