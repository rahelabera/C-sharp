namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            Variables();
            TypeConversion();

        }  
        static void SayHello()
        {
            Console.WriteLine("Hello, World!");
            Console.Beep();
        }   
        static void Variables()
        {
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A'; 
            var firstName = "Jhon";
            var isWorking = false;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            const float Pi = 3.14f;
            Console.WriteLine(Pi);
        }
        static void TypeConversion()
        {
            byte b = 1;
            int i = b; // implicit conversion
            Console.WriteLine(i);

            int i2 = 1;
            byte b2 = (byte)i2; // explicit conversion
            Console.WriteLine(b2);

            string str = "1234";
            int i3 = Convert.ToInt32(str); // conversion using Convert class
            Console.WriteLine(i3);

            try
            {
                string str2 = "1234abc";
                int i4 = int.Parse(str2); // conversion using Parse method
                Console.WriteLine(i4);
            }
            catch (FormatException)
            {
                Console.WriteLine("The string is not in a correct format.");
            } 
        }

        static void Operators()
        {
            int a = 10;
            int b = 3;
            int c = 4;

            Console.WriteLine(a + b); // Addition
            Console.WriteLine(a - b); // Subtraction
            Console.WriteLine(a * b); // Multiplication
            Console.WriteLine(a / b); // Division
            Console.WriteLine((float)a / (float)b); // Division with float result
            Console.WriteLine(a % b); // Modulus

            a++; // Increment
            Console.WriteLine(a);
            b--; // Decrement
            Console.WriteLine(b); 
            Console.WriteLine(a+ b * c); // Operator precedence
            Console.WriteLine(a > b && a > c); // Logical AND
            Console.WriteLine(a > b || a < c); // Logical OR
            Console.WriteLine(!(a > b)); // Logical NOT
            Console.WriteLine(a == b); // Equality
            Console.WriteLine(a != b); // Inequality
        }
    }     
}