namespace FizzBuzz;

public class FizzBuzz
{
    public FizzBuzz()
    {

    }

    public string TransformNumber(int number)
    {
        // We have two numbers, 3 and 5
        // a simple switch case should do the trick, or an If loop
        /**
        Alternative 1
        
        switch (number)
        {
            case 3:
            {
                return "Fizz";
            }
            case 5:
            {
                return "Buzz";
            }
            // also needs a default, we'll leave this empty for now
            default:
            {
                return "";
            }
        }
        */
        /**
        Alternative 2
        */
        if (number == 3)
        {
            return "Fizz";
        }
        else return "Buzz";
    }
}