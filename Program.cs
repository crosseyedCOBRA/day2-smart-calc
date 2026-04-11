int first_number;
int sec_number;
int total = 0;
int action;
int run_again = 1;

while (run_again != 2)
{

    Console.Write("Enter your first number and press Enter:  ");
        while (!int.TryParse(Console.ReadLine(), out first_number))
        {
            Console.Write("Invalid Input. Please enter a valid number.");
            
        }
    //Console.WriteLine("First Number entered is: " + first_number);



    Console.Write("Which action would you like to take? Enter the corresponding number and press Enter. \n 1. +  \n 2. - \n 3. * \n 4. /  \n");
        while (!int.TryParse(Console.ReadLine(), out action))
        {
            Console.WriteLine("Invalid Input. Please enter a valid number.");
        }
    


    Console.Write("Enter your second number and press Enter:  ");
        while (!int.TryParse(Console.ReadLine(), out sec_number))
        {
            Console.Write("Invalid Input. Please enter a valid number.");
            
        }
       // Console.WriteLine("Second Number entered is: " + sec_number);


        
        string action_taken = "";
        
        if (action == 1 )
        {
            total = first_number + sec_number;
            action_taken = "+";
        }
        else if (action == 2 )
        {
            total = first_number - sec_number;
            action_taken = "-";
        }
        else if (action == 3 )
        {
            total = first_number * sec_number;
            action_taken = "*";
        }
        else if (action == 4)
        {
            total = first_number / sec_number;
            action_taken = "/";
        }


Console.WriteLine("Your equation was: " + first_number + " " + action_taken + " " + sec_number + " = " + total);



Console.WriteLine("Would you like to do another calculation or quit? Enter 1 or 2 and press enter. \n 1. Run Again \n 2. Exit");
        while (!int.TryParse(Console.ReadLine(), out run_again))
        {
            Console.Write("Invalid Input. Please enter a valid number.");
            
        }
        if (run_again == 2 )
        {
            Console.WriteLine("Calculator has exited.");
        }




}