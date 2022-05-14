// See https://aka.ms/new-console-template for more information
using HashTableProblem;
using System.Collections;

Console.WriteLine("Implementation of Hashtable using LinkedList!");

while (true)
{
    Console.WriteLine("Please choose the option :\n1)uc1\n2)uc2");
    int option=Convert.ToInt32(Console.ReadLine());
    switch(option)
    {
        case 1:
            HashTableMethods<string, int> hashTable = new(6);
            hashTable.Insert("To", 1);
            hashTable.Insert("be", 2);
            hashTable.Insert("or", 3);
            hashTable.Insert("not", 4);
            hashTable.Insert("to", 5);
            hashTable.Insert("be", 6);
            Console.WriteLine("Value of key 'be' is: " + hashTable.GetValue("or"));
            hashTable.Remove("or", hashTable);
            Console.WriteLine("Value of key 'be' is: " + hashTable.GetValue("or"));
            break;
        case 2:
            string GivenPara = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] WordsInArray = GivenPara.Split(" ");
            int tableSize = WordsInArray.Length;
            HashTableMethods< int, string> hashTable1 = new(tableSize);
            int Index = 0;
            foreach (string words in WordsInArray)
            {
                hashTable1.Insert(Index, words);
                Index++;
            }
            for (Index = 0; Index < tableSize; Index++)
            {
                string word = hashTable1.GetValue(Index);
                Console.WriteLine(word + "-->" + Index);

            }
            break;
        default :
            Console.WriteLine("Please choose the correct option!");
            break;

    }
}

