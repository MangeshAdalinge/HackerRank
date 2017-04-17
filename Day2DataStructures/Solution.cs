using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDaysChallengeHackerRank
{
    class Solution
    {
        public static Node insert(Node head, int data)
        {
            //Complete this method
            if (head == null)
            {
                Node element = new Node(data);
                return element;
            }
            else
            {
                Node currentElement = head;
                Node newElement = new Node(data);
                while (currentElement == null)
                {
                    currentElement = currentElement.next;
                }
                currentElement.next = newElement;
                newElement.next = null;
                return newElement;
            }

        }
    }
}
