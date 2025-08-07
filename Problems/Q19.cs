using System.Collections.Generic;
using Problems.ADT;

namespace Problems;

public class Q19
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head.next == null) return null;

        int layer = 1;

        ListNode r = head;

        Dictionary<int, ListNode> nodes = [];

        while (r != null)
        {
            nodes[layer] = r;
            layer++;
            r = r.next;
        }

        if (nodes.Count == n)
        {
            return nodes[2];
        }

        nodes[nodes.Count - n].next = nodes.Count - n + 2 > nodes.Count ? null : nodes[nodes.Count - n + 2];

        return head;
    }
}