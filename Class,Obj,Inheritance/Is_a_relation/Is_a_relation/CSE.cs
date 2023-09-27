namespace Is_a_relation
{
    internal class CSE:Student
    {
        public string name3 = "I am CSE student";
        public override void Method()
        {
            Console.WriteLine("Method from CSE class");
            base.Method();
        }

    }
}