using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_sols
{
    internal class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int Val = 0, ListNode Next = null)
            {
                val = Val;
                next = Next;
            }

        }
        static void Main(string[] args)
        {
            // list1 = [1, 2, 4], list2 = [1, 3, 4]
            ListNode list1 = new ListNode
            {
                val = 1,
                next = new ListNode
                {
                    val = 2,
                    next = new ListNode
                    {
                        val = 4,
                        next = new ListNode()

                    }
                }
            };

            ListNode list2 = new ListNode
            {
                val = 1,
                next = new ListNode
                {
                    val = 3,
                    next = new ListNode
                    {
                        val = 4,
                        next = new ListNode()

                    }
                }
            };
           
            ListNode head = null;
            while(list1 != null)
            {
                ListNode newNode = new ListNode();
                    newNode.val = list1.val;
                    //newNode.next = list1;
                    list1 = list1.next;
                    
                head = newNode;
                
            }
            while (head != null)
            {
                Console.Write(head.val);
                head = head.next;
            }


            Console.ReadLine();
        }
    }
}
