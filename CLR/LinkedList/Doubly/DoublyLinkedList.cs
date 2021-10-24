using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Doubly
{
    public class ObjectCell
    {
        public object Value;
        public ObjectCell Next;
        public ObjectCell Previous;

        public ObjectCell(object value)
        {
            Value = value;
        }
    }

    public class DoublyLinkedList
    {
        public ObjectCell Top;
        public ObjectCell End;

        public DoublyLinkedList()
        {
            Top = new ObjectCell(null);            
            End = new ObjectCell(null);

            End.Next = null;
            End.Previous = Top;
            Top.Next = End;
            Top.Previous = null;
        }

        public void AddCellAtStart(ObjectCell newCell)
        {
            InsertCell(Top, newCell);
        }
        public void AddCellAtEnd(ObjectCell newCell)
        {
            InsertCell(End.Previous, newCell);
        }

        public void InsertCell(ObjectCell afterCell, ObjectCell newCell)
        {
            newCell.Next = afterCell.Next;
            afterCell.Next = newCell;

            newCell.Next.Previous = newCell;
            newCell.Previous = afterCell;
        }

        public void IterateFromTop()
        {
            ObjectCell top = Top;
            while (top != null)
            {
                Console.WriteLine(top.Value);
                top = top.Next;
            }
        }
        public void IterateFromEnd()
        {
            ObjectCell end = End;

            while (end != null)
            {
                Console.WriteLine(end.Value);
                end = end.Previous;
            }
        }
    }

    public class DoublyLinkedListExample
    {
        public DoublyLinkedListExample()
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            doublyLinkedList.AddCellAtStart(new ObjectCell("Some new value"));
            doublyLinkedList.AddCellAtStart(new ObjectCell("Another new value"));
            doublyLinkedList.AddCellAtEnd(new ObjectCell("and one more value"));

            doublyLinkedList.IterateFromTop();
        }
    }
}
