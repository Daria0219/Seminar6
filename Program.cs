// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

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
