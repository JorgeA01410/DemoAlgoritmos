using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Algoritmos
{
    public class Algoritmo
    {
        public Algoritmo() { }

        public (List<int> val1, List<int> val2, List<int> productos, List<int> Rn, List<int> Rn1, List<int> sinext) GenerarNumeros(int semilla1, int semilla2, int Cantidad)
        {

            int s1 = semilla1;
            int s2 = semilla2;
            List<int> val1 = new List<int>();
            List<int> val2 = new List<int>(); 
            List<int> productos = new List<int>();
            List<int> Rn = new List<int>();
            List<int> Rn1 = new List<int>();
            List<int> sinext = new List<int>();


            for (int i = 0; i < Cantidad; i++)
            {
                long producto = (long)s1 * (long)s2;
                productos.Add((int)producto);

                // Convertir a string 
                string productoStr = producto.ToString();

                // Extraer los n dígitos centrales
                string medioStr;
                string medioStr2;
                if (productoStr.Length == 2 || productoStr.Length == 1)
                {
                    medioStr = "0";
                    int medioStr1 = int.Parse(medioStr);
                    medioStr2 = medioStr1.ToString();

                    sinext.Add(int.Parse(medioStr));

                }
                else
                {
                    medioStr = productoStr.Substring(1, productoStr.Length - 2);

                    long medioStr1 = long.Parse(medioStr);

                    medioStr2 = medioStr1.ToString();

                    sinext.Add(int.Parse(medioStr));
                }
                    


                int nuevo;

                if (medioStr2.Length < 3)
                {
                    nuevo = int.Parse(medioStr2);
                    val1.Add(nuevo);
                    val2.Add(0);

                }else if (medioStr2.Length % 2 != 0 && medioStr2.Length >= 3)
                {
                    nuevo = int.Parse(medioStr2);
                    val1.Add(nuevo);
                    val2.Add(0);
                } else{
                    // Si longitud par → dividir en 2 mitades seguras
                    int mitad = medioStr2.Length / 2;
                    string medioizq = medioStr2.Substring(0, mitad+1);
                    string medioderecho = medioStr2.Substring(mitad-1);

                    val1.Add(int.Parse(medioizq));
                    val2.Add(int.Parse(medioderecho));

                    nuevo = int.Parse(medioizq);
                }

                Rn.Add(s1);
                Rn1.Add(s2);

                // Actualizar semillas
                s1 = s2;
                s2 = nuevo;

            }

            return (val1,val2, productos,Rn,Rn1,sinext);

        }
    }
}
