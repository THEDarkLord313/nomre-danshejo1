
Console.WriteLine("please enter score");
int x;
x = 0;
x = Convert.ToInt32(Console.ReadLine());

switch (x)
{
    case <= 20 and >= 17:

        Console.WriteLine(" your score is A");
        break;
    case < 17 and >= 15:
        Console.WriteLine(" your score is B");
        break;
        case <15 and >= 10:
        Console.WriteLine("your score is C");
        break;
    case < 10 and <= 0:
        Console.WriteLine("your score is F");
        break ;
        default: 
        Console.WriteLine("please enter a number between 0 and 20");
        break;
}