namespace Program;
public class Program{

    public static void Main(string[] arg)
    {
        Console.WriteLine("Enter a year after 1582 and we will say if it is a leap Year!");
        var input = Console.ReadLine();
        if(input == null){
             return;
        }
        
        if(int.TryParse(input, out int value) && value > 1582){
            int yr = Int32.Parse(input);

            answer(yr);
        }else{
            notYear();
        }
        
    }
    public static bool isLeapYear(int year)
{
    if(year%4==0 && year>0){
    return true;
    }
    return false;
}

    public static void notYear()
{   
    bool breaker = false;
    while(!breaker){
        Console.WriteLine("Please enter a valid number above 1582");
        var input = Console.ReadLine();

        if(input == null){
             return;
        }

        if(int.TryParse(input, out int v)){
            int mon = Int32.Parse(input);
            if(mon > 1582){
            breaker = true;
            answer(v);
            }
        }
    }
    
}

public static bool isValid(String st){
    if(int.TryParse(st, out int v) && Int32.Parse(st) > 1582){
        return true;
    }
    return false;
}

public static void answer(int num){
    if(isLeapYear(num)){
            Console.WriteLine("yay");
            }else{
            Console.WriteLine("nay");
            }
}

}




