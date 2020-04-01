using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooglePago
{
    class Empleado
    {
        String nombre;
        String categoria;
        String[] categoria2;
        int minutosTardanza;
        int llamadasAtencion;


        public double infraccionTotal(String categoria, int minutosTardanza, int llamadasAtencion)
        {
            double infraccion = 0;

            switch (categoria)
            {
                case "A":
                    infraccion = 2500;
                    break;
                case "B":
                    infraccion = 1500;
                    break;
                case "C":
                    infraccion = 1000;
                    break;
                case "D":
                    infraccion = 900;
                    break;
            }

            if (categoria == "A")
            {
                infraccion = 2500;
            }
            else if (categoria == "B")
            {
                infraccion = 1500;
            }
            else if (categoria == "C")
            {
                infraccion = 1000;
            }
            else
            {
                infraccion = 900;
            }

            if (minutosTardanza > 0)
            {
                infraccion = infraccion - (minutosTardanza * 5);
            }

            if (llamadasAtencion > 0)
            {
                infraccion = infraccion - (minutosTardanza * 10);
            }

            if (minutosTardanza == 0 && llamadasAtencion == 0)
            {
                infraccion = infraccion * 1.15;
            }


            return infraccion;
        }
    }
}
