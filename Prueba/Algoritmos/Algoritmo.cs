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
            int n = s1.ToString().Length;

            for (int i = 0; i < Cantidad; i++)
            {
                long producto = (long)s1 * (long)s2;
                productos.Add((int)producto);

                // Convertir a string y rellenar con ceros a la izquierda
                string productoStr = producto.ToString();

                // Extraer los n dígitos centrales
                if (productoStr.Length % 2 != 0)
                {
                    int inicio = (productoStr.Length - n) / 2;

                    string medioStr = productoStr.Substring(inicio, n);
                    string medioderecho = productoStr.Substring(inicio + 1, n);
                    string sinextremos = productoStr.Substring(1, productoStr.Length - 2);

                    int nuevo = int.Parse(medioStr);
                    val1.Add(nuevo);
                    val2.Add(0);
                    sinext.Add(int.Parse(sinextremos));

                    Rn.Add(s1);
                    Rn1.Add(s2);
                    // Actualizar semillas
                    s1 = s2;
                    s2 = nuevo;
                } else{
                    int inicio = (productoStr.Length - n) / 2;


                    string medioStr = productoStr.Substring(inicio, n);
                    string medioderecho = productoStr.Substring(inicio + 1, n);
                    string sinextremos = productoStr.Substring(1, productoStr.Length - 2);

                    int nuevo = int.Parse(medioStr);
                    val1.Add(nuevo);
                    val2.Add(int.Parse(medioderecho));
                    sinext.Add(int.Parse(sinextremos));

                    Rn.Add(s1);
                    Rn1.Add(s2);
                    // Actualizar semillas
                    s1 = s2;
                    s2 = nuevo;
                }
            }

            return (val1,val2, productos,Rn,Rn1,sinext);

        }
    }
}
