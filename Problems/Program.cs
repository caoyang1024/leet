using System;

namespace Problems;

public class Program
{
    public static void Main(string[] args)
    {
        Q19 q = new();

        ListNode n5 = new ListNode(5, null);
        ListNode n4 = new ListNode(4, n5);
        ListNode n3 = new ListNode(3, n4);
        ListNode n2 = new ListNode(2, n3);
        ListNode n1 = new ListNode(1, n2);

        q.RemoveNthFromEnd(n5, 1);

        var r1 = n5;

        while (r1 != null)
        {
            Console.WriteLine(r1.val);
            r1 = r1.next;
        }
    }
}