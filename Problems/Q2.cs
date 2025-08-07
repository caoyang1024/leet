using System;
using System.Collections.Generic;
using Problems.ADT;

namespace Problems;

public class Q2
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        Stack<int> s1 = new Stack<int>();
        Stack<int> s2 = new Stack<int>();

        while (l1 != null)
        {
            s1.Push(l1.val);
            l1 = l1.next;
        }

        while (l2 != null)
        {
            s2.Push(l2.val);
            l2 = l2.next;
        }

        ListNode node = new ListNode();
        int remaining = 0;
        while (s1.Count > 0 || s2.Count > 0)
        {
            ListNode currentNode = new ListNode();

            int top1 = s1.Count > 0 ? s1.Pop() : 0;
            int top2 = s2.Count > 0 ? s2.Pop() : 0;

            if (top1 + top2 + remaining >= 10)
            {
                currentNode.val = (top1 + top2 + remaining) % 10;
                remaining = 1;
            }
            else
            {
                currentNode.val = top1 + top2;
                remaining = 0;
            }
        }

        throw new NotImplementedException();
    }
}