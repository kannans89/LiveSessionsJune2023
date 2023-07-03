namespace VirtualKeyWordApp
{
   abstract class Parent {

        public abstract void Bar();//must be overriden
        public virtual void Foo() {//can be overriden
            Console.WriteLine("10 lines of parent");
        }
    }

    class  Child : Parent {

      
        public override void Foo()
        {
            Console.WriteLine("2o lines of child");
        }
        public override void Bar()
        {
            Console.WriteLine("bar overrident in child");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parent p = new Child();
            //p.Foo();//Polymorphism

            //Object x;
            //x = 10;
            //x = "Hello";
            //x = new Parent();

        }
    }
}