using System;
using System.Collections.Generic;
using System.Text;

namespace TaskForExceptionIndexer.Models
{
    class Room
    {
        private static int _id;
        private string _name;
        private double _price;
        private int _personCapacity;
        public bool _isAvailable=true;



        public int Id 
        {
            get
            {
                return _id;
                
            }
            
         }

        public string Name
        {
            get
            {
                return _name;
            }
            set 
            {
                if (value.Length>0)
                {
                    _name = value;
                }
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public int PersonCapacity
        {
            get
            {
                return _personCapacity;
            }
            set
            {
                if (value > 0)
                {
                    _personCapacity = value;
                }
            }
        }
        public Room(string Name,double Price,int PersonCapacity)
        {
            
            this.Name = Name;
            this.Price = Price;
            this.PersonCapacity = PersonCapacity;
            _id++;
        }


        public string ShowInfo() 
        {
            string ShowInfo = $"Room's id: {Id} Room's name: {Name} Room's price: {Price}" +
                            $" Room's person capacity: {PersonCapacity} Room's Available: {_isAvailable}";

            return ShowInfo;
        }

        public override string ToString()
        {
            
            return ShowInfo();
        }


    }
}
