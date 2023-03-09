//static massiv
//int[] sonlar = { 1, 4, 3, 1 };
//string[] mevalar = { "olma", "anor", "shaftoli" };
////double[] doubleSonlari = { 0.005, 1.234, 12.5, 13.5, 10.6 };
//for (int i = 0;i < mevalar.Length; i++)
//{
//    Console.WriteLine("mevalar [ " + i + " ] = " + mevalar[i]);
//}
//dinamic massiv
//int n = Convert.ToInt32(Console.ReadLine());
////int[] num10 = new int[10];
////float[] M2 = new float[100];
//double[] ConsolNum = new double[n];
//double j = 1;
//for (int i = 0; i < n; i++)
//{
//    ConsolNum[i] = j;
//    Console.WriteLine("ConsoleNum [ " + i + " ] = " + ConsolNum[i]);
//    j++;
//}
//Console.Write("Massiv ulchamini kiriting = ");
//int n = int.Parse(Console.ReadLine());
//int[] sonlar = new int[n];
//int i;
//for (i = 0; i < n; i = i + 1)
//{

//    Console.Write("sonlar[ " + i + " ] = ");
//    sonlar[i] = Convert.ToInt32(Console.ReadLine());

//}
//Console.WriteLine("=========================");
//for (i = 0; i < n; i = i + 1)
//{
//    if (sonlar[i] % 2 == 0)
//    {
//        Console.WriteLine("sonlar[ " + i + " ] = " + sonlar[i]);
//    }
//}


//salom:
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//int[] sonlar = new int[n];
//int i;
//for (i = 0; i < n; i++)
//{
//Console.Write("sonlar [ " + i + " ] = ");
//sonlar[i] = int.Parse(Console.ReadLine());

//}
//int sanagich = 0, s = 0;
//Console.WriteLine("===================");
//for (i = 0; i < n; i++)
//{
//if (sonlar[i] > 0)
//{
//sanagich++;
//Console.WriteLine("sonlar [ " + i + " ] = " + sonlar[i]);
//s += sonlar[i];
//}
//}
//if (sanagich == 0)
//{
//Console.WriteLine("massivda musbat  son yuq");
//}
//else
//{
//Console.WriteLine("musabat sonlar = " + sanagich);
//}
//Console.WriteLine("yigindi = " + s);
//goto salom;







//salom:
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//int[] sonlar = new int[n];
//int i;
//for (i = 0; i < n; i++)
//{
//    Console.Write("sonlar [ " + i + " ] = ");
//    sonlar[i] = int.Parse(Console.ReadLine());

//}
//int sanagich = 0, s = 0;
//Console.WriteLine("===================");
//for (i = 0; i < n; i++)
//{
//    if ()
//    {
//        sanagich++;
//        Console.WriteLine("sonlar [ " + i + " ] = " + sonlar[i]);
//    }
//}
//if (sanagich == 0)
//{
//    Console.WriteLine("massivda musbat  son yuq");
//}
//else
//{
//    Console.WriteLine("musabat sonlar = " + sanagich);
//}
//goto salom;




//salom:
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//int[] sonlar = new int[n];
//int i;
//for (i = 0; i < n; i++)
//{
//    Console.Write("sonlar [ " + i + " ] = ");
//    sonlar[i] = int.Parse(Console.ReadLine());

//}
//Console.WriteLine("===================");

//for (i = 0; i < n;i++)
//{
//    bool t = false;
//    for (int j = 2; j < sonlar[i]; j++)
//    {
//        if (sonlar[i]  % j == 0)
//        {
//            t = true;
//        }
//    }
//    if (t == false)
//    {

//        Console.WriteLine("sonlar[ " + i + " ] = " + sonlar[i]);
//    }
//}
//goto salom;




//Random rd= new Random();
//rd.Next(1, 10);
//for (int i = 0;i < 10; i++)
//{
//    rd.Next();
//}
//massiv 1
//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
//double[] massiv = new double[n];

//for (int i = 0; i < n; i++)
//{
//    massiv[i] = double.Parse(Console.ReadLine());
//}
//for (int i = n - 1; i >= 0; i--)
//{
//    Console.WriteLine("massiv [ " + i + " ] = " + massiv[i]);
//}

//int myInt = 9;
//double myDouble = myInt;       // Automatic casting: int to double
//float myFloat = 2.34f;
//int myInt1 = (int)myFloat;
//Console.WriteLine(myFloat.GetType() + " " + myFloat);      // Outputs 2.34
//Console.WriteLine(myInt1.GetType() + " " + myInt1);   // Outputs 2

//Console.WriteLine(myInt.GetType() + " " +  myInt);      // Outputs 9
//Console.WriteLine(myDouble.GetType() + " " + myDouble);   // Outputs 9
//int myInt = 10;
//double myDouble = 5.25;
//bool myBool = true;

//Console.WriteLine(Convert.ToString(myInt));    // convert int to string
//Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
//Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
//Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
//string FullName = "Aslanbek Hasanov";

//float num = float.Parse(Console.ReadLine());//Consoledan qiymat kiritish
//Console.WriteLine(num + 1);//Qiymatimizni Consolega chiqarish imkonini beradi.

//Console.Write("Enter 1 - number : ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter 2 - number : ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//massiv 8

//Console.Write("n = "); int n = int.Parse(Console.ReadLine());
////Console.Write("A = "); int A = int.Parse(Console.ReadLine());
////Console.Write("B = "); int B = int.Parse(Console.ReadLine());
//int[] massiv = new int[n];
//for (int i = 0; i < n; i++)
//{
//    massiv[i] = int.Parse(Console.ReadLine());
//}
//int leanth = 0;
//for (int i = 0; i < n; i++)
//{
//    if (massiv[i] % 2 == 1)
//    {
//        leanth++;
//        Console.WriteLine("massiv [ " + i + " ] = " + massiv[i]);
//    }
   
//}
//Console.WriteLine(leanth + " toq son bor");


//MASSIV 8 - misol
//Console.Write("n = ");
//int a = 0, n = int.Parse(Console.ReadLine());
//int[] massiv = new int[n];
//for (int i = 0; i < n; i++)
//{
//    Console.Write("[ " + i + " ] = ");
//    massiv[i] = int.Parse(Console.ReadLine());
//}
//for (int i = 0; i < n; i++)
//{
//    if (massiv[i] % 2 == 1 && massiv[i] > 0)
//    {
//        Console.Write(i + ", ");
//        a++;
//    }
//}
//Console.WriteLine("toq sonlar " + a + " ta");
//massiv 9-misol  
//Console.Write("n = ");
//int a = 0, n = int.Parse(Console.ReadLine());
//int[] massiv = new int[n];
//for (int i = 0; i < n; i++)
//{
//    Console.Write("[ " + i + " ] = ");
//    massiv[i] = int.Parse(Console.ReadLine());
//}
//for (int i = 0; i < n; i++)
//{
//    if (massiv[i] % 2==0)
//    {
//        Console.Write(massiv [i] + ", ");
//        a++;
//    }
//}
//Console.WriteLine("toq sonlar " + a + " ta");

//MASSIV 
Console.Write("n = ");
Console.Write()
int a = 0, n = int.Parse(Console.ReadLine());
int[] massiv = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("[ " + i + " ] = ");
    massiv[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if (massiv[i] % 2 == 0 && massiv[i] > 0)
    {
        Console.Write(massiv[i] + ", ");
        a++;
    }
}
Console.WriteLine("jup son " + a + " ta");
















