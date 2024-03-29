﻿public class Program
{
    public static void Main(string[] args)
    {
        Complex a = new Complex() { Re = 3d, Im = 2d };
        double factor = 5.0d;
        int points = 0;
        if ((a * factor).Re == 15 && (a * factor).Im == 10 && (factor * a).Re == 15 && (factor * a).Im == 10
            && (5 * new Complex() { Re = 1, Im = -5 }).Im == -25)
        {
            Console.WriteLine("Zadanie 1: Ok");
            points++;
        }
        if (new Complex() { Re = 1, Im = 2 } == new Complex() { Re = 1, Im = 2 } &&
            !(new Complex() { Re = 1, Im = 2 } == new Complex() { Re = 1, Im = 3 }))
        {
            Console.WriteLine(("Zadanie 2: Ok"));
            points++;
        }

        if (new Complex() { Re = 1, Im = 2 }.Equals(new Complex() { Re = 1, Im = 2 }) &&
            !new Complex() { Re = 1, Im = 2 }.Equals(new Complex() { Re = 1, Im = 3 }))
        {
            Console.WriteLine(("Zadanie 3: Ok"));
            points++;
        }

        List<Complex> list = new List<Complex>()
        {
            new Complex() {Re = -1, Im = 1},
            new Complex() {Re = 2, Im = -2},
            new Complex() {Re = 3, Im = -3},
            new Complex() {Re = -4, Im = 4},
            new Complex() {Re = -1, Im = 0},
            new Complex() {Re = 0, Im = 2},
        };
        Task4(list);
        if (list[0] == new Complex() { Re = -1, Im = 0 } && list[1] == new Complex() { Re = -1, Im = 1 } &&
            list[5] == new Complex() { Re = -4, Im = 4 })
        {
            Console.WriteLine(("Zadanie 4: Ok"));
            points++;
        }
        var result1 = Task5(list).ToList();
        var result2 = Task5(Enumerable.Repeat<Complex>(new Complex() { Re = 3, Im = 4 }, 2)).ToList();
        if (result1.Count == 2 && result1.Contains(2.8284271247461903) && result1.Contains(4.242640687119285)
            && result2.Count == 2 && result2.Contains(5))
        {
            Console.WriteLine(("Zadanie 5: Ok"));
            points++;
        }
        Console.WriteLine($"Suma punktów: {points}");
    }

    internal class Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public double Module()
        {
            return Math.Sqrt(Math.Pow(Re, 2) + Math.Pow(Im, 2));
        }
        //Zadanie 1
        //zdefiniuj operatory mnożenia liczby zespolonej przez wartość rzeczywistą typu double
        //Przykład
        //Complex result = new Complex(){ Re = 1, Im = 2} * 2d;
        //Console.WriteLine(result);        // {Re = 2.0000, Im = 4.0000}

        public static Complex operator *(Complex a, double b)
        {
            return new Complex() { Re = a.Re * b, Im = a.Im * b };
        }

        public static Complex operator *(double b, Complex a)
        {
            return new Complex() { Re = a.Re * b, Im = a.Im * b };
        }
        //Zadanie 2
        //Zdefiniuj operatory porównania dla klasy Complex
        //Przykłady
        //bool IsEqual = new Complex(){Re = 1, Im = 2} == new Complex(){Re = 1, Im = 2}; //true
        //bool IsEqual = new Complex(){Re = 1, Im = 2} == new Complex(){Re = 2, Im = 2}; //false

        public static bool operator !=(Complex a, Complex b)
        {
            return a.Re != b.Re || a.Im != b.Im;
        }
        public static bool operator ==(Complex a, Complex b)
        {
            return a.Re == b.Re && a.Im == b.Im;
        }
        //Zadanie 3
        //Zdefiniuj metodę ToString(), GetHashCode i Equals. Dwa liczby są sobie równe jeśli odpowiednio ich pola Re i Im są sobie równe
        //Przykład
        //Console.Write(new Complex(){Re = 1, Im = 2}); //{ Re= 1.000000, Im = 2.00000}
        //new Complex(){Re = 1, Im = 2}.Equals(new Complex(){Re = 1, Im = 2});  //true
        //new Complex(){Re = 1, Im = 2}.Equals(new Complex(){Re = 2, Im = 2});  //false

        public override string ToString()
        {
            return $"{Re} + {Im}i";
        }

        public override int GetHashCode()
        {
            return Re.GetHashCode() ^ Im.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (obj.GetType() != GetType()) return false;
            return this == (Complex)obj;
        }
    }
    //Zadanie 4
    //Zaimplementuj metodę, aby sortowała listę liczb zespolonowych w porządku rosnących modułów 
    //Przykład
    //
    static void Task4(List<Complex> list)
    {
        list.Sort((a, b) => a.Module().CompareTo(b.Module()));
    }

    //Zadanie 5
    //Zaimplementuj metodę, aby zwróciła IEnumerable modułów tych liczb, które mają dodatnie części rzeczywiste
    static IEnumerable<double> Task5(IEnumerable<Complex> list)
    {
        return list.Where(a => a.Re > 0).Select(a => a.Module());
    }

}