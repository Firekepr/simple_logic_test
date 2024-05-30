using System;
using System.Collections.Generic;

namespace NetworkApp {
    public class Network {
        private int _size;
        private Dictionary<int, List<int>> _connections;

        public Network(int size) {
            if (size <= 0) throw new ArgumentException("Size must be a positive integer.");
        
            _size = size;
            _connections = new Dictionary<int, List<int>>();

            for (int i = 1; i <= size; i++) _connections[i] = new List<int>();        
        }

        public void connect(int value_one, int value_two) {
            if (value_one <= 0 || value_two <= 0 || value_one > _size || value_two > _size) throw new ArgumentException("Elements must be within the range of the network.");
            
            _connections[value_one].Add(value_two);
            _connections[value_two].Add(value_one);

            Console.Clear();

            Console.WriteLine($"Numbers {value_one} and {value_two} connected!");
            Console.WriteLine("--------------------------------");
        }
    }
}