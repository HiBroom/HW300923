// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Promt(string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int number = Convert.ToInt32(readInput);
    return number;
}

int SumNumbers(int numbers)
{
    int sum = 0;
    int devided = 0;
    while(numbers != 0)
    {
        devided = numbers % 10;
        sum = sum + devided;
        numbers = numbers / 10;
    }
    return sum;

}
int input = Promt("Input number: ");

Console.WriteLine($"Sum of numbers - > {SumNumbers(input)}");
