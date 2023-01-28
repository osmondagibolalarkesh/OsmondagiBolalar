////case 1- 
//Console.Write("Enter your week day"); int weekDay = int.Parse(Console.ReadLine());
//switch (weekDay)
//{
//	case 1:
//		Console.WriteLine("Dushanba");
//		break;
//    case 2:
//        Console.WriteLine("Seshanba");
//        break;
//    case 3:
//        Console.WriteLine("Chorshanba");
//        break;
//    case 4:
//        Console.WriteLine("Payshanba");
//        break;
//    case 5:
//        Console.WriteLine("Juma");
//        break;
//    case 6:
//        Console.WriteLine("Shanba");
//        break;
//    case 7:
//        Console.WriteLine("Yakshanba");
//        break;
//    default:
//        Console.WriteLine("\aThis is week day not found");
//        break;
//}
//case 3
//Console.Write("monthNumber = "); int monthNum = int.Parse(Console.ReadLine());
//switch (monthNum)
//{
//    case 12:
//    case 1:
//    case 2:
//        Console.WriteLine("Winter");
//        break;
//    case 3:
//    case 4:
//    case 5:
//        Console.WriteLine("Spring");
//        break;
//    case 6:
//    case 7:
//    case 8:
//        Console.WriteLine("Summer");
//        break;
//    case 9:
//    case 10:
//    case 11:
//        Console.WriteLine("Autumn");
//        break;
//    default: Console.WriteLine("\aMonth not found");
//        break;
//}
//case -4
//Console.Write("monthNumber = "); int monthNum = int.Parse(Console.ReadLine());
//int a = 0;
//switch (monthNum)
//{
//    case 1:
//    case 3:
//    case 5:
//    case 7:
//    case 8:
//    case 10:
//    case 12:
//        a = 31;
//        break;
//    case 4:
//    case 6:
//    case 9:
//    case 11:
//        a = 30; break;
//    case 2:
//        a = 28;
//        break;
//    default:  Console.WriteLine("bunday oy mavjud emas ");break;

//}
//if (monthNum < 12)
//{
//    Console.WriteLine($"{monthNum}- oy, {a} kundan iborat");
//}
//case- 6
//double kesmaUzunligi = double.Parse(Console.ReadLine());
//double tartibRaqami = double.Parse(Console.ReadLine());
//double a = 0;
//string temp;
//switch (tartibRaqami)
//{
//    case 1:
//        a = kesmaUzunligi / 10;
//        Console.WriteLine(kesmaUzunligi + " desimetr " + a + " metr");
//        break;
//    case 2:
//        a = kesmaUzunligi * 1000;
//        Console.WriteLine(kesmaUzunligi + " kilometr " + a + " metr");
//        break;
//    case 3:
//        a = kesmaUzunligi * 1;
//        Console.WriteLine(kesmaUzunligi + " metr " + a + " metr");
//        break;
//    case 4:
//        a = kesmaUzunligi / 1000;
//        Console.WriteLine(kesmaUzunligi + " millimetr " + a + " metr");
//        break;
//    case 5:
//        a = kesmaUzunligi / 100;
//        Console.WriteLine(kesmaUzunligi + " santimetr " + a + " metr");
//        break;
//    default:
//        Console.WriteLine("sjhdfjjuhgdfjgh");
//        break;
//}
//case- 8
Console.Write("kun = "); int day = int.Parse(Console.ReadLine());
Console.Write("oy = "); int month = int.Parse(Console.ReadLine());
switch (month)
{
    
        case 1:
            if (day <= 31)
            {
                Console.WriteLine(day + "- yanvar");
            }
            else
            {
                Console.WriteLine("\akunni tug'ri kiriting ");
            }
            break;
        case 3:
            if (day <= 31)
            {
                Console.WriteLine(day + "- mart");
            }
            else
            {
                Console.WriteLine("\akunni tug'ri kiriting ");
            }
            break;
        case 5:
            if (day <= 31)
            {
                Console.WriteLine(day + "- may");
            }
            else
            {
                Console.WriteLine("\akunni tug'ri kiriting ");
            }
            break;
        case 7:
            if (day <= 31)
            {
                Console.WriteLine(day + "- iyul");
            }
            else
            {
                Console.WriteLine("\akunni tug'ri kiriting ");
            }
            break;
        case 8:
            if (day <= 31)
            {
                Console.WriteLine(day + "- avgust");
            }
            else
            {
                Console.WriteLine("\akunni tug'ri kiriting ");
            }
            break;
        case 10:
            if (day <=31)
            {
                Console.WriteLine(day + "- oktyabr");
            }
            else
            {
                Console.WriteLine("\akunni tug'ri kiriting ");
            }
            break;
        case 12:
            if (day <= 31)
            {
                Console.WriteLine(day + "- dekabr");
            }
            else
            {
                Console.WriteLine("\akunni tug'ri kiriting ");
            }
            break;
        case 4:
            if (day < 30)
            {
                Console.WriteLine(day + "- aprel");
            }
            else
            {
                Console.WriteLine("\akunni tug'ri kiriting ");
            }
            break;
        case 6:
            if (day <= 30)
            {
                Console.WriteLine(day + "- iyun");
            }
            else
            {
                Console.WriteLine("\akunni tug'ri kiriting ");
            }
            break;
         case 9:
            if (day <= 30)
            {
                Console.WriteLine(day + "- sentabr");
            }
            else
            {
                Console.WriteLine("\akunni tug'ri kiriting ");
            }
            break;

        case 11:
            if (day <= 30)
            {
                Console.WriteLine(day + "- noyabr");
            }
            else
            {
                Console.WriteLine("\akunni tug'ri kiriting ");
            }
            break;
        case 2:
            if (day <= 28)
            {
                Console.WriteLine(day + "- fevral");
            }
            else
            {
                Console.WriteLine("\akunni tug'ri kiriting ");
            }
            break;
    default: Console.WriteLine("bunday oy mavjud emas");break;
}

