namespace Sample
{
    public class B
    {
        public int val;
        private string str;
        private A obj;
        private int[] tabInt;
        private A[] tabObj;



        public B()
        {
            val = 5;
            str = "fzrre";
            obj = new A();
            tabInt = new int[] { 1, 2, 5 };
            tabObj = new A[] {obj};
        }
    }
}