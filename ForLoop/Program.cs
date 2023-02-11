
//int N, Sum = 0;
//Console.Write("N = "); N = int.Parse(Console.ReadLine());
//for (int i = 0; i <= N; i++)
//{
//    //Sum += i;
//    if (i % 2 == 0)
//    {
//        Sum = Sum + i;//Sum = 2
//    }


//}
//Console.WriteLine(" Sum = " + Sum);

//double  N, Sum = 0;
//Console.Write("N = "); N = double.Parse(Console.ReadLine());
//for (double i = 1; i <= N; i++)
//{
//    Console.WriteLine(i + " sonning kvadtrati = " + Math.Pow(i, 2));
//}

//int N, Sum = 0;
//Console.Write("N = "); N = int.Parse(Console.ReadLine());

//for (int i = 1; i <= N; i++)
//{
//    if ((i > 0 && i <= 10) && i % 2 == 1)
//    {
//        Console.WriteLine(i);
//    }
//    else if ((i > 10 && i <= N) && i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }


//}
//int Sum = 0;
//Console.Write("N = ");int  N = int.Parse(Console.ReadLine());
//for (int i = 1;i <= N; i++)
//{
//    if (N / 2 > i) continue;
//	{
//        Sum += i;
//    }

//}
//Console.WriteLine("Sum= " + Sum);
//for -1
//Console.Write("k = "); int k = Convert.ToInt32(Console.ReadLine()); 
//Console.Write("n = "); int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine(k);
//}
//for- 4
//int count = 0;
// for - 7
// for - 10
//float S = 0;
//Console.Write("n (n > 0) = "); float n = Convert.ToInt32(Console.ReadLine());
////Console.Write("b = "); int b = Convert.ToInt32(Console.ReadLine());
//for (float i = 1; i <= n; i++)
//{
//    S += 1 / i;
//    //Console.WriteLine(i);
//}
//Console.WriteLine(S);
//Console.WriteLine(count);
//double k = 0;
//Console.Write("N = "); double n = double.Parse(Console.ReadLine());
//Console.Write("a = "); double a = double.Parse(Console.ReadLine());
////Console.Write("a = "); int a = int.Parse(Console.ReadLine());
//for (double i = n; i <= 2 * n ; i++)
//{
//    k += Math.Pow(i , 2);   
//}
//Console.WriteLine("S = " + k);
//for- 9
//double s = 0;
//Console.Write("a = "); double a = double.Parse(Console.ReadLine());
//Console.Write("b = "); double b = double.Parse(Console.ReadLine());
//for (double i = a; i <= b; i++)
//{
//    s += Math.Pow(i, 2);
//}
//Console.WriteLine("S = " + s);
//fot- 14
//double yigindi = 0, s = 1.1, ishora = 1;
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//for (int i = 1; i <= (2 * n - 1); i += 2)
//{
//    yigindi += i;
//    Console.WriteLine(ishora+ " soni kvadrati " + yigindi);
//    ishora += 1;
//}
//int i = 1;
//for (;;)
//{
//    Console.Write(i + " ");
//    i++;
//}
//int a = 0;
//for (int i = 1; i <= 100; i++)
//{
//    a++;
//    if ((1 <= a) && (a <= 33))
//    {
//        Console.BackgroundColor = ConsoleColor.Green;
//        Console.WriteLine("Subxonolloh = " + a);
//    }

//    else if ((34 <= a) && (a <= 66))
//    {
//        Console.BackgroundColor = ConsoleColor.Blue;
//        Console.WriteLine("Alhamdullilah = " + a);
//    }

//    else if ((67 <= a) && (a <= 99))
//    {
//        Console.BackgroundColor = ConsoleColor.Red;
//        Console.WriteLine("Alloh Akbar = " + a);
//    }
//    else if (a == 100)
//    {
//        Console.BackgroundColor = ConsoleColor.White;
//        Console.WriteLine("Laa ilaaha illoh Muhammadu  Rasulloh = " + a);
//    }
//}
//for 18
//double n, kupaytma = 1, a, ishora = -1, Sum = 0;
//Console.Write("n = "); n = int.Parse(Console.ReadLine());
//Console.Write("a = "); a = double.Parse(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    kupaytma = kupaytma * a;
//    Sum += ishora * kupaytma;
//    ishora *= -1;
//    Console.WriteLine("daraja " + kupaytma);
//}
//Console.WriteLine("======================");
//Console.WriteLine("Sum = " + (Sum + 1));

//Console.WriteLine("_______________________________________________________________________");
//for 23
//salom:
//Console.Write("n = "); double n = double.Parse(Console.ReadLine());
//Console.Write("x = "); double x = double.Parse(Console.ReadLine());
//double K = 1, S = 0, k1 = 1, ishora = -1;
//for (int i = 1; i <= (2 * n + 1); i+=2)
//{
//    K = 1;
//    for (int j = 1; j <= i; j++)
//    {
//        K = K * j;
//    }
    
//    k1 *= x;
//    S += (ishora * k1) / K;
//    ishora *= -1;
    

//}
//Console.WriteLine("Sum = " + S);

//Console.WriteLine("===============================");
//goto salom;