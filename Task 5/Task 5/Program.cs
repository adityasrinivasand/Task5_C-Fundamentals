using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {  
            /* Statements */ 
            var st = new Statements();
            Console.WriteLine("Statements O/P");
            st.messages();

            /* Class */
            Console.WriteLine("Classes O/P");
            CustomClass custClass = new CustomClass();
            custClass.Number = 27;
            int result = custClass.Multiply(4);
            Console.WriteLine($"The result is {result}.");
            Console.ReadLine();

            /* Constructors*/
            Console.WriteLine("Constructors O/P");
            Constructor1 construct = new Constructor1();
            construct.Number = 30;
            int result1 = construct.Multiply(4);
            Console.WriteLine($"The result is {result1}.");
            Console.ReadLine();

            /* Data Types*/
            Data d = new Data();
            Console.WriteLine("Data Types O/P");
            d.disdata();
            Console.ReadLine();

            /* Operators*/
            Operators op = new Operators();

            Console.WriteLine("Operators O/P");
            Console.WriteLine("1) Arithmetic Function ");
            op.arithmetic();
            Console.ReadLine();

            Console.WriteLine("2) Relational Function ");
            op.relational();
            Console.ReadLine();

            Console.WriteLine("3) Logical Function ");
            op.logical();
            Console.ReadLine();

            /* Conditional Statements*/
            Conditional cd = new Conditional();

            Console.WriteLine("Conditional Statements O/P");
            Console.WriteLine("1) IF and Nested IF Function ");
            cd.ifandnested();
            Console.ReadLine();

            Console.WriteLine("2) Switch Case ");
            cd.switchcase();
            Console.ReadLine();

            /* Looping Statements*/
            Loop lp = new Loop();

            Console.WriteLine("Looping Statements O/P");
            Console.WriteLine("1) For Loop ");
            lp.forloop();
            Console.ReadLine();

            Console.WriteLine("2) While Loop ");
            lp.whileloop();
            Console.ReadLine();

            Console.WriteLine("3) DoWhile Loop ");
            lp.dowhileloop();
            Console.ReadLine();

            /* Inheritance */
            Cube cu = new Cube();

            Console.WriteLine("Inheritance O/P");
            cu.setside(5);
            Console.WriteLine($"Total area: {cu.getArea()}" );
            Console.WriteLine($"Total Volume of Cube: {cu.getVolume()}");
            Console.ReadLine();

            /* Polymorphism */
            Polymorphism po = new Polymorphism();

            Console.WriteLine("Polymorphism O/P");
            po.print(5);
            po.print(500.263);
            po.print("Hello World!");
            Console.ReadLine();

            /* Encapsulation */
            Encapsulation en = new Encapsulation("Marvin", 456, 30_000);

            Console.WriteLine("Encapsulation O/P");
            // en.empName = "Marv"; Error because the Employee name is in private inside a class which is encapsuled.
            en.GiveBonus(1000);
            en.DisplayStats();
            Console.ReadLine();

            /* Properties */
            Console.WriteLine("Properties O/P");
            Properties pro = new Properties();

            pro.Name = "Aditya";
            pro.Age = 22;
            Console.WriteLine("Student Info: {0}", pro);
            Console.ReadLine();

            /* Operator Overloading*/
            Console.WriteLine("Operator OverLoading O/P");
            Operator op1 = new Operator();
            Operator op2 = new Operator();
            Operator op3 = new Operator();
            double total = 0.0;

            op1.Setmaths(45.0);
            op1.Setscience(50);

            op2.Setmaths(50);
            op2.Setscience(45);

            total = op1.Gettotalmarks();
            Console.WriteLine($"Total of Student 1 : {total}");

            total = op2.Gettotalmarks();
            Console.WriteLine($"Total of Student 2: {total}");
 
            op3 = op1 + op2;// Add two object as follows:

            total = op3.Gettotalmarks();
            Console.WriteLine($"Total of Student1 and Student2 : {total}");
            Console.ReadLine();

            /* Type Conversion */
            Console.WriteLine("Type Conversion O/P");
            Console.WriteLine("1) Implicit Type Conversion O/P");
            ImplicitConversion ic = new ImplicitConversion();
            ic.displayic();
            Console.ReadLine();

            Console.WriteLine("2) Explicit Type Conversion O/P");
            ExplicitConversion ec = new ExplicitConversion();
            ec.display();
            Console.ReadLine();

            /* Overriding */
            Console.WriteLine("Overriding O/P");
            Overridingbase obj = new Overridingbase();
            obj.show();
            obj = new Overridingderived();
            obj.show();
            Console.ReadLine();

            /* Exceptional Handling */
            Console.WriteLine("Exceptional Handling O/P");
            ExceptionalHandling ex = new ExceptionalHandling();
            ex.division();
            Console.ReadLine();

            /* Base and Derived Class */
            Console.WriteLine("Base and Derived O/P");
            Derived de = new Derived();
            de.readers("Aditya", "Maths");
            Console.ReadLine();

            /* Static and Non Static*/
            Console.WriteLine("Static and Non Static O/P");
            Console.WriteLine("1)Static");
            Static.total();

            Console.WriteLine("2)Non-Static");
            Static ns = new Static();
            ns.mathsmarks();
            Console.ReadLine();

            /* Error Handling */
            ErrorHandling eh = new ErrorHandling();
            eh.display();
            Console.ReadLine();
        }
    }
}
