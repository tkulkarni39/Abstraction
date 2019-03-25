//In this program, I am going to implement two concepts - abstract class and interface
/* Abstract class can accomodate abstract functions
 *  Abstract class can have function definitions also 
 * We can't create object for abstract class  */

/*If you want to use only function declarations, then you can use interface 
 * If some function inherits interface then it has to define all the functions which are declared in interface*/


using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
           // var abs = new Abstra();  //Abstract classes can't be instantiated

            var derived1 = new Derived();
            derived1.Abs1();
            derived1.Abs2();

            ICal1 add = new Derived();
            Console.WriteLine(add.Sum(20, 20));


            Console.WriteLine(derived1.Sum(20, 10));

            Console.WriteLine(derived1.Sub(20, 10));

            Console.WriteLine(derived1.Mul(20, 10));

            Console.WriteLine(derived1.Div(20, 10));
        }
    }
    public interface ICal1
    {
        int Sum(int num1, int num2);       
    }

    public interface ICal2
    {
       
        int Sub(int num1, int num2);
    }

    public interface ICal3
    {
        int Mul(int num1, int num2);
    }

    public interface ICal4
    {
        int Div(int num1, int num2);
    }
  
    public abstract class Abstra
    {
        public abstract void Abs1();

        public void Abs2()
        {
            Console.WriteLine("This is another abstract class function");
        }
    }


    internal class Derived : Abstra, ICal1, ICal2, ICal3, ICal4 
    {
        public Derived()
        {
        }

        public override void Abs1()
        {
            Console.WriteLine("This is an abstract class function");
        }

        public int Sum(int no1, int no2)
        {
            int res = no1 + no2;

            return res;
        }

        public int Sub(int no1, int no2)
        {
            int res = no1 - no2;

            return res;
        }

        public int Mul(int no1, int no2)
        {
            int res = no1 * no2;

            return res;
        }

        public int Div(int no1, int no2)
        {
            int res = no1 / no2;

            return res;
        }
    }
}
