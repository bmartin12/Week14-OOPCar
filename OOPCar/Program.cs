using System;

namespace OOPCar
{
    class Program
    {
        class Car
        {
            string mark;
            string model;
            string reg;
            string color;
            int odometer;
            int fuel;

            public Car(string _mark, string _model, string _reg, string _color)
            {
                mark = _mark;
                model = _model;
                reg = _reg;
                color = _color;
                odometer = 0;
                fuel = 60;
                Console.WriteLine($"aye congratz you bought a {color} {mark} {model}");
            }
            public string Model
            {
                get { return model; }
            }
            public string Mark
            {
                get { return mark; }
            }
            public string Reg
            {
                get { return reg; }
            }
            public string Color
            {
                get { return color; }
            }
            public int Odo
            {
                get { return Odo; }
            }
            public int Fuel
            {
                get { return fuel; }
            }

            public void ShowCarInfo()
            {
                Console.WriteLine($"Mark:{mark}");
                Console.WriteLine($"Model:{model}");
                Console.WriteLine($"Registration:{reg}");
                Console.WriteLine($"Color:{color}");
                Console.WriteLine($"Odometer:{odometer}");
                Console.WriteLine($"Fuel:{fuel}L");
            }
            public void Drive()
            {
                odometer += 100;
                fuel -= 5;
                Console.WriteLine("vroom vroom");
            }
        }
        static void Main(string[] args)
        {
            Car myCar = new Car("Dodge", "Hellcat", "696KYS", "Black");
            while(myCar.Fuel > 0)
            {
                myCar.Drive();
            }
            myCar.ShowCarInfo();
        }
    }
}
