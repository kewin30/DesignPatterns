using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BikeStrategy Strategy = new BikeStrategy();
            CarStrategy Strategy = new CarStrategy();

            Map map = new Map(Strategy);

            Coordinate start = new Coordinate();
            Coordinate end = new Coordinate();
            map.CreateRoute(start, end);
        }
    }
}
