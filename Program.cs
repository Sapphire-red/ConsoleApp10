using System;
namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine();
        }
    }
    public class Monster {
        public string Name { get; set; } = string.Empty;
        public int Hearth {
            get { return _hearth; }
            set { _hearth = value; }
        }
        private int _hearth;
        public int Strong {
            get { return _strong; }
            set { _strong = value; }
        }
        private int _strong;
    }
}
