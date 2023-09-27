namespace Is_a_relation
{
    internal class Student:Human
    {
        public string name2 = "I am Student";
        override public void Method()
        {
            Console.WriteLine("Method from Student class");
        }
        public void CallHuman()
        {
            base.Method();
        }
    }
}