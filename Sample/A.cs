using System.Collections.Generic;
namespace Sample
{
    public class A
    {
        private double val;
        private string[] tabStr;
        public Queue<string> queueStr;
        public A()
        {
            val = 7.9;
            tabStr = new string[] { "abc", "def", "ghi" };
            queueStr = new Queue<string>();
            queueStr.Enqueue("Hello");
            queueStr.Enqueue("World");
            queueStr.Enqueue("!");
        }

    }
}