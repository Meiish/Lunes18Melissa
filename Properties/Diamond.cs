using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba1.Properties
{
    //no se por que se estan creando mis scripts debajo de assembly D:
    //aqui supongo que hago lo mismo que en rectangle
    internal class Diamond:Shape
    {
        private float dMayor;
        private float dMenor;
        public Diamond(float dMayor, float dMenor)
        {
            this.dMayor = dMayor;
            this.dMenor = dMenor;
        }

        //me habia olvidado la herencia xD
        public override float GetArea()
        {
            return dMayor * dMenor / 2;
        }
    }
}
