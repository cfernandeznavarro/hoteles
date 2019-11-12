using System;
using System.Collections.Generic;
using System.Linq;

namespace Hoteles
{
    class Program
    {
        public static int CurrentOption { get; set; }

        static List<Hotel> hotelList;


        static void Main(string[] args)
        {
            hotelList = new List<Hotel> { };
            Console.WriteLine("Bienvenido al programa de gestión hotelera" + "\r\n");

            while (true)
            {
                ShowMainMenu();
                string option = Console.ReadLine();

                if (option == "1")
                {
                    if (CurrentOption != 1)
                    {
                        Console.WriteLine();
                        crearHotel();
                    }
                }
                if (option == "2")
                {
                    if (CurrentOption != 2)
                    {
                        Console.WriteLine();
                        showHotel();
                    }
                }

                if (option == "3")
                {
                    if (CurrentOption != 2)
                    {
                        Console.WriteLine();
                        deleteHotel();
                    }
                }

                if (option == "4")
                {
                    if (CurrentOption != 4)
                    {
                        Console.WriteLine();
                        modifyHotel();
                    }
                }
            }
        }

        static void ShowMainMenu()
        {
            CurrentOption = 0;
            Console.WriteLine("Menu de opciones principal");

            Console.WriteLine("Pulse 0 para volver a este menu");
            Console.WriteLine("Pulse 1 para DAR DE ALTA un nuevo hotel en el programa");
            Console.WriteLine("Pulse 2 para MOSTRAR la información de un hotel ");
            Console.WriteLine("Pulse 3 para DAR DE BAJA un hotel en el programa");
            Console.WriteLine("Pulse 4 para MODIFICAR la información de un hotel en el programa");

        }

        static Hotel crearHotel()
        {
            CurrentOption = 1;
            Console.WriteLine("A continuacion introduzaca la inforamción del hotel para darlo del alta en el programa.");

            Console.WriteLine("Introduzca el nombre del hotel:");
            string nombreHotel = Console.ReadLine();

            Console.WriteLine("Introduzca el número de habitaciones del hotel:");
            int numHabitaciones = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el número de pisos del hotel:");
            int numPisos = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca la superficie del hotel:");
            int superficie = int.Parse(Console.ReadLine());

            Hotel myHotel = new Hotel();
            myHotel.Name = nombreHotel;
            myHotel.Room = numHabitaciones;
            myHotel.Floor = numPisos;
            myHotel.Area = superficie;
            hotelList.Add(myHotel);

            Console.WriteLine("el hotel" + myHotel.Name + "se ha dado de alta" + "\r\n");
            return myHotel;
        }

        static void showHotel()
        {
            CurrentOption = 2;

            Console.WriteLine("A continuacion introduzaca el NOMBRE DEL HOTEL para mostrar su información por pantalla");
            string name = Console.ReadLine();
            bool isEmpty = !hotelList.Any();

            if (isEmpty)
            {
                Console.WriteLine("No hay dado de alta ningun hotel en el sistema");
            }

            else
            {
                foreach (var myHotel in hotelList)
                {
                    if (myHotel.Name == name)
                    {
                        Console.WriteLine("NOMBRE HOTEL: " + myHotel.Name);
                        Console.WriteLine("Número de habitaciones: " + myHotel.Room);
                        Console.WriteLine("Número de pisos: " + myHotel.Floor);
                        Console.WriteLine("Superficie: " + myHotel.Area + "\r\n");
                    }
                    else
                        Console.WriteLine("el Hotel " + name + " no existe en el sistema");

                }

            }

        }

        static void deleteHotel()
        {
            CurrentOption = 3;
            Console.WriteLine("A continuacion introduzaca la información del hotel para darlo del BAJA en el programa.");
            string name = Console.ReadLine();

            /*foreach (var myHotel in hotelList)  //    for (let i = 0; i < hotels.length; i++)
            {
                if (myHotel.Name == name)
                {
                    var i = hotelList.Remove(myHotel);
                    Console.WriteLine("El hotel " + myHotel.Name + " se ha eliminado correctamente del programa.");
                    break;
                }
                else
                {
                    Console.WriteLine("No existe un hotel con ese nombre dentro de la aplicación.");
                }


            You cannot remove an item from a collection as you are iterating over it in a foreach.
            Or you can keep a separate list of items to remove after you finish the original loop.
            }*/

            List<Hotel> RemoveList = new List<Hotel> { };

            bool isEmpty = !hotelList.Any();

            if (isEmpty)
            {
                Console.WriteLine("el Hotel " + name + " no existe en el sistema");
            }
            else
            {
                foreach (var myHotel in hotelList)  //    for (let i = 0; i < hotels.length; i++)
                {
                    if (myHotel.Name == name)
                    {
                        RemoveList.Add(myHotel);
                    }

                }

                foreach (var myHotel in RemoveList)
                {
                    hotelList.Remove(myHotel);
                    Console.WriteLine("El hotel " + myHotel.Name + " se ha eliminado correctamente del programa.");
                }

            }
        }

        static void modifyHotel()
        {
            CurrentOption = 4;
            Console.WriteLine("Introduzca nombre del hotel que quiere modificar");
            string name = Console.ReadLine();
            bool isEmpty = !hotelList.Any();

            if (isEmpty)
            {
                Console.WriteLine("el Hotel " + name + " no existe en el sistema");
            }
            else
            {
                foreach (var myHotel in hotelList)
                {
                    if (myHotel.Name == name)
                    {
                        Console.WriteLine("Introduzca que campo quiere modificar");
                        Console.WriteLine("Opciones: 1 - modificar el NOMBRE del hotel");
                        Console.WriteLine("Opciones: 2 - modificar el NÚMERO DE HABITACIONES del hotel");
                        Console.WriteLine("Opciones: 3 - modificar el NÚMERO DE PISOS del hotel");
                        Console.WriteLine("Opciones: 4 - modificar la SUPERFICIE del hotel");

                        string option = Console.ReadLine();

                        Console.WriteLine("Introduzca el nuevo valor");
                        string cambio = Console.ReadLine();

                        if (option == "1")
                            myHotel.Name = cambio;


                        else if (option == "2")
                            myHotel.Room = int.Parse(cambio);

                        else if (option == "3")
                            myHotel.Floor = int.Parse(cambio);

                        else if (option == "4")
                            myHotel.Area = int.Parse(cambio);

                    }

                    /*switch (opction)
                    {
                        case "1":
                            myHotel.Name = cambio;

                        case "2":
                            myHotel.Room = int.Parse(cambio);
                            break;

                        case "3":
                            myHotel.Floor = int.Parse(cambio);
                            break;

                        case "4":
                            myHotel.Area = int.Parse(cambio);
                            break;
                    }*/

                    // hotelList.Add(myHotel);

                    Console.WriteLine("el hotel " + myHotel.Name + " se ha modificado correctamente." + "\r\n");

                }
            }
        }
    }
}