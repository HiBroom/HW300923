// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] RandomArray(int length)
{
    int[] arr = new int[length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(1, 99);
    }
    return arr;
}
void PintArray(int[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        if(i == arr.Length - 1)
        {
            Console.Write($"{arr[i]}");
        }
        else
        {
            Console.Write($"{arr[i]},");
        } 
    }
}

int[] array = RandomArray(8);
PintArray(array);
Console.Write(" -> [");
PintArray(array);
Console.Write("]");
