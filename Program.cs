using System;
using AppActions;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Welcome to a simple logical test system");
        Console.WriteLine("Select:");

        int initial_action = 0;

        do {                
            try {

                initial_action = InitialActions.getAction();

                if (initial_action > 2) throw new InvalidOperationException("Error: initial action");

            } catch (System.Exception) {                
                Console.Clear();
                initial_action = 0;
                Console.WriteLine("Invalid options, try again:");
            }    
        } while (initial_action == 0);

        if (initial_action == 2) Environment.Exit(0);
    }
}
