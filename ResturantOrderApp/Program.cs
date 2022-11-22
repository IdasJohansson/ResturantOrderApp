// See https://aka.ms/new-console-template for more information

//Create a console Application to take a drink order in a Restaurant, follow the instructions below:

//Let your program ask the user for his name and save it into a variable.
//Let your program greet the user by his name, and ask for his/her birth year and
//convert it into an integer. For example 1978 or 1983.

//Calculate the age of the user by simple integer subtraction from the current
//year. 

//Then,
//❖ If the user is 18 or above
//➢ Ask if the user want to order abeer
//➢ If he/she want to order a beer
//▪ Display a message that the order has been done!
//➢ If he/she does not want to order a beer
//▪ Ask if he/she want to order a coke
//▪ If he/she want to order a coke
//• Then display a message that the coke has been served
//▪ If he/she does not want to order a coke
//• Then display a message that no order options are available
//❖ If the user is below 18 years old
//➢ Ask if the user want to order a coke
//➢ If he/she want to order a coke
//▪ Then display a message that the coke has been served
//➢ If he/she does not want to order a coke
//▪ Then display a message that no order


StartOrder();

void StartOrder()
{
    Console.WriteLine("Please enter your name:");
    string? name = Console.ReadLine();
    Console.Clear();

    Console.WriteLine($"Welcome {name}!");
    Console.WriteLine("At what year are you born?");
    try
    {
    int birthYear = Convert.ToInt32(Console.ReadLine());
    Console.Clear();   
    int currentYear = DateTime.Now.Year;
    int age = currentYear - birthYear;
    Console.WriteLine($"Your age is: {age} years.");
    Console.WriteLine();
    Console.WriteLine("---------------------------");
    if (age > 18)
    {
        Console.WriteLine("Would you like to order a beer? [Yes/No]");
        string answer = Console.ReadLine();
        string answerToUpper = char.ToUpper(answer[0]) + answer.Substring(1);
        if (answerToUpper == "Yes")
        {
            ServeBeer();
            StartOrder();
        }
        else
        {
            string secondAnswer = OrderCoke();
            if (secondAnswer == "Yes")
            {
                ServeCoke();
                StartOrder();
            }
            else
            {
                NoOrder();
            }
        }
    }
    else
    {
        string answer = OrderCoke();
        if (answer == "Yes")
        {
            ServeCoke();
            StartOrder();
        }
        else
        {
            NoOrder();
        }
    }
    Console.WriteLine();

    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        Console.WriteLine("Only numbers are valid as input, press a key and try again...");
        Console.ReadLine(); 
        StartOrder();
    }
}


void ServeBeer()
{
    Console.WriteLine("Your order has succesfully been registered.");
    Thread.Sleep(500);
    Console.WriteLine("Here is your beer: ");
    Console.WriteLine(@".~~~~.
i====i_
|cccc|_)
|cccc|   
`-==-'");

    Console.ReadKey();
}

string OrderCoke()
{
    Console.WriteLine("Do you want to order a coke? [Yes/No]");
    string answer = Console.ReadLine();
    string answerToUpper = char.ToUpper(answer[0]) + answer.Substring(1);
    return answerToUpper;
}

void ServeCoke()
{
    Console.WriteLine("Your coke has been served.");
    Console.WriteLine(@"      _                                   
          .!.!.                             
           ! !                                   
           ; :                                
          ;   :                                
         ;_____:                                 
         ! Coca!                                 
         !_____!                                 
         :     :
         :     ;                                       
         .'   '.                             
         :     :                            
          '''''");
    Console.ReadKey();
}

void NoOrder()
{
    Console.WriteLine("No other order options are avalible..");
    Console.ReadKey();
}