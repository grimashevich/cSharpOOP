using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpOOP
{
    public class Building
    {
        private static uint _buildingNumber = 1;
        private double _height;
        private uint _floorsCount;
        private uint _flatsCount;
        private uint _frontDoorsCount;
        public uint Number { get; }
        public double Height {get {return this._height;} set {this._height = value; }}
        public uint FloorsCount { get { return _floorsCount; } set { if (value > 0) { _floorsCount = value; } } }
        public uint FlatsCount { get { return _flatsCount; } set { if (value > 0) { _flatsCount = value; } } }
        public uint EntranceCount { get { return _frontDoorsCount; }
            set { if (value > 0) { _frontDoorsCount = value; } } }

        public Building(double height, uint floorsCount, uint flatsCount, uint frontDoorsCount)
        {
            Number = _buildingNumber++;
            Height = height;
            FloorsCount = floorsCount;
            FlatsCount = flatsCount;
            EntranceCount = frontDoorsCount;
        }

        public override string ToString()
        {
            string result;
            result = "Номер дома: " + Number + "\nВысота: " + Height + "\n";
            result += "Кол-во этажей: " + FloorsCount + "\nКол-во квартир: " + FlatsCount + "\n";
            result += "Кол-во подъездов: " + EntranceCount;
            return result;
        }

        public double GetFloorHeight() => Height / FloorsCount;
        public uint GetFlatsPerEntrance() => FlatsCount / EntranceCount;
        public uint GetFlatsPerFloor() => FlatsCount / EntranceCount / FloorsCount;
    }

    /*Я не совсем понял в чем суть второго задания. Вроде фабрика объектов в данном случае нужна для
     возможности создания объектов с разныи параметрами одинакового типа, если это так, то вот пример. */

    public static class Creator
    {
        public static Building CreateBuilding(double height, uint floorsCount, uint flatsCount, uint frontDoorsCount)
        {
            var newBuilding = new Building(height, floorsCount, flatsCount, frontDoorsCount);
            return newBuilding;
        }
        public static Building CreateBuildingEmpty()
        {
            var newBuilding = new Building(0, 0, 0, 0);
            return newBuilding;
        }

        public static Building CreateBuildingWithHeightOnly(double height)
        {
            var newBuilding = new Building(height, 0, 0, 0);
            return newBuilding;
        }

        public static Building CreateBuildingFloorsOnly(uint floorsCount)
        {
            var newBuilding = new Building(0, floorsCount, 0, 0);
            return newBuilding;
        }

        public static Building CreateBuildingFlatsOnly(uint flatsCount)
        {
            var newBuilding = new Building(0, 0, flatsCount, 0);
            return newBuilding;
        }
    }

}
