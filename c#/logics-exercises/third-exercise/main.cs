class TestVariable {
    static void Main() {
        int age = 27;
        System.Console.WriteLine(age);
    }
}
//random
class TestRandomNumber {
    static void Main() {
        System.Random generator = new System.Random();
        double randomNumber = generator.NextDouble() * 100;
        System.Console.WriteLine(randomNumber); 
    }
}
//strings
class TestString {
    static void Main() {
        string name = "Caroline";
        System.Console.WriteLine(name);
    }
}
//formatting
class TestFormatting {
    static void Main() {
        string name = "Caroline";
        int age = 27;
        double weight = 60.10;
        System.Console.WriteLine("{0} is {1} years old and weighs {2:F2} kg", name, age, weight);
    }
}
//casting
class TestCasting {
    static void Main() {
        long a = 2147483648L;
        int b = (int)a;
        System.Console.WriteLine(a);
        System.Console.WriteLine(b);
    }
}
//conversion
class TestConversion {
    static void Main() {
        string s = "19.09";
        double d = System.Convert.ToDouble(s);
        System.Console.WriteLine(d);
    }
}