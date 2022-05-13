// See https://aka.ms/new-console-template for more information
using HashTableProblem;
using System.Collections;

Console.WriteLine("Implementation of Hashtable using LinkedList!");
HashTableMethods<string, int> hashTable = new(6);
hashTable.Insert("To", 1);
hashTable.Insert("be", 2);
hashTable.Insert("or", 3);
hashTable.Insert("not", 4);
hashTable.Insert("to", 5);
hashTable.Insert("be", 6);

Console.WriteLine("Value of key 'be' is: " + hashTable.GetValue("be"));
