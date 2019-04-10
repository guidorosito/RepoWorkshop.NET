using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerNro1
{
    class Persona
    {
          
        public int edad { get => edad; set => value; } // forma larga

        public string nombre { get; set; } //forma abreviada 
        public string direccion { get => direccion; set => value; } //forma larga 


        /* OTRA FORMA:
         * 
        public string direccion;
        public string getNombreDireccion()
        {
            return this.direccion;
        }


        */

        /*Forma de conseguir edad
        
        public int getEdad()
        {
            return this.edad;
        }
        */
    }
}
