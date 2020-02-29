using System.Collections.Generic;
namespace Sample
{
    public class A
    {
        private double val;
        public Queue<string> queueStr;
        public A()
        {
            val = 7.9;
            queueStr = new Queue<string>();
            queueStr.Enqueue("Hello");
            queueStr.Enqueue("World");
            queueStr.Enqueue("!");
        }

    }
}