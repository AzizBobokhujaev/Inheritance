using System.Net.Mime;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport trn = new Transport(1999, "Iron", "Black");
            trn.Info();
            Auto auto = new Auto(2021, "Aluminy", "Red", 240.00);
            auto.Info();
            Train train = new Train(1999, "Iron", "Brown", 5);
            train.Info();
            Airplane airplane = new Airplane(2020, "Aluminy", "White", 45.5);
            airplane.Info();
            Passenger passenger = new Passenger(2017, "Litiy", "Black", 55.5,"aaaa");
            passenger.Info();
            Truck truck = new Truck(2001, "Med", "Red", 543.2, 4);
            truck.Info();
            PassengerPlane passengerPlane = new PassengerPlane(2009, "ter", "Black1", 34.4, 500);
            passengerPlane.Info();
            CargoPlane cargoPlane = new CargoPlane(2011, "rrr", "white", 34.4, 10000);
            cargoPlane.Info();

        }

    }
    public class Transport
    {
        public int Year { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public Transport() { }
        public Transport(int year, string material, string color)
        {
            Year = year;
            Material = material;
            Color = color;
        }
        public void Info()
        {
            Console.WriteLine("Transport");
            Console.WriteLine($"Year: {Year}\n" +
                              $"Material: {Material}\n" +
                              $"Color: {Color}\n");
        }
    }
    public class Auto : Transport
    {
        public double Speed { get; set; }
        public Auto() { }
        public Auto(int year, string material, string color, double speed) : base(year, material, color)
        {
            Speed = speed;
        }
        public void Info()
        {
            Console.WriteLine("Auto");
            Console.WriteLine($"Year: {Year}\n" +
                              $"Material: {Material}\n" +
                              $"Color: {Color}");
            Console.WriteLine($"Speed: {Speed}\n");
        }

    }
    public class Train : Transport
    {
        public int Сarriages { get; set; }
        public Train() { }
        public Train(int year, string material, string color, int carriages) : base(year, material, color)
        {
            Сarriages = carriages;
        }

        public void Info()
        {
            Console.WriteLine("Train");
            Console.WriteLine($"Year: {Year}\n" +
                              $"Material: {Material}\n" +
                              $"Color: {Color}");
            Console.WriteLine($"Сarriages: {Сarriages}\n");
        }
    }
    public class Airplane : Transport
    {
        public double WingLength { get; set; }
        public Airplane() { }
        public Airplane(int year, string material, string color, double winglength) : base(year, material, color)
        {
            WingLength = winglength;
        }

        public void Info()
        {
            Console.WriteLine("Airplane");
            Console.WriteLine($"Year: {Year}\n" +
                              $"Material: {Material}\n" +
                              $"Color: {Color}");
            Console.WriteLine($"WingLength: {WingLength}\n");
        }

    }
    public class Passenger : Auto
    {
        public string PassengerType { get; set; }
        public Passenger() { }
        public Passenger(int year, string material, string color, double speed, string passengerType) : base(year, material, color, speed)
        {
            PassengerType = passengerType;
        }

        public void Info()
        {
            Console.WriteLine("Passenger Car");
            Console.WriteLine($"Year: {Year}\n" +
                              $"Material: {Material}\n" +
                              $"Color: {Color}\n" +
                              $"Speed: {Speed:0.00}");
            Console.WriteLine($"PassengerType: {PassengerType}\n");
        }
    }
    public class Truck : Auto
    {
        public string BodyLength { get; set; }
        public Truck() { }
        public Truck(int year, string material, string color, double speed, int bodyLength) : base(year, material, color, speed)
        {
            BodyLength = BodyLength;
        }

        public void Info()
        {
            Console.WriteLine("Truck");
            Console.WriteLine($"Year: {Year}\n" +
                              $"Material: {Material}\n" +
                              $"Color: {Color}\n" +
                              $"Speed: {Speed:0.00}");
            Console.WriteLine($"BodyLength: {BodyLength}\n");
        }
    }
    public class PassengerPlane : Airplane
    {
        public int Seats { get; set; }

        public PassengerPlane(int year, string material, string color, double wingLength, int seats) : base(year, material, color, wingLength)
        {
            Seats = seats;
        }

        public void Info()
        {
            Console.WriteLine("PassengerPlane");
            Console.WriteLine($"Year: {Year}\n" +
                              $"Material: {Material}\n" +
                              $"Color: {Color}\n" +
                              $"WingLength: {WingLength:0.00}");
            Console.WriteLine($"Seats: {Seats}\n");
        }
    }
    public class CargoPlane : Airplane
    {
        public double Capacity { get; set; }
        public CargoPlane() { }
        public CargoPlane(int year, string material, string color, double wingLength, double capacity) : base(year, material, color, wingLength)
        {
            Capacity = capacity;
        }

        public void Info()
        {
            Console.WriteLine("CargoPlane");
            Console.WriteLine($"Year: {Year}\n" +
                              $"Material: {Material}\n" +
                              $"Color: {Color}\n" +
                              $"WingLength: {WingLength:0.00}");
            Console.WriteLine($"Capacity: {Capacity:0.00}\n");
        }

    }
}

