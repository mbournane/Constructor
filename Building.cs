using System;

namespace Constructors
{
    public class Building
    {
        private double _height;
        private int _floors;

        public Building(int floors)
        {
            _floors = floors;
            _height = floors * 3;
        }

        public Building(double height, int floors)
        {
            _height = height;
            _floors = floors;
        }

        public void SetFloors(int nbFloors)
        {
            _floors = nbFloors;
        }

        public int GetFloorCount ()
        {
            return _floors;
        }

        public double GetSize()
        {
           return (double)_height ;
        }

         public double GetHeight()
        {
           return  _height;
        }
        public double GetFloorMaxSize ()
        {
            return _height/_floors;
        }
        
    }
}
