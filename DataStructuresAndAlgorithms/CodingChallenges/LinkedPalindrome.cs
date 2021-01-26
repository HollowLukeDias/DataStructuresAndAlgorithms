using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.CodingChallenges
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    class LinkedPalindrome
    {
        public bool IsPalindrome(ListNode head)
        {
            List<char> chars = new List<char>();
            while (head != null)
            {
                chars.Add((char)head.val);
                head = head.next;
            }
            for (int i = 0; i < chars.Count / 2; i++)
                if (chars[i] != chars[chars.Count - i - 1])
                    return false;

            return true;
        }
    }
}
