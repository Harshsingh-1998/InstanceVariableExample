using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVariableExample
{
    public class OneBHK
    {
        public int roomAreas;
        public int hallAreas;
        public float prices;
        public OneBHK()
        {
            roomAreas = 500;
            hallAreas = 1200;
            prices = 1800000;
        }

        public OneBHK(int roomArea, int hallArea, float price)
        {
            roomAreas = roomArea;
            hallAreas = hallArea;
            prices = price;
        }

        public virtual void Show()
        {
            Console.WriteLine("OneBHK information {0} {1} {2}", roomAreas,
                hallAreas, prices);
        }
    }

    public class TwoBHK : OneBHK
    {
        public int room2Area;

        public TwoBHK()
        {
            room2Area = 700;
        }
        public TwoBHK(int roomArea, int room2Areas, int hallArea, float price)
        {
            roomAreas = roomArea;
            hallAreas = hallArea;
            prices = price;
            room2Area = room2Areas;
        }

        public TwoBHK(int room2Areas)
        {
            room2Area = room2Areas;
        }

        public override void Show()
        {
            Console.WriteLine("One & Two BHK sized details are{0}{1}{2}{3}", room2Area, prices, hallAreas, roomAreas);
        }
    }

    class XYZ
    {
        static void Main(string[] args)
        {
            TwoBHK obj = new TwoBHK(600, 800, 1000, 2000000);
            obj.Show();
            Console.Read();
        }
    }
}

    
