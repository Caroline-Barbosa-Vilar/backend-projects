class TestVariable {
    public static void main (String[] args) {
        int age = 27;
        System.out.println(age);
    }
}
//random
class TestRandomNumber {
    public static void main (String[] args) {
        double randomNumber = Math.random() * 100;
        System.out.println(randomNumber);
    }
}
//strings
class TestString {
    public static void main (String[] args) {
        String name = "Caroline";
        System.out.println(name);
    }
}
//casting
class TestCasting {
    public static void main (String[] args) {
        long a = 2147483648L;
        int b = (int)a;
        System.out.println(a);
        System.out.println(b);
    }
}
//conversion
class TestConversion {
    public static void main (String[] args) {
        String s = "12.11";
        double d = Double.parseDouble(s);
        System.out.println(d);
    }
}
//