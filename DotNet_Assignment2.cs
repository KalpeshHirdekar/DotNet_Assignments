//Q1>Accept two number from user and do the sum of it
//Solve above code using Parse(), ToSingle() and TryPrase() method.
//Also observe exception if you do not enter valid data

using Parse()
namespace StringTONumber
{
    internal class Demo
    {
        //Q1>Accept two number from user and do the sum of it
        static void Main(string[] args)
        { 
            Console.WriteLine("enter the no");
            String a=Console.ReadLine();
            String b=Console.ReadLine();
            int x = int.Parse(a);
           // Console.WriteLine(x);
            int y=int.Parse(b);
            //  Console.WriteLine(y);
            int r1 = x + y;
            Console.WriteLine($"result={r1}");//String interpolation
            Console.WriteLine("res={0}", r1);//place holder
        }
    }
}

using Convert
static void Main(string[] args)
{
    Console.WriteLine("enter the no");
    String a = Console.ReadLine();
    String b = Console.ReadLine();
    int x=Convert.ToInt32(a);
    int y=Convert.ToInt32(b);

    Console.WriteLine("res{0}", x + y)

};

using TryParse
 static void Main(string[] args)
 {
     Console.WriteLine("enter the no");
     String s=Console.ReadLine();
     String s2 = Console.ReadLine();
     int a;int b;
     bool c = int.TryParse(s, out a);
     bool d=int.TryParse(s2, out b);
     if(c==true&& d == true)
     {
         int e = a + b;
         Console.WriteLine("res:{0}", e);
     }
     else
     {
         Console.WriteLine("enter the vaild data");
     }

 }
------------------------------------------------------------------------------
Q2> Accept a float value and print square of that number
Solve above code using Parse(), ToSingle() and TryPrase() method.
Also observe exception if you do not enter valid data
using Parse()
namespace StringTONumber
{
    internal class Demo1
    {//Q2. Accept a float value and print square of that number


        static void Main(string[] args)
        {
            Console.WriteLine("enter the float number");
            String s = Console.ReadLine();
            float a = float.Parse(s);
            Console.WriteLine("sqr:"+a * a);


        }
    }
}

//using Convert
static void Main(string[] args)
{
    Console.WriteLine("enter the float number");
    String s=Console.ReadLine();
    float f=Convert.ToSingle(s);
    float ff = f * f;
    Console.WriteLine($"sqr:{ff}");
}

//using TryParse
 static void Main(string[] args)
 {
     Console.WriteLine("enter the float number");
     String s = Console.ReadLine();
     float x;
     bool b=float.TryParse(s, out x);
     Console.WriteLine(x*x+" "+b);
 }

------------------------------------------------------
Q3>Create a class calculator and write 3 instance method square, cube, round[if in put 22.5 o/p 22]
Which will return square .cube and rounded number.
Create object and call method and print the result.

          public static void Main()
        {
            
            Calculator cal = new Calculator();
            Console.WriteLine("enter the int num");
            String s = Console.ReadLine();
            float a;
            bool b = float.TryParse(s, out a);
          
            if (b == true)
            {
                Console.WriteLine("sqr:"+cal.square(a));
                Console.WriteLine("cube:"+cal.cube(a));
                Console.WriteLine("round:" + cal.round(a));

            }
            else{
                Console.WriteLine("enter the vaild data");
            }

        }
        public float square(float a)
        {
            return a * a;
        }
        public float cube(float a)
        {
            return a * a * a;

        }
        public int round(float a)
        {

            //return Convert.ToInt32(a);
            int b = (int)a;
            return b;
        }
        
}
}











