﻿using System;

namespace Linked.List
{
	class Node
	{
		public int data;
		public Node next;
		public Node(int d)
		{
			data = d;
			next = null;
		}

	}
	class Solution
	{

		public static Node insert(Node head, int data)
		{

			
			if (head==null)
            {

				return new Node(data);
			}
            else
            {

				var dd=head;
                while (dd.next!=null)
                {
					dd = dd.next;
				}
				dd.next = new Node(data);
				return head;
			}
			
		}

		public static void display(Node head)
		{
			Node start = head;
			while (start != null)
			{
				Console.Write(start.data + " ");
				start = start.next;
				
			}
		}
		static void Main(String[] args)
		{

			Node head = null;
			int T = Int32.Parse(Console.ReadLine());
			while (T-- > 0)
			{
				int data = Int32.Parse(Console.ReadLine());
				head = insert(head, data);
			}
			display(head);
		}
	}

}
