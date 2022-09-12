using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to HashTable!");
            Console.WriteLine(" Enter 1 to find frequency");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
            MyMapNode<string, string> hashTable = new MyMapNode<string, string>(5);
                    hashTable.Add("0", "To");
                    hashTable.Add("1", "be");
                    hashTable.Add("2", "or");
                    hashTable.Add("3", "not");
                    hashTable.Add("4", "To");
                    hashTable.Add("5", "be");
                    hashTable.GetFrequency("To");

                    break;

                default:
                    Console.WriteLine("Enter Valid number");
                    break;
            }
        }
    }
}
