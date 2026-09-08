using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            // LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
            // LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            throw new System.NotImplementedException();
        }

        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> linkedlist = new LinkedList<string>();

            linkedlist.AddLast("Node 1");
            linkedlist.AddLast("Node 2");
            linkedlist.AddFirst("Node 0");

            LinkedListNode<string> node1 = linkedlist.Find("Node 1");
            Debug.Log(node1.Value);
            Debug.Log(node1.Next.Value);
            Debug.Log(node1.Previous.Value);
            
            var firstNode = linkedlist.First;
            var lastNode = linkedlist.Last;
            Debug.Log(firstNode.Previous);
            Debug.Log(lastNode.Previous);

            linkedlist.AddAfter(node1, "Node 1.5");
            linkedlist.AddBefore(node1, "Node 0.5");

            linkedlist.RemoveFirst();
            linkedlist.RemoveLast();

            linkedlist.Remove("Node 1.5");
            linkedlist.Clear();
        }

        public void LCT03_SyntaxHashTable()
        {
            throw new System.NotImplementedException();
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<string, int> inv = new Dictionary<string, int>();
            //var inv = new Dictionary<string, int>();

            inv.Add("Potion", 5);
            inv.Add("Banana", 1);
            inv.Add("Apple", 10);

            // Potion: 5
            // Banana: 1
            // Apple: 10

            // Potion: 5
            // Banana: 1
            // Apple: 0
            inv["Apple"] = 0;

            // Potion: 5
            // Banana: 1
            // Apple: 0
            // Apple1: 1
            inv["Apple1"] = 1;

            int potion = inv["Potion"];
            Debug.Log("potion: " + potion);

            //int apple2 = inv["Apple2"];
            //Debug.Log("apple2: " + apple2);

            bool hasPotion = inv.ContainsKey("Potion");
            Debug.Log("hasPotion: " + hasPotion);

            inv.Remove("Banana");

            foreach (KeyValuePair<string, int> kvp in inv)
            {
                var key = kvp.Key;
                var value = kvp.Value;
                Debug.Log($"{key} => {value}");
                //inv.Add("mm", 1);
            }

            inv.Clear();
        }

        #endregion
    }
}
