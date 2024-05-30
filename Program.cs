using System;
using AppActions;
using NetworkApp;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Welcome to a simple logical test system");

        int action = 0;

        do {                
            try {

                action = UserActions.getInitialAction();

                if (action > 2) throw new InvalidOperationException("Error: initial action");

            } catch (System.Exception) {                
                Console.Clear();
                action = 0;
                Console.WriteLine("Invalid options, try again:");
            }    
        } while (action == 0);

        if (action == 2) Environment.Exit(0);

        Console.Clear();

        Network _net = new Network(8);

        int user_action = 0;
        
        do {
            user_action = UserActions.getAction();

            if (user_action != 3) {  
                int value_one = UserActions.getValue("Inform the first value (Choose between 1 to 8)");
                int value_two = UserActions.getValue("Inform the second value (Choose between 1 to 8)");

                if (user_action == 1) _net.connect(value_one, value_two);
                if (user_action == 2) _net.query(value_one, value_two);
            }

        } while (user_action != 3);

        Console.WriteLine("Exiting...");
        Environment.Exit(0);
    }
}
