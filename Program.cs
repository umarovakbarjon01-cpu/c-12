int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(IsDivisible(a,b));
bool IsDivisible(int number, int divisor)
{
    if(number%divisor==0)
    {
        return true;
    }
    return false;
}