namespace Program;
public class Program{

    public static void Main(string[] arg)
    {
        Console.WriteLine("Enter a year and we will say if it is a leap Year!");
        var input = Console.ReadLine();
        if(input == null){
             return;
        }
        int yr = Int32.Parse(input);

        if(isLeapYear(yr)){
            Console.WriteLine("yay");
        }else{
            Console.WriteLine("nay");
        }
        
    }
    public static bool isLeapYear(int year)
{
    if(year%4==0 && year>0){
    return true;
    }
    return false;
}

}




