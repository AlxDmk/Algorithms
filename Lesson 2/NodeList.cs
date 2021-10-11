using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
   public class NodeList: ILinedList

    { 
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public NodeList( int data )
        {
            Node item = new Node(data);
            Head = item;
            Tail = item;
            Count = 1;            
        }
                    

        public int GetCount() // возвращает количество элементов в списке
        {
            return Count;
        }

        public void AddNode(int value)  // добавляет новый элемент списка
        {
            Node newNode = new Node ( value );
            var currentItem = Head;
            while (currentItem.NextNode!=null)
            {
                currentItem = currentItem.NextNode;
            }
            Tail = currentItem;
            newNode.PrevNode = Tail;
            Tail.NextNode = newNode;
            Tail = newNode;

            Count++;
        }

        public void AddNodeAfter(Node node, int value) // добавляет новый элемент списка после определённого элемента    
        {
            Node currentItem = Head;

            Node newNode = new(value);

            while (currentItem != null)
            {
                if (currentItem == node)
                {
                    Node nextItem = currentItem.NextNode;
                    newNode.PrevNode = currentItem;
                    currentItem.NextNode = newNode;
                    newNode.NextNode = nextItem;
                    nextItem.PrevNode = newNode;
                    
                    Count++;
                    
                }
            }            
        }

        public void RemoveNode(int index) // удаляет элемент по порядковому номеру
        {
            int currentIndex = 0;

            Node currentNode = Head;
                        
            while(currentNode != null)
            {
                currentIndex ++;  // Оговорка: порядковый номер всегда начинается с Единицы, а значит не совпадает с индексом элемента списка. => HEAD будет иметь порядковый номер 1.

                if (currentIndex == index)  
                {
                    Node prevItem = currentNode.PrevNode;
                    Node nextItem = currentNode.NextNode;

                    prevItem.NextNode = nextItem;
                    nextItem.PrevNode = prevItem;
                    Count--;
                    return;
                }
                currentNode = currentNode.NextNode;
            }           

        }
        public void RemoveNode(Node node)  // удаляет указанный элемент
        {
            Node currentNode = Head;
            if (currentNode == node)
            {                
                Head = currentNode.NextNode;
                Head.PrevNode = null;
                return;
            }
            

            while (currentNode != null)
            {
                if (currentNode == node)
                {
                    Node prevItem = currentNode.PrevNode;
                    Node nextItem = currentNode.NextNode;

                    prevItem.NextNode = nextItem;
                    nextItem.PrevNode = prevItem;
                    currentNode = null;
                    Count--;
                    return;
                }
                currentNode = currentNode.NextNode;
            }

        }
        public Node FindNode(int searchValue) // ищет элемент по его значению
        {
            Node currentNode = Head;
            Node searchedNode = null;
                       
                while (currentNode != null)
                {
                    if (currentNode.Value == searchValue)
                    {
                    searchedNode = currentNode;
                    return searchedNode;                  
                    }
                    currentNode = currentNode.NextNode;                
                }
            return searchedNode;   
           
        }

        

        
    }
}
