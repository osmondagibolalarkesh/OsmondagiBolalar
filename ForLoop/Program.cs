
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
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//Console.Write("a = "); int a = int.Parse(Console.ReadLine());
//Console.Write("b = "); int b = int.Parse(Console.ReadLine());
//int result = a;
//int marta = Math.Abs(a - b)/ n;
//for (int i = a;i <= b; i += marta)
//{
//    Console.WriteLine(result);
//    result += marta;
//}
//Fibonachi
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//int F1 = 1, F2 = 1, Fibonachi;
//for (int i = 1;i <= n; i++)
//{
//	if ((i == 1) || (i == 2))
//	{
//		Fibonachi = 1;
//	}
//	else
//	{
//		Fibonachi = F1 + F2;

//	}
//	Console.WriteLine(Fibonachi);
//	F1 = F2;
//	F2 = Fibonachi; 
//}
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//int sum = 0, k, daraja;
//for (int i = 1; i <= n; i++)
//{
//	k = n - i + 1;
//	daraja = 1;
//	for (int j = 1; j <= k; j++)
//	{
//		daraja *= i;
//	}
//	Console.WriteLine($"{i}\t {daraja}");
//	sum += daraja;
//}
////Console.WriteLine("Sum = " + sum);
//Console.Write("a = "); int a = int.Parse(Console.ReadLine());
//Console.Write("b = "); int b = int.Parse(Console.ReadLine());
//for (int i = a; i <= b; i++)
//{
//	Console.WriteLine(i);
//	for (int j = 1; j <= i; j++)
//	{
//		Console.WriteLine("\t" + i);
//	}
//}
//38-for
//Console.Write("N = "); int N = int.Parse(Console.ReadLine());
////Console.Write("K = "); int K = int.Parse(Console.ReadLine());
//int sum = 0, daraja, k;
//for (int i = 1; i <=N; i++)
//{
//	daraja = 1;
//	k = N - i + 1;
//	for (int j = 1; j <= k; j++)//Darajani hisoblash uchun kk buladigan tsikl
//	{
//		daraja =daraja * i;
//	}
//	Console.WriteLine(i + "\t" + daraja);
//	sum =sum +  daraja;
//}
//Console.WriteLine("Sum " + sum);
//for40 - misol
//int A, B, k = 1;
//Console.Write("A = "); A = int.Parse(Console.ReadLine());
//Console.Write("B = "); B = int.Parse(Console.ReadLine());
//for (int i = A; i < B; i++)
//{
//    Console.WriteLine(i);
//    for (int j = 1; j <= k; j++)
//    {
//        Console.WriteLine("         " + i);
//    }
//    k++;
//}
//Console.WriteLine("For bilan");
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
////}
//Console.WriteLine("====================");
//Console.WriteLine("While bilan");
//int j = 1;
//while (j <= 10)
//{
//    Console.WriteLine(j);
//}
//Console.WriteLine("==================");
//Console.WriteLine("Do While bilan ");
//int l = 1;
//do
//{
//    Console.WriteLine(l);
//    l++;
//}
//while (l <= 10);

//for (int i = 1; i <= 100; i+=2)
//{
//    Console.Write(i + " ");
//}
//1 - qadam
//dastlabki qiymat  i = 1
//shart 1 <= 10
//body console 1
//i++
//2 - qadam
//dastlabki qiymat  i = 2
//shart 2 <= 10
//body console 2
//i++
//...
//10 -qadam 
//dastlabki qiymat  i = 10
//shart 10 <= 10
//body console 10
//i++
//1- misol
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//int i = 1, daraja = 1,yigindi = 0;
//while (i <= n)
//{
//    daraja *= i * i;
//    Console.WriteLine(i + " kvadrati " + daraja);
//    yigindi += daraja;
//    i++;
//    daraja = 1;
//}
//Console.WriteLine("Sum = " + yigindi);
//misol-2
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//int i = 1, kupaytma = 1, yigindi = 0;
//double k, d;
//while (i <= n)
//{
//    yigindi += i;
//    kupaytma*= i;
//    i++;
//}
//d = Math.Sqrt(kupaytma);
//k = yigindi / n;
//Console.WriteLine("Urta arifmetik = " + k + "\n" + "urta geometrik = " + d);
// misol -3
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//double i = 1, kupaytma = 1, yigindi = 0;
//while (i <= n)
//{
//	if (i % 2 == 0)
//	{
//		yigindi += i;
//	}
//	else
//	{
//		kupaytma *= i;
//	}
//	i++;
//}
//misol -4
//int i = 10;
//while (i > 9 && i < 100)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }

//    i++;
//}

// while 1
//Console.Write("A = "); int A = int.Parse(Console.ReadLine());
//Console.Write("B = "); int B = int.Parse(Console.ReadLine());
//while (B < A)
//{
//    A = A - B;

//}
//if (A == B)
//{
//    Console.WriteLine("qoldiq qismi " + 0);
//}
//else
//{
//    Console.WriteLine("qoldiq qismi " + A);
//}
////3- misol 
//for (int i = 1; i <= 100; i++)
//{
//    if (i % 2 == 0 && i % 3 == 0) 
//        Console.Write(i + " ");

//}
//Console.WriteLine();
//Console.WriteLine("========================");
//for (int i = 1; i <= 100; i++)
//{
//    if (i % 6 == 0)
//        Console.Write(i + " ");

//}
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler


//Console.Write("N = "); int n = int.Parse(Console.ReadLine());
//// Oldin n ni 2 (tub son)ga bo'lib chiqamiz.Bu hol n soni 2 ga bo'linmay qolguncha davom etadi 
//while (n % 2 == 0)
//{
//    Console.Write(2 + " ");
//    n = n / 2;
//}
//// bundan keyingi bo'luvchilar albatta toq sonlar bo'ladi 
//// i lar toq son bo'lgani uchun uni i=i+2 qilshimiz mumkin 
//int i = 3;
//while (i <= Math.Sqrt(n))
//{
//    // i soni n ga bo'lingan paytda , i ni chop qilsin va n ni i ga bo'lsin.Bu amallar ham i soni n ga bo'linmay qolguncha davom etadi
//    while (n % i == 0)
//    {
//        Console.Write(i + " ");
//        n = n / i;
//    }
//    i = i + 2;
//}
////bu tepadagi algoritmdagi 4-qismdir
//// ya'ni n>2 bo'lsa n tub son bo'ladi. Shuni uchun uni o'zini chop qilamiz
//if (n > 2)
//    Console.Write(n + " ");

//Console.Write("a = "); int a = int.Parse(Console.ReadLine());
//Console.Write("b = "); int b = int.Parse(Console.ReadLine());
//int i = a;
//while (i <= b)
//{
//	int j = 2, k = 0;
//	while (i > j)
//	{
//		if (i % j == 0)
//		{
//			k++;
//		}
//		j++;
//	}
//	if (k == 0)
//	{
//		Console.Write(i + " ");
//	}
//	i++;
//}
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//int s = 1, k = 0;
//while(n > 0)
//{
//    n = n / 10;
//    k++;
//}
//Console.WriteLine(k + " xonali son");
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//int s = 0, k = 1, f = 1;
//while (n > 0)
//{
//    k = n % 10;
//    s += k;
//    f *= k;
//    n = n / 10;
//}
//Console.WriteLine(s + " " + f);
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//int i = 1;
//while(i < n)
//{
//    i *= 3;
//}
//if (i == n)
//{
//    Console.WriteLine(n + " soni 3 ning darajasi");
//}
//else
//{
//    Console.WriteLine(n + " soni 3 ning darajasi emas");
//}
//double y = 0, x = -5;
//while ( x <= 5)
//{
//    y = 5 * Math.Pow(x, 2) - 2 * x + 1;
//    Console.WriteLine(x + " da y = " + y);
//    x += 2;
//}
//Console.Write("N = "); int n = int.Parse(Console.ReadLine());
//while (n % 2 == 0)
//{
//    Console.WriteLine(2);
//    n = n / 2;
//}
//int i = 3;
//while (i <= Math.Sqrt(n))
//{
//    if (n % i == 0)
//    {
//        Console.WriteLine(i);
//        n = n / i;
//    }
//    i = i + 2;
//}
//if (n > 2)
//{
//    Console.WriteLine(n);
//}
//Console.Write("a = "); int a = int.Parse(Console.ReadLine());
//Console.Write("b = "); int b = int.Parse(Console.ReadLine());
//int i = a;
//while (i <= b)
//{
//    int j = 2, k = 0;
//    while (i > j)
//    {
//        if (i % j == 0)
//        {
//            k++;
//        }
//        j++;
//    }
//    if (k == 0)
//    {
//        Console.Write(i + " ");
//    }
//    i++;
//}
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//int i = 0;
//while(n > 0)
//{
//    n = n / 10;
//    i++;
//}
//Console.WriteLine(i + " xonli son");

//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//int i = 0, Sum = 0, Kupaytma = 1, l = 1;
//while (n > 0)
//{
//    l = n % 10;
//    Sum+= l;
//    Kupaytma*= l;
//    n = n / 10;
//    i++;
//}
//Console.WriteLine("Sum " + Sum + "\nKupaytmasi " + Kupaytma);
//Console.Write("a = "); int a = int.Parse(Console.ReadLine());
//Console.Write("b = "); int b = int.Parse(Console.ReadLine());
//int yigindi = 0;
//for(int i = a; i <= b; i++)
//{
//    yigindi = yigindi + i;
//    //1 - qadamda yigindi = 0 i = a
//    // yigindi = 0 + a
//    //yigindi = a
//    //i++
//    //2 - qadam yigingi = a i = a + 2 
//    //yigindi = a + a + 1= 2a + 1
//    //.....
//    //oxringi qadam yigimdi = (b - a - 1)* a + 1 i =  a + (b - a - 1)
//}
//Console.WriteLine(yigindi);
//4 - misol 
//Console.Write("N = ");int N = int.Parse(Console.ReadLine());
////Console.Write("K = ");int K = int.Parse(Console.ReadLine());
//int s = 1;
//while(N > s)
//{
//    s *= 3;
//}
//if(N == s)
//{
//    Console.WriteLine(N + " soni 3 ning darajasi ");
//}
//else 
//{
//    Console.WriteLine(N + " soni 3 ning darajasi emas");
//}
// 5 - misol 
//Console.Write("n =  "); double n = double.Parse(Console.ReadLine());
//Console.Write("k = "); double k = double.Parse(Console.ReadLine());
//for(int i = 1;i <= n; i++)
//{
//    Console.WriteLine(k);
//}
//while 6
//salom:
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//int kupaytma = 1;
//while(n >= 2)
//{
//    kupaytma *= n;
//    n -= 2;
//}
//Console.WriteLine("n!! = " + kupaytma);
//goto salom;
//while 8
//salom:
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//int k = n;
//while (!(k * k <= n))
//{
//    k--;
//}
//Console.WriteLine("k = " + k);
//Console.WriteLine("=====================");
//goto salom;
//while 10
//salom:
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//double k = n;
//while (Math.Pow(3, k) <= n == false )
//{
//    k--;
//}
//Console.WriteLine("k = " + k);
//Console.WriteLine("=====================");
//goto salom;
//while 15
//salom:
//Console.Write("S = "); double S = double.Parse(Console.ReadLine());
//Console.Write("p = "); double p = double.Parse(Console.ReadLine());
//double oy = 0, l = 2 * S;
//p = p / 100;
//while (l < S )
//{
//    S *= p;
//    oy++;
   
//    Console.WriteLine(oy + " oyda  Pulimiz " + p + " % ga oshgan  Sum = " + S);
  
//}
//Console.WriteLine("OY = " + oy);
//Console.WriteLine("=====================");
//goto salom;