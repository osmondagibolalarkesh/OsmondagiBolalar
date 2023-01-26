//case 1- 
Console.Write("Enter your week day"); int weekDay = int.Parse(Console.ReadLine());
switch (weekDay)
{
	case 1:
		Console.WriteLine("Dushanba");
		break;
    case 2:
        Console.WriteLine("Seshanba");
        break;
    case 3:
        Console.WriteLine("Chorshanba");
        break;
    case 4:
        Console.WriteLine("Payshanba");
        break;
    case 5:
        Console.WriteLine("Juma");
        break;
    case 6:
        Console.WriteLine("Shanba");
        break;
    case 7:
        Console.WriteLine("Yakshanba");
        break;
    default:
        Console.WriteLine("\aThis is week day not found");
        break;
}
