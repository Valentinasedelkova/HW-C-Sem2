
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите цифру от 1 до 7: ");
        int number = int.Parse(Console.ReadLine());
        if (number <= 5)
        {
            Console.WriteLine("Нет");
        }
        else
        {
            Console.WriteLine("да");
        }
    }
}
