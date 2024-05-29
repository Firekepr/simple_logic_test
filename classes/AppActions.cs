namespace AppActions {
    class InitialActions {
        public static int getAction () {
            Console.WriteLine("Select:");
            Console.WriteLine("1 - Start:\n2 - Exit:");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}