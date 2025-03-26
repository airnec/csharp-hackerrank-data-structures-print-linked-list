using PrintLinkedList;

SinglyLinkedListNode head = new SinglyLinkedListNode(10);
SinglyLinkedListNode node2 = new SinglyLinkedListNode(20);
SinglyLinkedListNode node3 = new SinglyLinkedListNode(30);

head.Next = node2;
head.Next.Next = node3;

PrintLinkedList.Result.PrintLinkedList(head);

namespace PrintLinkedList
{
    public class SinglyLinkedListNode
    {
        public int Data { get; set; }
        public SinglyLinkedListNode? Next { get; set; }

        public SinglyLinkedListNode(int nodeData)
        {
            this.Data = nodeData;
            this.Next = null;
        }
    }

    public static class Result
    {
        public static void PrintLinkedList(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode? current = head;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}

