using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableProblem
{
    public class HashTableMethods<K, V>
    {
        public MyMapNode<K, V>[] Keys;
        public int tableSize;

        public HashTableMethods(int maxTableSize)//Constructor
        {
            tableSize = maxTableSize;
            Keys = new MyMapNode<K, V>[tableSize];

        }
        public int HashFunction(K key)
        {
            int position = key.GetHashCode() % tableSize; //identifying hash code of key
            return Math.Abs(position);
        }

        public void Insert(K key, V value)
        {
            int genIndex = HashFunction(key);
            MyMapNode<K, V> node = Keys[genIndex];

            if (node == null)
            {
                Keys[genIndex] = new MyMapNode<K, V>() { Key = key, Value = value };
                return;
            }

            MyMapNode<K, V> newNode = new() { Key = key, Value = value, Previous = node, Next = null };
            node.Next = newNode;
        }

        public V GetValue(K key)
        {
            int genIndex = HashFunction(key);
            MyMapNode<K, V> node = Keys[genIndex];
            while (node != null)//search the linked list to match the key
            {
                if (node.Key.Equals(key))
                {
                    return node.Value;
                }
                node = node.Next;
            }

            throw new Exception("Don't have the key in hash!");
        }


    }
}

