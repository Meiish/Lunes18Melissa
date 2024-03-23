using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba1.Properties
{
    //este sera el metodo rectangle que heredara de shape :3
    //todos los hijos de shape tendran el metodo de calcular area wii
    internal class Rectangle:Shape
    {
        private float b;
        private float h;

        //escribir ctor hace que el constructor se cree mas rapido, que loco
        //dentro del constructor colocar las variables a utilizar
        public Rectangle(float b, float h)
        {
            //no entendi muy bien porq se ponia this pero alonso dijo:
            //es para especificar que hablas de la variable que está dentro de la clase y no la del parametro
            //solo es necesario si tanto la variable de la clase como el parámetro del constructor se llaman igual
            this.b = b;
            this.h = h;
        }

        //ahora si viene el metodo de la clase padre

        public override float GetArea()
        {
            //no tenia imaginacion y tiempo xD
            return b * h;
        }

    }
}
