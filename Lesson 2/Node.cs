using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{ 
    public class Node : ILinedList
    {
      
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }

        public int GetCount() // возвращает количество элементов в списке
        { 
            int i = 0;
            if (NextNode == null)
            {
                return 0;
            }

            else
            {
                while (NextNode != null)
                {
                    i++;
                }
                return i;
            }

           
        }

        public void AddNode(int value)  // добавляет новый элемент списка
        {
                        
            while (NextNode != null)
            {
                NextNode = NextNode.NextNode;
            }

            Node newNode = new Node { Value = value };
            NextNode = newNode;
            newNode.PrevNode = NextNode;            

            
        }
        public void AddNodeAfter(Node node, int value) { // добавляет новый элемент списка после определённого элемента            

            while (NextNode != null)
            {
                if(NextNode == node)
                {
                    var nextItem = node.NextNode;  // Разобраться
                    var prevItem = node.NextNode.PrevNode;

                    node.NextNode = null;
                    
                    
                    var newNode = new Node {Value = value };

                    newNode.NextNode = prevItem;
                    newNode.PrevNode = node;

                    node.NextNode = newNode;

                }
            }

        }
        public void RemoveNode(int index) { // удаляет элемент по порядковому номеру
                       
            int currentIndex = 0;

            Node nextItem;
            Node prevItem;

            var currentNode = NextNode.PrevNode; // Кастыль какой-то... 

            
            while (NextNode != null)
            {
                currentIndex++;
                currentNode = currentNode.NextNode;

                if (currentIndex == index - 1)
                {
                    nextItem = currentNode.NextNode;
                    prevItem = currentNode.PrevNode;

                    currentNode.NextNode = null;
                    currentNode.PrevNode = null;

                    prevItem.NextNode = nextItem;
                    nextItem.PrevNode = prevItem;

                }
            }

        }
        public void RemoveNode(Node node) { // удаляет указанный элемент
        }
        //public Node FindNode(int searchValue) { // ищет элемент по его значению
        //    return Node;
        //}
    }

}

