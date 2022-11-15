using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Backpacker
{
    internal class Item //basic implmentation all objects are rectangular in shape
    {
        private string _name;
        private double _height;
        private double _depth; //did not use _length to prevent confustion with Array.Length()
        private double _width;
        private double _Weight;

        public string Name { get { return _name; } set { _name = value; } }
        public double Height { get { return _height; } set { if (value > 0)_height = value; } }
        public double Depth { get { return _depth; } set { if (value > 0) _depth = value; } }
        public double Width { get { return _width; } set { if (value > 0) _width = value; } }
        public double Weight { get { return _Weight; } set { if (value >= 0) _Weight = value; } }

        public Item() // one base unit sized object
        {
            _name = "Basic Block";
            Height = 10.0;
            Width = 10.0;
            Depth = 10.0;
            Weight = 10.0;
        }

        //TODO, create combinations of Items to create more complex shapes.

        public Item(string name, double height, double depth, double width, double weight)
        {
            _name = name;
            Height = height;
            Depth = depth;
            Width = width;
            Weight = weight;            
        }
        public double Volume() // returns total volume taken up by this item
        {
            double result = Height * Width * Depth;
            return result;            
        }

    }
    internal class Receptical : Item
    {
        #region properties and accessors
        //private bool _Collapsable;  //TODO add collapsable as another receptical or inherited class 
        //private bool _isExpanded;
        //private int _pockets;
        private Receptical[] _pocketsArray; //amount of pockets in this receptical
        private double _mainCompartment; //capacity of the main compartment. must be greater than zero
        private double _maxCapacity;  //TODO make sure max capacity is less than volume
        private List<Item> _contents;

        //public int Pockets { 
        //    get { return _pockets; }
        //    set { if (value >= 0) _pockets = value; } }
        public List<Item> Contents { 
            get { return _contents; }
            set { _contents = value; } }

        public Receptical[] PocketsArray { 
            get {
                Receptical[] result = new Receptical[_pocketsArray.Length];
                _pocketsArray.CopyTo(result, 0);
                return result;
            } 
            private set { 
                _pocketsArray = new Receptical[value.Length];
                value.CopyTo(_pocketsArray, 0);                
            } }

        public double MainCompartment { 
            get { return _mainCompartment; } 
            set {
                if (value > MaxCapacity)
                    _mainCompartment = MaxCapacity;
                else if (value > 0)
                    _mainCompartment = value;
                else
                    _mainCompartment = 0;
            } }

        public double MaxCapacity
        {
            get { return _maxCapacity; }
            set
            {
                if (value > 0)
                    _maxCapacity = value;
                else
                    _maxCapacity = 0;
            }
        }

        #endregion

        #region constructors

        //basic receptical of basic Item with no pockets
        public Receptical() : base()
        {
            PocketsArray = new Receptical[0];
            MaxCapacity = 1.0;
            MainCompartment = MaxCapacity;
        }

        //base receptical of custome size, no pockets
        public Receptical(double capacity, string name, double height, double depth, double width, double weight) 
            : base(name, height, depth, width, weight)
        {
            PocketsArray = new Receptical[0];
            MaxCapacity = capacity;
            MainCompartment = MaxCapacity;
        }

        //custom size with pockets
        public Receptical(double capacity, double maincompartment, Receptical[] pockets, string name, double height, double depth, double width, double weight)
            : base(name, height, depth, width, weight)
        {
            MaxCapacity = capacity;
            double pocketspace = 0;
            for (int i = 0; i < pockets.Length; i++)
                pocketspace += pockets[i].MaxCapacity;
            if(pocketspace + MainCompartment <= MaxCapacity) //check that inner space is smaller than total capacity
            {
                MainCompartment = maincompartment;
                PocketsArray = pockets;
            }
            else  //do not take pockets if innerspace is greater than max space
            {
                MainCompartment = capacity;
                PocketsArray = new Receptical[0];
            }           
        }

        #endregion

        public double AmountFilled() //returns amount of receptical that is filled
        {
            double result = 0;
            if (Contents != null)
            {
                for (int i = 0; i < Contents.Count; i++)
                    result += Contents[i].Volume();
            }

            return result;
        }
        public double SpaceA()
        {
            return MaxCapacity - AmountFilled();
        }

        public void AddItem(Item item) // add an item to contents of receptical if possible
        {
            if((MaxCapacity - AmountFilled()) >= item.Volume())
                Contents.Add(item);
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void RemoveItem(Item item)
        {
            if (Contents.Count > 0)
                if (Contents.Contains(item)) 
                    Contents.Remove(item);
        }

        public double CurrentWeight()
        {
            double result = this.Weight;
            if (Contents != null)
            {
                for (int i = 0; i < Contents.Count; i++)
                {
                    result += Contents[i].Weight;
                }
            }
            if (PocketsArray != null)
            {
                for (int i = 0; i < PocketsArray.Length; i++)
                {
                    result += PocketsArray[i].Weight;
                }
            }
            return result;
        }

    }
}
