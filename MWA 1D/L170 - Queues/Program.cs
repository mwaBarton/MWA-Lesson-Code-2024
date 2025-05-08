using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L170___Queues
{
    public interface IQueue
    {
        int Dequeue();
        void Enqueue(int item);
        bool IsEmpty();
        bool IsFull();
    }

    public class IntQueue : IQueue
    {
        private int rear = -1, front = 0;
        private int[] Q = new int[10];

        public int Dequeue()
        {
            if (IsEmpty()) throw new Exception("Queue was empty");
            front++;
            return Q[front - 1];
        }
        public void Enqueue(int item)
        {
            if (IsFull()) throw new Exception("Queue was full.");
            rear++;
            Q[rear] = item;
        }
        public bool IsEmpty()
        {
            return front > rear;
        }
        public bool IsFull()
        {
            return rear == Q.Length - 1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
