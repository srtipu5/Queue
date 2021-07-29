using System;

namespace Queue
{
    class Program
    {
        public class Queue<T>
        {
            public int Count { get;private set; }
            readonly int Queue_Length = 100;
            int front;
            int rear;
            T[] arr;
            public Queue()
            {
                Count = 0;
                front = -1;
                rear = -1;
                arr = new T[Queue_Length];
            }

            public void Enqueue(T value)
            {
                if(rear == Queue_Length-1)
                {
                    Console.WriteLine("Queue is full.");
                    return;
                }
               else
                {
                    if (rear == -1)
                    {
                        arr[++rear] = value;
                        front++;
                        Count = rear - front + 1;
                        return;
                    }
                    else
                    {
                        arr[++rear] = value;
                        Count = rear - front + 1;
                        return;
                    }
                }

            }

            public T Dequeue()
            {
                if(front == -1)
                {
                    Console.WriteLine("Queue is empty.");
                    return default(T);
                }
                
                else if(front == rear)
                {
                    T temp1 = arr[front];
                    front = rear = -1;
                    Count = 0;
                    return temp1;
                }
                T temp = arr[front];
                front++;
                Count = rear - front + 1;
                return temp;
            }
            public T Peek()
            {
                if (front == -1)
                {
                    Console.WriteLine("Queue is empty.");
                    return default(T);
                }

                T temp = arr[front];
                return temp;
            }
            public void Clear()
            {
                rear = front = -1;
                Count = 0;
            }
            public bool IsEmpty()
            {
                if(rear == -1)
                {
                    return true;
                }

                return false;
            }
            public bool Contains(T value)
            {
                for(int i = front; i<=rear;i++)
                {
                    if(arr[i].Equals(value))
                    {
                        return true;
                    }
                }
                return false;
            }
            public void Print()
            {
                if(rear == -1)
                {
                    Console.WriteLine("Queue is empty.");
                    return;
                }
                Console.WriteLine("Queue items are : ");
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }

        }
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(10);       
            Console.WriteLine(myQueue.Count);
            myQueue.Print();
            Console.ReadKey();
        }
    }
}
