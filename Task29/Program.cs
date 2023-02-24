// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int[] GetBinaryArray(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}
int[] resultArray = GetBinaryArray(8);
double [] test = new double[10];
for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write(resultArray[i] + "\t");
}