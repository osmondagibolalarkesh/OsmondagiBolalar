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
//Console.Write("kun = "); int day = int.Parse(Console.ReadLine());
//Console.Write("oy = "); int month = int.Parse(Console.ReadLine());
//switch (month)
//{

//        case 1:
//            if (day <= 31)
//            {
//                Console.WriteLine(day + "- yanvar");
//            }
//            else
//            {
//                Console.WriteLine("\akunni tug'ri kiriting ");
//            }
//            break;
//        case 3:
//            if (day <= 31)
//            {
//                Console.WriteLine(day + "- mart");
//            }
//            else
//            {
//                Console.WriteLine("\akunni tug'ri kiriting ");
//            }
//            break;
//        case 5:
//            if (day <= 31)
//            {
//                Console.WriteLine(day + "- may");
//            }
//            else
//            {
//                Console.WriteLine("\akunni tug'ri kiriting ");
//            }
//            break;
//        case 7:
//            if (day <= 31)
//            {
//                Console.WriteLine(day + "- iyul");
//            }
//            else
//            {
//                Console.WriteLine("\akunni tug'ri kiriting ");
//            }
//            break;
//        case 8:
//            if (day <= 31)
//            {
//                Console.WriteLine(day + "- avgust");
//            }
//            else
//            {
//                Console.WriteLine("\akunni tug'ri kiriting ");
//            }
//            break;
//        case 10:
//            if (day <=31)
//            {
//                Console.WriteLine(day + "- oktyabr");
//            }
//            else
//            {
//                Console.WriteLine("\akunni tug'ri kiriting ");
//            }
//            break;
//        case 12:
//            if (day <= 31)
//            {
//                Console.WriteLine(day + "- dekabr");
//            }
//            else
//            {
//                Console.WriteLine("\akunni tug'ri kiriting ");
//            }
//            break;
//        case 4:
//            if (day < 30)
//            {
//                Console.WriteLine(day + "- aprel");
//            }
//            else
//            {
//                Console.WriteLine("\akunni tug'ri kiriting ");
//            }
//            break;
//        case 6:
//            if (day <= 30)
//            {
//                Console.WriteLine(day + "- iyun");
//            }
//            else
//            {
//                Console.WriteLine("\akunni tug'ri kiriting ");
//            }
//            break;
//         case 9:
//            if (day <= 30)
//            {
//                Console.WriteLine(day + "- sentabr");
//            }
//            else
//            {
//                Console.WriteLine("\akunni tug'ri kiriting ");
//            }
//            break;

//        case 11:
//            if (day <= 30)
//            {
//                Console.WriteLine(day + "- noyabr");
//            }
//            else
//            {
//                Console.WriteLine("\akunni tug'ri kiriting ");
//            }
//            break;
//        case 2:
//            if (day <= 28)
//            {
//                Console.WriteLine(day + "- fevral");
//            }
//            else
//            {
//                Console.WriteLine("\akunni tug'ri kiriting ");
//            }
//            break;
//    default: Console.WriteLine("bunday oy mavjud emas");break;
//}

//case-9
//Console.Write("day = "); int day = Convert.ToInt32(Console.ReadLine());
//Console.Write("month = "); int month = Convert.ToInt32(Console.ReadLine());
//day = day + 1;
//string nameOfMonth = string.Empty;
//switch (month)
//{
//	case 1:
//	case 3:
//	case 5:
//	case 7:
//	case 8:
//	case 10:
//		if (day > 31)
//		{
//			day = 1;
//			month++;
//		}
//		break;
//	case 12:
//		if (day > 31)
//		{
//			day = 1;
//			month = 1;

//		}
//		break;
//	case 4:
//	case 6:
//	case 9:
//	case 11:
//		if (day > 30)
//		{
//			day = 1;
//			month++;
//		}
//		break;
//	case 2:
//		if(day > 28)
//		{
//			day = 1;
//			month++;
//		}
//		break;
//	default:

//		break;
//}
//switch (month)
//{
//	case 1: nameOfMonth = "Yanvar"; break;
//	case 2: nameOfMonth = "Fevral"; break;
//	case 3: nameOfMonth = "Mart"; break;
//	case 4: nameOfMonth = "Aprel"; break;
//	case 5: nameOfMonth = "May"; break;
//	case 6: nameOfMonth = "Iyul"; break;
//	case 7: nameOfMonth = "Tyun"; break;
//	case 8: nameOfMonth = "Avgust"; break;
//	case 9: nameOfMonth = "Sentyabr"; break;
//	case 10: nameOfMonth = "Octyabr"; break;
//	case 11: nameOfMonth = "Noyabr"; break;
//	case 12: nameOfMonth = "Dekabr"; break;
//	default:
//		nameOfMonth = "Xato!";
//		break;
//}
//Console.WriteLine($"{day} {nameOfMonth} bo'ladi");

//case- 10
//Console.Write("Yo'nalishni kiriting = "); string robotYunalishi = Console.ReadLine();
//Console.Write("Komanda (0, 1, 2) = "); int robotKomanda = Convert.ToInt32(Console.ReadLine());
//string s1 = string.Empty, s2 = string.Empty;
//switch (robotYunalishi)
//{
//	case "s": s1 = "Shimol "; break;
//	case "j": s1 = "Janub "; break;
//	case "q": s1 = "Sharq "; break;
//	case "g": s1 = "G'arb "; break;
//	default:
//		s1= "Xato yunalish kiritdinggiz";
//		break;
//}
//switch (robotKomanda)
//{
//	case 0: s2 = "harakatni davom ettir "; break;
//	case 1: s2 = "chapga buril "; break;
//	case 2: s2 = "o'nga buril "; break;
//	default:
//		s2 = "xato yunalish kiritdingiz ";
//		break;
//}
//Console.WriteLine($"{s1} {s2}");
//16- case
//Random temp = new Random();
//Console.Write("Enter your age = "); int age = temp.Next(20, 69); Console.WriteLine(age);
//string birliklarXonasi, unliklarXonasi;
//int birlar_xonasi, unlar_xonasi;
//birlar_xonasi = age % 10;
//unlar_xonasi = age / 10;
//switch (birlar_xonasi)
//{
//    case 1:
//        birliklarXonasi = "bir"; break;
//    case 2:
//        birliklarXonasi = "ikki"; break;
//    case 3:
//        birliklarXonasi = "uch"; break;
//    case 4:
//        birliklarXonasi = "to'rt"; break;
//    case 5:
//        birliklarXonasi = "besh"; break;
//    case 6:
//        birliklarXonasi = "olti"; break;
//    case 7:
//        birliklarXonasi = "yetti"; break;
//    case 8:
//        birliklarXonasi = "sakkiz"; break;
//    case 9:
//        birliklarXonasi = "to'qqiz"; break;
//    default: birliklarXonasi = string.Empty; break;
//}
//switch (unlar_xonasi)
//{
//    case 2:
//        unliklarXonasi = "yigrma "; break;
//    case 3:
//        unliklarXonasi = "o'ttiz "; break;
//    case 4:
//        unliklarXonasi = "qirq "; break;
//    case 5:
//        unliklarXonasi = "ellik "; break;
//    case 6:
//        unliklarXonasi = "oltmish "; break;

//    default: unliklarXonasi = string.Empty; break;
//}
//Console.WriteLine($"{unliklarXonasi} {birliklarXonasi}");
//double R1 = 0, a = 0, R2 = 0, S = 0;
//Console.Write("komanda= "); double komanda = double.Parse(Console.ReadLine());
//Console.Write("qiymat= "); double qiymat = double.Parse(Console.ReadLine());
//switch (komanda)
//{
//    case 1:
//        a = qiymat;
//        R1 = a * (1 / Math.Sqrt( 2));
//        R2 = 2 * (a * (1 / Math.Sqrt( 2)));
//        S = Math.Pow(a, 2) * (Math.Sqrt(3) / Math.Sqrt( 4));

//        break;
//    case 2:
//        R1 = qiymat;
//        a = R1 / Math.Sqrt( 2);
//        R2 = 2 * R1;
//        S = 2 * Math.Pow(R1, 2) * (Math.Sqrt(3) / Math.Sqrt(4));
//        break;
//    case 3:
//        R2 = qiymat;
//        a = R2 / (2 * (Math.Sqrt(2)));
//        R1 = R2 / 2;
//        S = Math.Pow(R2, 2) * (Math.Sqrt(3) / Math.Sqrt(4));
//        break;
//    case 4:
//        S = qiymat;
//        a = 2 * Math.Sqrt(S / (Math.Sqrt(3)));
//        R1 = 2 * Math.Sqrt(S / (Math.Sqrt(3))) * 1 / Math.Sqrt(2);
//        R2 = 4 * Math.Sqrt(S / (Math.Sqrt(3))) * 1 / Math.Sqrt( 2);
//        break;
//    default:
//        Console.WriteLine("Xatoooooooooooooo");
//        break;
//}
//Console.WriteLine($"Tomoni= {a} \nIchki Radius= {R1} \nTashqi Radius= {R2} \nYuzasi= {S} ");
//Console.WriteLine("=======================================================");

//Case15 - misol
//int N, M;
//Console.Write("Karta qiymatini kiriteng 6 dan 14 gacha ");
//N = int.Parse(Console.ReadLine());
//Console.Write("Karta turuni kiriteng ");
//M = int.Parse(Console.ReadLine());
//string qiymat, tur;
//switch(M)
//{
//    case 1:
//        tur = "G'ishit "; break;
//    case 2:
//        tur = "Olma "; break;
//    case 3:
//        tur = "Chillik "; break;
//    case 4:
//        tur = "Qarg'a "; break;
//    default: tur = string.Empty; break;
//}
//switch (N)
//{
//    case 6:
//        qiymat = "olti "; break;
//    case 7:
//        qiymat = "yetti "; break;
//    case 8:
//        qiymat = "sakkiz "; break;
//    case 9:
//        qiymat = "tuqqiz "; break;
//    case 10:
//        qiymat = "o'n "; break;
//    case 11:
//        qiymat = "Valet "; break;
//    case 12:
//        qiymat = "Dama "; break;
//    case 13:
//        qiymat = "Qirol "; break;
//    case 14:
//        qiymat = "Tuz "; break;
//    default:
//        qiymat= string.Empty; break;
//}
//Console.WriteLine(qiymat + tur);
// case-19
//Console.Write("Enter your year = "); int year = Convert.ToInt32(Console.ReadLine());
//string name = string.Empty, animalName = string.Empty;
//int colour = (year - 1984) % 5;
//int animal = (year - 1984) % 12;
//switch (colour)
//{
//	case 0:
//		name = "yashil"; break;
//	case 1:
//		name = "qizil"; break;
//	case 2:
//		name = "sariq"; break;
//	case 3:
//		name = "oq"; break;
//	case 4:
//		name = "qora"; break;

//	default:
//		name = "Eror !";
//		break;
//}
//switch (animal)
//{
//	case 0:animalName = "sichqon"; break;
//	case 1:animalName = "sigir"; break;
//	case 2:animalName = "yulbars"; break;
//	case 3:animalName = "quyon"; break;
//	case 4:animalName = "ajdar"; break;
//	case 5:animalName = "ilon"; break;
//	case 6:animalName = "ot"; break;
//	case 7:animalName = "quy"; break;
//	case 8:animalName = "maymun"; break;
//	case 9:animalName = "tovuq"; break;
//	case 10:animalName = "it"; break;
//	case 11:animalName = "tung'iz"; break;
//	default:
//		animalName = "Eror!";
//		break;
//}
//Console.WriteLine($"{name} {animalName} yil");
// case -20
//Console.Write("enter your day = "); int day = Convert.ToInt32(Console.ReadLine());
//Console.Write("enter your month = "); int month = Convert.ToInt32(Console.ReadLine());
//switch (month)
//{
//	case 1:
//		if (day >= 20 && day <= 31)
//		{
//			Console.WriteLine("Qovg'a");
//		}
//		else if (day >= 1 && day <= 19)
//		{
//            Console.WriteLine("Echki");
//        }
//		else {
//			Console.WriteLine("kunni xato kiritdingiz ");
//			}
//		break;
//	case 2:
//        if (day >= 1 && day <= 18)
//        {
//            Console.WriteLine("Qovg'a");
//        }
//        else if (day >= 19 && day <= 28)
//        {
//            Console.WriteLine("Baliq");
//        }
//        else
//        {
//            Console.WriteLine("kunni xato kiritdingiz ");
//        }
//        break;
//    case 3:
//        if (day >= 1 && day <= 20)
//        {
//            Console.WriteLine("Baliq");
//        }
//        else if (day >= 21 && day <= 31)
//        {
//            Console.WriteLine("Qo'y");
//        }
//        else
//        {
//            Console.WriteLine("kunni xato kiritdingiz ");
//        }
//        break;
//    case 4:
//        if (day >= 1 && day <= 19)
//        {
//            Console.WriteLine("Qoy");
//        }
//        else if (day >= 20 && day <= 30)
//        {
//            Console.WriteLine("Buzoq");
//        }
//        else
//        {
//            Console.WriteLine("kunni xato kiritdingiz ");
//        }
//        break;
//    case 5:
//        if (day >= 1 && day <= 20)
//        {
//            Console.WriteLine("Buzoq");
//        }
//        else if (day >= 21 && day <= 30)
//        {
//            Console.WriteLine("Egzaklar");
//        }
//        else
//        {
//            Console.WriteLine("kunni xato kiritdingiz ");
//        }
//        break;
//    case 6:
//        if (day >= 1 && day <= 21)
//        {
//            Console.WriteLine("Egzaklar");
//        }
//        else if (day >= 22 && day <= 31)
//        {
//            Console.WriteLine("Qisqichbaqa");
//        }
//        else
//        {
//            Console.WriteLine("kunni xato kiritdingiz ");
//        }
//        break;
//    case 7:
//        if (day >= 1 && day <= 22)
//        {
//            Console.WriteLine("Qisqichbaqa");
//        }
//        else if (day >= 23 && day <= 30)
//        {
//            Console.WriteLine("Arslon");
//        }
//        else
//        {
//            Console.WriteLine("kunni xato kiritdingiz ");
//        }
//        break;
//    case 8:
//        if (day >= 1 && day <= 22)
//        {
//            Console.WriteLine("Arslon");
//        }
//        else if (day >= 23 && day <= 31)
//        {
//            Console.WriteLine("Parizod");
//        }
//        else
//        {
//            Console.WriteLine("kunni xato kiritdingiz ");
//        }
//        break;
//    case 9:
//        if (day >= 1 && day <= 22)
//        {
//            Console.WriteLine("Parizod");
//        }
//        else if (day >= 23 && day <= 30)
//        {
//            Console.WriteLine("Tarozi");
//        }
//        else
//        {
//            Console.WriteLine("kunni xato kiritdingiz ");
//        }
//        break;
//    case 10:
//        if (day >= 1 && day <= 22)
//        {
//            Console.WriteLine("Tarozi");
//        }
//        else if (day >= 23 && day <= 31)
//        {
//            Console.WriteLine("Chayon");
//        }
//        else
//        {
//            Console.WriteLine("kunni xato kiritdingiz ");
//        }
//        break;
//    case 11:
//        if (day >= 1 && day <= 22)
//        {
//            Console.WriteLine("Chayon");
//        }
//       else if (day >= 23 && day <= 30)
//        {
//            Console.WriteLine("O'qotar");
//        }
//        else
//        {
//            Console.WriteLine("kunni xato kiritdingiz ");
//        }
//        break;
//    case 12:
//        if (day >= 1 && day <= 21)
//        {
//            Console.WriteLine("O'qotar");
//        }
//        else if (day >= 22 && day <= 31)
//        {
//            Console.WriteLine("Echki");
//        }
//        else
//        {
//            Console.WriteLine("kunni xato kiritdingiz ");
//        }
//        break;
//    default:
//        Console.WriteLine("oyni xato kiritdingiz!");
//		break;
//}

//for (int i = 0; i <= 10; i++)
//{
//	if (i % 2 == 1)
//	{
//		Console.WriteLine(i);
//	}
//    // multple code
//}
//for (ifoda 1; ifoda 2; ifoda 3)
//{
//    // tana qismidagi cod
//}
// 1 qqadam i = 1; shart i <= 10; i ming usishi i++
// output : 1
// i = 2
// 2 -qadam i = 2; shart i <= 10; i ning usishi i++
// output : 2
// i = 3
// 3 -qadam i = 3; shart i <= 10; i ning usishi i++
// output : 3
// i = 4
// 4 -qadam i = 4; shart i <= 10; i ning usishi i++
// output : 4
// i = 5
// 5 -qadam i = 5; shart i <= 10; i ning usishi i++
// output : 5
// i = 6
// 7 -qadam i = 6; shart i <= 10; i ning usishi i++
// output : 6
// i = 7
//.....
//i = 9
// 10 -qadam i = 9; shart i <= 10; i ning usishi i++
// output : 9
// i = 10
// output : 10