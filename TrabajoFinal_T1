using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;

namespace conStack
{
    class Program
    {
        static int Tope = 0;
        static void Main(string[] args)
        {
            int opcion;//opcion del menu 
            do
            {
                Console.Clear();//se limpia consola
                opcion = principal();//muestra menu y espera opción
                switch (opcion)
                {
                    case 1:
                        crearpila();
                        break;
                    case 2: break; //salir
                    default:
                        mensaje("ERROR: la opción no es valida. Intente de nuevo.");
                        break;
                }
            }
            while (opcion != 2);
            mensaje("El programa a finalizado.");
        }

        static void crearpila()
        {
            Stack miPila = new Stack();
            Console.Clear();
            Console.WriteLine("\n=======================================================");
            Console.WriteLine("La pila se ha creado exitosamente!");
            Console.WriteLine("=======================================================");
            Console.ReadKey();
            Console.Clear();
            int opcion;//opcion del menu 
            do
            {
                Console.Clear();//se limpia consola
                opcion = menu();//muestra menu y espera opción
                switch (opcion)
                {
                    case 1:
                        agregarpatente(ref miPila);
                        break;
                    case 2:
                        eliminar(ref miPila);
                        break;
                    case 3:
                        limpiar(ref miPila);
                        break;
                    case 4:
                        imprimir(miPila);
                        break;
                    case 5:
                        listarprimera(miPila);
                        break;
                    case 6:
                        listarultima(miPila);
                        break;
                    case 7:
                        cantidadpatente(miPila);
                        break;
                    case 8:
                        buscarpatente(ref miPila);
                        break;
                    case 9:
                        borrarpila(ref miPila);
                        break;
                    default:
                        mensaje("ERROR: la opción no es valida. Intente de nuevo.");
                        break;
                }
            }
            while (opcion != 9);
        }

        /** añade un nuevo elemento a la pila */
        static void agregarpatente(ref Stack pila)
        {
            //Console.Write("Ingrese valor: ");
            string var1 = agregarletra(ref pila);
            if (var1 == null)
            {
                Console.WriteLine("\n=======================================================");
                Console.WriteLine("Letras mal ingresadas");
                Console.WriteLine("=======================================================");
                Console.ReadKey();
            }
            else
            {
                int var2 = agregarnumero(ref pila);

                if (var2 != 0)
                {
                    string patente = var1 + " " + var2;
                    Console.Write(patente);
                    Console.ReadKey();
                    pila.Push(patente);
                    Tope++;
                }
                else
                {
                    mensaje("Error en el nombre de patente");
                }
            }

        }

        static string agregarletra(ref Stack pila)
        {
            try
            {
                Console.Write("Ingrese las 3 letras de la patente: ");
                string valor = Console.ReadLine();
                if ((Regex.IsMatch(valor, @"^[a-zA-Z]+$")) && (valor.Length == 3))
                {
                    return valor.ToUpper();
                }
                else
                {
                    mensaje("Solo 3 letras de la A a la Z");
                    return null;
                }
            }
            catch
            {
                mensaje("Error: Solo 3 letras de la A a la Z");
            }
            return null;
        }

        static int agregarnumero(ref Stack pila)
        {
            try
            {
                Console.Write("Ingrese los 3 numeros de la patente: ");
                int valor2 = Convert.ToInt32(Console.ReadLine());
                if ((valor2 > 0 || valor2 < 100) && (valor2.ToString().Length == 3))
                {
                    return valor2;
                }
                else
                {
                    mensaje("Solo 3 números del 1 al 99");
                    return 0;
                }
            }
            catch
            {
                mensaje("Error: Solo 3 números del 1 al 99");
            }
            return 0;
        }

        /** Elimina todos los elementos de la pila */
        static void limpiar(ref Stack pila)
        {
            pila.Clear();
            imprimir(pila);
        }
        /** Elimina elemento de la pila */
        static void eliminar(ref Stack pila)
        {
            if (pila.Count != 0)
             {
                string valor = (string)pila.Pop();
                mensaje("Elemento " + valor + " eliminado");
            }
             else {
                imprimir(pila);
            }
        }
        /** muestra menu y retorna opción */
        static int menu()
        {
            //Console.Clear();
            Console.WriteLine("\n            Stack Menu\n");
            Console.WriteLine(" 1.- Agregar patente");
            Console.WriteLine(" 2.- Borrar patente");
            Console.WriteLine(" 3.- Vaciar Pila"); //Opción agregada además de las básicas.
            Console.WriteLine(" 4.- Listar todas las patentes");
            Console.WriteLine(" 5.- Listar primera patente");
            Console.WriteLine(" 6.- Listar ultima patente");
            Console.WriteLine(" 7.- Cantidad de patentes");
            Console.WriteLine(" 8.- Buscar patente"); //Segunda opción agregada además de las básicas.
            Console.WriteLine(" 9.- Borrar pila");
            Console.Write("Ingresa tu opción: ");
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                return valor;
            }
            catch
            {
                return 0;
            }
        }

        /** muestra primer menu y retorna opción */
        static int principal()
        {
            //Console.Clear();
            Console.WriteLine("\n            Stack Menu Principal\n");
            Console.WriteLine("\n     Para empezar a utilizar el programa, debe crear una pila. \n");
            Console.WriteLine(" 1.- Crear pila");
            Console.WriteLine(" 2.- Salir");
            Console.Write("Ingresa tu opción: ");
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                return valor;
            }
            catch
            {
                return 0;
            }
        }

        /** Muestra mensaje del programa al usuario */
        static void mensaje(String texto)
        {
            if (texto.Length != 0)
             {
                Console.WriteLine("\n=======================================================");
                Console.WriteLine("{0}", texto);
                Console.WriteLine("=======================================================");
                Console.WriteLine("\n Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        /** Imprime pila */
        static void imprimir(Stack pila)
        {
            int i = 1;
            if (pila.Count != 0)
             {
                Console.WriteLine("");
                foreach (string dato in pila)
                {
                    if (i <= Tope) {
                        if (dato.Length == 10)
                            Console.WriteLine(i + " - " + dato);
                        else
                            Console.WriteLine(i + " - " + dato);
                            Console.WriteLine("---");
                        i++;
                    }
                }
                Console.WriteLine("\n=======================================================");
                Console.WriteLine("\nPresione cualquier tecla para continuar ...");
                Console.WriteLine("=======================================================");
                Console.ReadKey();
            }
             else 
             {
                mensaje("La Pila esta vacia");
            }
        }

        //Listar primer patente
        static void listarprimera(Stack pila)
        {
            int i = 1;
            if (pila.Count != 0)
            {
                foreach (string dato in pila)
                {
                    if (i == 1)
                    {
                       Console.WriteLine(i + " - " + dato);
                    }
                    i++;
                }
                Console.WriteLine("\n=======================================================");
                Console.WriteLine("\nPresione cualquier tecla para continuar ...");
                Console.WriteLine("=======================================================");
                Console.ReadKey();
            }
            else
            {
                mensaje("La Pila esta vacia");
            }
        }

        //Listar ultima patente
        static void listarultima(Stack pila)
        {
            int i = 1;
            if (pila.Count != 0)
            {
                foreach (string dato in pila)
                {
                    if (i == Tope)
                    {
                        Console.WriteLine(i + " - " + dato);
                    }
                    i++;
                }
                Console.WriteLine("\n=======================================================");
                Console.WriteLine("\nPresione cualquier tecla para continuar ...");
                Console.WriteLine("=======================================================");
                Console.ReadKey();
            }
            else
            {
                mensaje("La Pila esta vacia");
            }
        }

        //Cantidad de patentes.
        static void cantidadpatente(Stack pila)
        {
            int i = 1;
            if (pila.Count != 0)
            {
                foreach (string dato in pila)
                {
                    if (i == Tope)
                    {
                        Console.WriteLine(i);
                    }
                    i++;
                }
                Console.WriteLine("\n=======================================================");
                Console.WriteLine("\nPresione cualquier tecla para continuar ...");
                Console.WriteLine("=======================================================");
                Console.ReadKey();
            }
            else
            {
                mensaje("La Pila esta vacia");
            }
        }

        static void borrarpila(ref Stack pila)
        {
            Console.WriteLine("\n=======================================================");
            Console.WriteLine("La pila ha sido eliminada");
            Console.WriteLine("=======================================================");
            Console.ReadKey();
        }

        /** Buscar patente */
        static void buscarpatente(ref Stack pila)
        {
            int cont = 0;
            string var1 = agregarletra(ref pila);
            if (var1 == null)
            {
                Console.WriteLine("\n=======================================================");
                Console.WriteLine("Letras mal ingresadas");
                Console.WriteLine("=======================================================");
                Console.ReadKey();
            }
            else
            {
                int var2 = agregarnumero(ref pila);

                if (var2 != 0)
                {
                    string patente = var1 + " " + var2;
                    foreach (string dato in pila)
                    {
                        if (dato == patente)
                        {
                            cont++;
                        }
                    }
                    if (cont != 0)
                    {
                        mensaje("La patente " + patente + " se encontró " + cont + " veces dentro de la pila");
                    }
                    else
                    {
                        mensaje("La patente no se encuentra dentro de la pila");
                    }
                }
            }

        }
    }
}
