using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
     * Example of inheritance
     */
    internal class Q22
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(string.Format("A {0} has {1} tyres and {2} doors", car.GetType().Name, car.Tyre.ToString(), car.Door.ToString()));

            Lorry lorry = new Lorry();
            Console.WriteLine(string.Format("A {0} has {1} tyres and {2} doors", lorry.GetType().Name, lorry.Tyre.ToString(), lorry.Door.ToString()));

            Motorcycle motorcycle = new Motorcycle();
            Console.WriteLine(string.Format("A {0} has {1} tyres and {2} doors", motorcycle.GetType().Name, motorcycle.Tyre.ToString(), motorcycle.Door.ToString()));

            Console.ReadLine();
        }
    }

    public class Vehicle
    {
        private int m_Door;
        public int Door
        {
            get { return m_Door; }
            set { m_Door = value; }
        }

        private int m_Tyre;
        public int Tyre
        {
            get { return m_Tyre; }
            set { m_Tyre = value; }
        }
    }

    public class Lorry : Vehicle
    {
        public Lorry()
        {
            Door = 2;
            Tyre = 6;
        }
    }

    public class Car : Vehicle
    {
        public Car()
        {
            Door = 4;
            Tyre = 4;
        }
    }

    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            Door = 0;
            Tyre = 2;
        }
    }
}
