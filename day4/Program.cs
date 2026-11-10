//ClasTask1

// int a = Convert.ToInt32(Console.ReadLine());

// int b = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(IsDivisible(a,b));

// bool IsDivisible(int number, int divisor)
// {
//     if(number%divisor==0)
//     {
//         return true;
//     }
//     return false;
// }

//ClasTask2


// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(GetNumberType(a));

// string GetNumberType(int number)
// {
//     if(number%2==0)
//     {
//         return "Even";
//     }
//     return "Odd";
// }

//ClasTask3


// int x = Convert.ToInt32(Console.ReadLine());

// int y = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(CountNumbers (x,y));

// int CountNumbers(int a, int b)
// {
//     if(a==b)
//     {
//         return 0;
//     }
//     return Math.Abs(b-a)-1;
// }

//ClasTask4

// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(SumFromOneToN(a));

// int SumFromOneToN(int n)
// {
// int sum=0;
//     for(int i=1; i<=n; i++)
//     {
//         sum+=i;
//     }
//     return sum;
// }

//ClasTask5

// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(Factorial(a));

// long Factorial(int n)

// {
//     if(n==1)
//     {
//         return n;
//     }
//     return n*Factorial(n-1);
// }



//ClasTask 6

//  int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(ReverseNumber(a));

// int ReverseNumber(int number)

// {
//     int sum=0;
//     for(int i=number; i>0; i/=10)
//     {
//         sum=sum*10+i%10;
//     }
//     if(sum==0)
//     {
//         return 5;
//     }
//     return sum;
// }

//ClasTAsk7

//  int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(ReverseNumber(a));


// int ReverseNumber(int number)

// {
//     int sum=0;
//     for(int i=number; i>0; i/=10)
//     {
//         sum=sum*10+i%10;
//     }
//     return sum;
// }


//ClasTask8

// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(CountDigits(a));

// int CountDigits(int number)

// {
//     if(number==0)
//     {
//         return 0;
//     }
//     return 1+(CountDigits(number/10));  
// }

//ClasTask9

int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(CountDigits(a));

int CountDigits(int number)

{
    if(number==0)
    {
        if(number%2==0)
        return 0;
    }    
    return 1+( CountDigits(number/10));  
}



