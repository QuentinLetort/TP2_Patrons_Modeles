namespace Sample
{
    public class C : B
    {
        private A[] tabA;
        public C() : base()
        {
            tabA = new A[] { new A(), new A() };
        }
    }
}