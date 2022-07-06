using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Map
    {
        private IRouteStrategy routeStrategy;
        public Map(IRouteStrategy routeStrategy)
        {
            this.routeStrategy = routeStrategy;
        }

        public void CreateRoute(Coordinate start, Coordinate end)
        {
            routeStrategy.CreateRoute(start, end);
        }
    }
}
