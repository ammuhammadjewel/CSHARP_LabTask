namespace Is_a_relation
{
    internal class Human
    {
        public string name1 = "I am Human";
        virtual public void Method()
        {
            Console.WriteLine("Method from Human class");
        }
        public void AnotherMethod()
        {
            Console.WriteLine("Another method from Human class");
        }
    }
}