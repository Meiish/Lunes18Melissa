using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba1
{
    internal class Controller
    {
        //nosee creo que ess asi simplemente void vacio porq trabajar con estaticos es mas feo
        //el nuevo controlador nada estatico :3

        public void Ejecutador()
        {
            Menu();
        }

        private void Menu()
        {
            bool mediador = true;

            while (mediador)
            {
                Shape shape = null;
                //esto creo que si me acuerdo
                Console.WriteLine("Introduce el numero de la figura geometrica que quieres calcular");
                Console.WriteLine("1. Rectangulo");
                Console.WriteLine("2. Rombo");
                Console.WriteLine("3. Salir");

                string order = Console.ReadLine();

                switch (order)
                {
                    case "1":
                        shape = GetRectangle();
                        break;
                    case "2":
                        shape = GetDiamond();
                        break;
                    case "3":
                        mediador = false;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

                if (shape != null)
                {
                    Console.WriteLine($"el area es{shape.GetArea()}");
                }
            }
        }

        //NO PUEDE SER HABIA PUESTO FLOAT EN VEZ DE RECATNGLE Y IGUAL ABAJOOO ME EMUEROOO PERO LO TERMINE
        // RECTANGLEEEEEEEEEEEEEE
        //ERA
        private Rectangle GetRectangle()
        {
            float b;
            float h;

            Console.WriteLine("escribe el valor de la base del rectangulo, por favor");
            //lo lee
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("escribe el valor de la altura del rectangulo, por favor de nuevoo");
            //lo lee
            h = float.Parse(Console.ReadLine());


            //no me acuerdo porq se ponia esto
            Rectangle rectangle = new Rectangle(b, h);
            //jaja si lo hice solita

            //NO TE OLVIDES DEL RETURN

            return rectangle;
        }
        private Diamond GetDiamond()
        {
            float dMayor;
            float dMenor;

            Console.WriteLine("escribe el valor del diamentro mayor del rombo, por favor");
            dMayor = float.Parse(Console.ReadLine());

            Console.WriteLine("escribe el valor del diamentro menor del rombo, por favor de nuevoo");
            dMenor = float.Parse(Console.ReadLine());

            Diamond diamond = new Diamond(dMayor, dMenor);
            return diamond;
        }
    }
}
