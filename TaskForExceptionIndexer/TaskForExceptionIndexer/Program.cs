using System;
using TaskForExceptionIndexer.Models;

namespace TaskForExceptionIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your new room name: " );
            string roomname = Console.ReadLine();
            Console.WriteLine("Input your new room price: ");
            double price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your new room person capacity: ");
            int personcapacity = Convert.ToInt16(Console.ReadLine());
            Room room1 = new Room(roomname,price,personcapacity);
            Console.WriteLine(room1.ToString());
            Console.WriteLine("Input new hotel name: ");
            string hotelname = Console.ReadLine();
            Console.WriteLine("Input number of counts in Hotel that u will reserve: ");
            int countroom = Convert.ToInt32(Console.ReadLine());
            Hotel Elite = new Hotel(hotelname,countroom);
            Elite.AddRoom(room1);
            Elite.Reserve(3);


        }
    }
}
