using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace COLA_ESTRUCTURA
{
    internal class Program
    {
        class Queue
        {
            private int[] elements;
            private int size;
            private int front;
            private int rear;

            public Queue(int queueSize)
            {
                this.size = queueSize;
                this.elements = new int[queueSize];
                this.front = -1;
                this.rear = -1;
            }

            public bool Enqueue(int element)
            {
                if (rear == size - 1)
                {
                    return false;
                }

                if (front == -1)
                {
                    front = 0;
                }

                rear++;
                elements[rear] = element;
                Console.WriteLine($"Added: {element}");
                return true;
            }

            public bool Dequeue(out int element)
            {
                if (front == -1)
                {
                    element = -1;
                    return false;
                }

                element = elements[front];
                front++;
                
                if (front > rear)
                {
                    front = rear = -1;
                }

                return true;
            }

            public bool DisplayQueue()
            {
                if (front == -1)
                {
                    // The queue is empty
                    return false;
                }

                for (int i = front; i <= rear; i++)
                {
                    Console.Write(elements[i] + " ");
                }
                Console.WriteLine();

                // The queue is not empty
                return true;
            }


        }


        static void Main(string[] args)
        {
            Queue queue = new Queue(5);

            // Add elements to the queue
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // Display the queue
            Console.WriteLine("Queue:");
            queue.DisplayQueue();

            // Remove elements from the queue
            int removedElement;
            bool dequeueResult = queue.Dequeue(out removedElement);

            // Display the queue after removing an element
            Console.WriteLine("Queue after removing an element:");
            queue.DisplayQueue();

            Console.ReadKey();
        }
    }

    
}

