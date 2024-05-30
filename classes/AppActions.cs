    namespace AppActions {
        class UserActions {
            public static int getInitialAction () {            
                Console.WriteLine("1 - Start\n2 - Exit");

                return Convert.ToInt32(Console.ReadLine());
            }

            public static int getAction () {            
                Console.WriteLine("Select:\n1 - Connect\n2 - Query\n3 - Exit");

                int val = 0;

                do {                
                    try {
                        val = Convert.ToInt32(Console.ReadLine());

                        if (val > 3) throw new InvalidOperationException("Error: initial action");

                    } catch (System.Exception) {                
                        Console.Clear();
                        val = 0;
                        Console.WriteLine("Invalid options, try again:");
                    }    
                } while (val == 0);

                return val;
            }

            public static int getValue(string actionName) {
                int val = 0;
                bool isValid = false;

                do {                
                    try {
                        Console.WriteLine(actionName);   
                        val = Convert.ToInt32(Console.ReadLine());

                        if (val != 0 && val <= 8) {
                            isValid = true;
                        } else {
                            Console.Clear();
                            Console.WriteLine("Value cannot be zero or great than eight, try again:");
                        }

                    } catch (System.Exception) {                
                        Console.Clear();
                        Console.WriteLine("Invalid value, try again:");
                    }    
                } while (!isValid);

                return val;
            }
        }
    }