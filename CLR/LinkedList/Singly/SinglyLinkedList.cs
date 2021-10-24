using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Singly
{
    class ObjectCell
    {
        public object Value;
        public ObjectCell Next;

        public ObjectCell(object value)
        {
            this.Value = value;
        }
    }


    class SinglyLinkedListIterator
    {
        public void Iterate(ObjectCell top)
        {
            while (top != null)
            {
                Console.WriteLine(top.Value);
                top = top.Next;
            }
            Console.WriteLine("End of list\n");
        }
    }

    class SinglyLinkedList
    {
        public ObjectCell Top;

        public SinglyLinkedList()
        {
            Top = new ObjectCell(null);
            Top.Next = null;
        }

        public void AddAtBeginning(ObjectCell newCell)
        {
            newCell.Next = Top.Next;
            Top.Next = newCell;
        }
        public void AddAtEnd(ObjectCell newCell)
        {
            while (Top.Next != null)
            {
                Top = Top.Next;
            }
            Top.Next = newCell;
            newCell.Next = null;
        }
        public ObjectCell FindCell(object value)
        {
            ObjectCell top = Top;
            while (top != null)
            {
                if (top.Value == value) return top;
                top = top.Next;
            }
            return null;
        }
        public void InsertCell(ObjectCell afterCell, ObjectCell newCell)
        {
            newCell.Next = afterCell.Next;
            afterCell.Next = newCell;
        }
        public void DeleteAfter(ObjectCell afterCell)
        {
            afterCell.Next = afterCell.Next.Next;
        }
    }

    class SinglyLinkedListExample
    {
        public SinglyLinkedListExample()
        {
            var singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddAtEnd(new ObjectCell("some value"));
            singlyLinkedList.AddAtEnd(new ObjectCell("some value1"));
            singlyLinkedList.AddAtBeginning(new ObjectCell("some Valeu 2"));

            var iterator = new SinglyLinkedListIterator();
            iterator.Iterate(singlyLinkedList.Top);

            ObjectCell foundCell = singlyLinkedList.FindCell("some value"); //O(N)

            singlyLinkedList.InsertCell(foundCell, new ObjectCell("Inser value"));  //O(1)
            iterator.Iterate(singlyLinkedList.Top);

            singlyLinkedList.DeleteAfter(foundCell.Next);
            iterator.Iterate(singlyLinkedList.Top);



        }
    }
}
