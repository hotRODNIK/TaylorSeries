// Author: Nick Eekhof
// Description: This class implements a doubly linked list, derived from
// the singly-linked list I created in the lab.

using System;
public class LinkedList
{
    // Head and tail references, list size
    private Node head, tail;
    private int listSize;

    // Creates a new node at the head of the list
    public void AddFront(SeriesTerm data)
    {
        // Provided the head of the list is non-existent, add something
        if (head == null)
        {
            // Write something to the head, and since we only have one element, the tail is the same as the head
            head = new Node();
            head.data = data;
            head.next = null;
            head.prev = null; // If we made previous point to the tail, we could make a circular linked-list
            tail = head;

            // Increment the list size
            listSize++;
        }
        else
        {
            // Create a new node to become the head
            Node toAdd = new Node();
            toAdd.data = data;
            toAdd.next = head;
            head = toAdd;
            head.next.prev = head; // We need to set the value of previous so that we don't have many null references bubble through the list

            // Create a node to become the new tail
            Node traverse = head;

            // Traverse the list until we find the tail
            while (traverse.next != null)
                traverse = traverse.next;
            tail = traverse;
            
            // Increment the list size
            listSize++;
        }
    }

    // Creates a new node at the tail of the list
    public void AddLast(SeriesTerm data)
    {
        // If we have a non-existent tail, create one
        if (head == null)
        {
            // Write something to the tail, and since we only have a single element, the head must be the same
            head = new Node();
            head.data = data;
            head.next = null;
            head.prev = null;
            tail = head;

            // Increment the list size
            listSize++;
        }
        else
        {
            // Create a new node which will become the tail
            Node toAdd = new Node();
            toAdd.data = data;
            toAdd.prev = tail;
            tail.next = toAdd;
            tail = toAdd;

            // Increment the list size
            listSize++;
        }
    }

    // Deletes the head node
    public void DeleteFirst()
    {
        // If the head of the list exists
        if (head != null)
        {
            // Find the head and delete
            Node toDelete = head.next;
            head.data = null;
            head.next = null;
            head.prev = null;
            head = toDelete;

            // Decrement the list size
            listSize--;
        }
        else
            Console.WriteLine("Nothing to delete... add some data first.");
    }

    // Deletes the tail node
    public void DeleteLast()
    {
        // If the tail exists
        if (tail != null)
        {
            // Find the tail of the list and delete values
            Node temp = tail.prev;
            tail.data = null;
            tail.next = null;
            tail.prev = null;
            tail = temp;

            // Decrement the list size
            listSize--;
        }
        else
            Console.WriteLine("Nothing to delete... add some data first.");
    }

    // Deletes all nodes
    public void DeleteAll()
    {
        // Keep running one of the delete functions until the list is completely gone
        for (int i = 0; i <= listSize; ++i)
            DeleteLast();

        // Delete nodes
        head = null;
        tail = null;

        // Reset the list size
        listSize = 0;
    }

    // Prints the list starting from the head
    public double Sum()
    {
        // Create a node to work with
        Node print = head;
        double sum = 0;

        // While the node exists, print
        while (print != null)
        {
            // Print off data, then get the next node to print off
            sum += ((print.data.num) / (print.data.denom)) * print.data.powTerm;
            print = print.next;
        }

        return sum;
    }
}