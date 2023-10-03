//  Напишите цикл, который принимает на вход два числа (A и B) 
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Promt(string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int numbers = Convert.ToInt32(readInput);
    return numbers; 
}
int Exponent(int numberA, int numberB)
{
    int result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result *= numberA;
        
    }
    return result;
}
bool TrueOrFalsExponent(int numberB)
{
    if(numberB < 0) return false;
    else return true;
}

int a = Promt("Input number A: ");
int b = Promt("Input number B: ");
if (TrueOrFalsExponent(b))
{
    Console.WriteLine($"{a}, {b} - > {Exponent(a, b)}");
}

