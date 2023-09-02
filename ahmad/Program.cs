// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using firstclass;
using System.Diagnostics;

internal class Program
{



    static void Welccom(string name, int age)
    {
        Console.WriteLine($"welcoom back : {name}and age is : {age}");
    }
    //   
    // 
    // 
    static int Math(int x, int y)
    {
        // 1) Console.WriteLine($"{x+y}");
        return x + y;
    }

    private static void Main(string[] args)
    {
        //         Console.WriteLine("Hello Mono World");
        //         int age = 12;
        //         Console.WriteLine("m name is Ahmad my age is {0}", age);
        //         if (age >= 18)
        //         {
        //             Console.WriteLine("you can jon ");
        //         }
        //         else
        //         {
        //             Console.WriteLine("you cannot join");
        //         }


        //         int num = 19;
        //         Console.WriteLine(num);
        //         double num2 = 11.11;
        //         Console.WriteLine(num2);
        //         double num3 = (int)num2;
        //         Console.WriteLine(num3);
        //         Console.WriteLine("\n");
        //         string str = "ahmad";
        //         Console.WriteLine(str);
        //         char ch = 'a';
        //         Console.WriteLine(ch);
        //         bool bl = true;
        //         Console.WriteLine(bl);

        //       Console.WriteLine("put you name ther :");
        //        string user = Console.ReadLine();
        //         Console.WriteLine("my name is : " + user);
        //            // 
        //           // 
        //          // 
        //         Console.WriteLine(user+num3);

        //   Console.WriteLine("put sosID : ");
        //   int sosID = Convert.ToInt32(Console.ReadLine());  //for just inegar number
        //    Console.WriteLine("sosID is a : "+sosID);
        // //    
        // // 
        // // 
        //    Console.WriteLine("put the FirstvarpID : ");
        // int FirstvarpID = Convert.ToInt32(Console.ReadLine());  //for just inegar number

        //      Console.WriteLine("put the soconadvarpID : ");
        //   int soconadvarpID = Convert.ToInt32(Console.ReadLine());  //for just inegar number

        //   Console.WriteLine(FirstvarpID + soconadvarpID);
        //     Console.WriteLine(FirstvarpID - soconadvarpID);
        //   Console.WriteLine(FirstvarpID * soconadvarpID);
        // if (FirstvarpID > soconadvarpID)
        // {
        //      Console.WriteLine("/"+FirstvarpID / soconadvarpID);

        // }else
        // {
        //          Console.WriteLine("/"+soconadvarpID / FirstvarpID);

        // }
        //     Console.WriteLine(FirstvarpID % soconadvarpID);
        //     //
        //     //
        //    Console.WriteLine("new variple");
        //  int newvarpile = 2;
        //      Console.WriteLine(newvarpile);

        //      newvarpile +=+1;
        //        Console.WriteLine(newvarpile);

        //   newvarpile +=+10;
        //      Console.WriteLine(newvarpile);

        // //
        // //
        // //
        // Console.WriteLine("\n");

        //         Console.WriteLine(System.Math.Max(20,40));
        //         Console.WriteLine(System.Math.Min(5,10));

        // // 
        // // 
        // // 
        // Console.WriteLine("\n \n");
        // string newword = "HI AHMAD ZUAINAT -_-";

        // Console.WriteLine(newword);

        // Console.WriteLine("THE caords number = "+newword.Length);
        // // 
        // // 
        // // 
        // Console.WriteLine("beack of if : \n ");

        // int dodo = 33 ;
        // string dodoS = (dodo > 30)? "true" : "fuls" ;    
        // Console.WriteLine(dodoS);
        // //  
        // // 
        // // 
        // Console.WriteLine("Switch : \n ");

        // int cas =2 ;
        // switch (cas)
        // {
        //     case 1 :
        //     Console.WriteLine ("case one");
        //     break;
        //     case 2 :
        //     Console.WriteLine ("case tow");
        //     break;
        //     case 3 :
        //     Console.WriteLine ("case thre");
        //     break;
        //     default:
        //     Console.WriteLine ("default");
        //     break;
        // }
        // //  
        // // 
        // // 
        // Console.WriteLine("wahl loop \n ");
        // int p=0;
        // while (p < 7)

        // {
        //     Console.WriteLine("p ="+p);
        //     p ++;
        // }
        // // 
        // // 
        // // 
        // Console.WriteLine(" for : \n ");
        // for (int i = 0; i < 5; i++)
        // {
        //     Console.WriteLine("i = "+i);
        // }


        // string [] A= {"Ahmad", "sary" , "marem" , "sedra" } ;
        // // for (int i = 0; i <5 ; i++)
        // // {
        // //     Console.WriteLine(A);
        // // }
        // foreach (string Ao in A)
        // {
        //         Console.WriteLine(Ao);
        // }

        // int [] arry = { 6 , 2 ,1 , 10 ,5 ,6 ,7};

        // Console.WriteLine(arry[3]);
        // // Array.Sort(arry);
        // for (int i = 0; i < arry.Length;)
        // {
        //     Console.WriteLine(arry[i]  + "\n");
        //     i++;
        // }
        // // 
        // Console.WriteLine("\n is a forech : \n");

        // string [] shop ={"babse","saven up","reed pull","doretous","kaka"};

        // Console.WriteLine(shop.Length);

        // Array.Sort(shop);

        //foreach (string i in shop)
        //{
        //  Console.WriteLine(i);

        //}
        // 
        // 
        Console.WriteLine("\n");

        Welccom("ahmad", 20);
        Welccom("yousef", 19);
        Welccom("abood", 15);

        // 1) math(10,20);
        Console.WriteLine(Math(10, 20));
        //  
        // 
        // 
        string phonnumber = "123-456-789";
        phonnumber = phonnumber.Replace("-", "/");
        Console.WriteLine(phonnumber);
        // 
        // 
        // 
        Console.WriteLine(" sid of A : ");

        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(" sid of B : ");

        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine((a * a) + (b * b));
        // 
        // 
        //  
        maseege.Bey();
        maseege.Haloo();
        firstclass.maseege.Bey();
        //
        //
        //

      //ars car1 = new cars("formoating", "jeep", "BLACK", 2023);
      //car1.drive();


        Console.WriteLine("Ahmad");

        //Console.WriteLine("ples put the number : ");
        //var a = int.Parse(Console.ReadLine());
        //var resort = a * 5;
        //Console.WriteLine(resort);





    }
}