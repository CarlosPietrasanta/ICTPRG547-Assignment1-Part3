using System.Collections;
using System.Collections.Generic;

namespace Assignment1.DataStructures.SingleLinkedList
{
    public class SingleLinkedList<T> : ICollection<T>
    {
        public LinkedListNode<T> Head
        {
            get;
            private set;
        }

        public LinkedListNode<T> Tail
        {
            get;
            private set;
        }

        public int Count
        {
            get;
            private set;
        }

        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }

        public void AddFirst(LinkedListNode<T> node)
        {
            // Store the original Head to this temp variable
            LinkedListNode<T> temp = Head;
            // Set the linked list head to be the passed node
            Head = node;
            // Set the original Head (and hence the rest of the list) to be the Head's Next node
            Head.Next = temp;
            // Add 1 to count to keep track of the nodes quantity
            Count++;
            // If the list only has one item, Tail and Head should be the same node
            if (Count == 1)
            {
                Tail = Head;
            }
        }
        public void AddLast(T value)
        {
            AddLast(new LinkedListNode<T>(value));
        }

        public void AddLast(LinkedListNode<T> node)
        {
            // If there are no items in the list, Head and Tail should be the same
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                // Assign the current Tail next node to be the new passed node, that will be now the Tail
                Tail.Next = node;
            }
            // Make the new node the Tail
            Tail = node;
            Count++;
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                // Set Head to be the following item in the list, deleting the original Head
                Head = Head.Next;
                // Remove 1 from Count to keep track of nodes in the list
                Count--;
                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    // If there is single item in the link we can simply set both Head and Tail to null
                    Head = null;
                    Tail = null;
                }
                else
                {
                    // Start looking for the last node from Head
                    LinkedListNode<T> current = Head;

                    while (current.Next != Tail)
                    {
                        // Keep moving to Next node while current node's next isn't Tail
                        current = current.Next;
                    }

                    // Set penultimate node's next to null to delete the Tail
                    current.Next = null;
                    // Set Tail to be the current node now that the original Tail we deleted
                    Tail = current;
                }
            }
            Count--;
        }

        public void Add(T item)
        {
            AddFirst(item);
        }

        public bool Contains(T item)
        {
            // Start searching from the start/Head of the linked list
            LinkedListNode<T> current = Head;

            // While current isn't null (end of the list)...
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    // Return true if the item was found in the linked list
                    return true;
                }

                // Keep moving current to next node
                current = current.Next;
            }

            // If we get here, the linked list doesn't contain the item
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            // Start from  the beginning of the list/Head
            LinkedListNode<T> current = Head;

            // While we didn't reach the end of the list 
            while (current != null)
            {
                // Assign current node to specified arrayIndex in the array
                array[arrayIndex] = current.Value;
                // Move to next arrayIndex
                arrayIndex++;
                // Move to next Node in the linked list
                current = current.Next;
            }
        }
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = Head;

            while (current != null)
            {
                // If current matches the item we are looking for...
                if (current.Value.Equals(item))
                {
                    // If previous isn't null, we know current isn't the Head (it's in the middle or the end/Tail)
                    if (previous != null)
                    {
                        // Set previous node's next to be current node's next, as it will be deleted
                        previous.Next = current.Next;

                        // If deleted node had no Next node, we know it was the Tail
                        if (current.Next == null)
                        {
                            // Set the Tail to be previous node
                            Tail = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        // Knowing previous is null, we can assume current is the Head, so we can use RemoveFirst();
                        RemoveFirst();
                    }
                    // Return true as there was an item removed
                    return true;
                }
                // Update previous and current to keep searching through the linked list
                previous = current;
                current = current.Next;
            }
            // If we get here, there is no Node to be removed in the linked list, we return false
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            // Start from the Head/beginning of the linked list
            LinkedListNode<T> current = Head;
            // While current isn't null (we haven't reached end of the linked list)
            while (current != null)
            {
                // Yield current node to be used by the enumerator caller
                yield return current.Value;
                // Update current node to be the next node
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Clear()
        {
            // Reset Head and Tail to wipe all existing nodes
            Head = null;
            Tail = null;
            // Reset count to 0
            Count = 0;
        }
    }
}
