#region switch  2 - misol 
// int k = int.Parse(Console.ReadLine());
//switch (k)
//{
//case 1:
//       Console.WriteLine(" yomon o'quvchi");
//       break;
//   case 2:
//       Console.WriteLine(" qoniqarsiz o'quvchi");
//       break;
//   case 3:
//       Console.WriteLine(" qoniqarli o'quvchi"); 
//       break;
//   case 4:
//       Console.WriteLine(" yaxshi o'quvchi"); 
//       break;
//   case 5:
//       Console.WriteLine(" alo o'quvchi");
//       break;
//   default:
//   Console.WriteLine("Bugun ahvollar joyidami og'ayni???"); 
//   break;
//}
#endregion
#region switch 5 misol
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
switch (c)
{
	case 1:
		Console.WriteLine(a + b);
		break;
	case 2:
		Console.WriteLine(a - b);
		break;
	case 3:
		Console.WriteLine(a / b);
		break;
	case 4:
		Console.WriteLine(a * b);
		break;
	default:
		Console.WriteLine(" I don't now ");
		#endregion
}



