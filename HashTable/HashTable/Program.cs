using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to HashTable!");
            Console.WriteLine(" Enter 1 to find frequency");
            Console.WriteLine(" Enter 2 to find frequency in paragraph");
            Console.WriteLine(" Enter 3 to remove avoidable word from paragraph");
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
                    hashTable.GetFrequency("be");          
            
                    break;
                case 2:
                    MyMapNode<string, string> hashtable = new MyMapNode<string, string>(10);
                    
                    String paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";                    
                    string[] paragraphSentence = paragraph.Split(' ');                   
                    int SLength = paragraphSentence.Length;                   
                    for (int i = 0; i < SLength; i++)
                    {
                        hashtable.Add(Convert.ToString(i), paragraphSentence[i]);
                    }                    
                    foreach (string word in paragraphSentence)
                    {
                        hashtable.GetFrequency(word);
                    }
                    Console.ReadLine();
                    break;
                case 3:

                    MyMapNode<string, string> hash = new MyMapNode<string, string>(5);                    
                    String para = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    
                    string[] paragraph_ = para.Split(' ');                   
                    int StringLength = paragraph_.Length;                  
                    for (int i = 0; i < StringLength; i++)
                    {
                        hash.Add(Convert.ToString(i), paragraph_[i]);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Removing the word 'avoidable' from the hash table ");
                    Console.WriteLine("Frequency of 'avoidable' before removal is :" + hash.GetFrequency("avoidable"));
                    hash.RemoveValue("avoidable");
                    Console.WriteLine("Frequency of 'avoidable' after removal is :" + hash.GetFrequency("avoidable"));
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Enter Valid number");
                    break;
            }
        }
    }
}
