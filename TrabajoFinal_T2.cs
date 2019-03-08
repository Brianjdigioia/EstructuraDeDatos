using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable donde se almacenera la opción que ingreso el usuario.
            int opcion;
            do
            {
                //Agregamos la excepción en caso de que el usuario ingrese una opción que no sea un número entero.
                try
                {
                    Console.WriteLine("\nMenu Principal");
                    Console.WriteLine("1. Crear Cola.");
                    Console.WriteLine("2. Salir.");
                    Console.Write("\nIngresar opción a realizar: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            crearCola();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Gracias por su preferencia");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("\nError: la opción no es valida. Intentelo de nuevo.");
                            break;
                    }
                }
                catch
                {
                    opcion = 0;
                    Console.Clear();
                    Console.WriteLine("\nError: la opción no es valida. Intentelo de nuevo.");
                }
                Console.WriteLine("\nApretar cualquier tecla para continuar la operación.");
                Console.ReadKey();
                Console.Clear();
            } while (opcion != 2); 
        }

        static void crearCola()
        {
            Queue miCola = new Queue();
            Console.Clear();
            Console.WriteLine("\nLa cola se ha creado exitosamente!");
            Console.WriteLine("\nPresione cualquier tecla para continuar la operación.");
            Console.ReadKey();
            Console.Clear();
            int opcion;
            do
            {
                try
                {
                    Console.WriteLine("\n Menu Principal");
                    Console.WriteLine("1. Agregar pedido.");
                    Console.WriteLine("2. Borrar pedido.");
                    Console.WriteLine("3. Listar todos los pedidos.");
                    Console.WriteLine("4. Listar último pedido.");
                    Console.WriteLine("5. Listar primer pedido.");
                    Console.WriteLine("6. Cantidad de pedido.");
                    Console.WriteLine("7. Vaciar Cola.");
                    Console.WriteLine("8. Eliminar Cola");
                    Console.WriteLine("9. Buscar Pedido");
                    Console.WriteLine("10. Salir.");
                    Console.Write("\nIngresar opción a realizar: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            agregarPedido(ref miCola);
                            break;
                        case 2:
                            Console.Clear();
                            eliminarPedido(ref miCola);
                            break;
                        case 3:
                            Console.Clear();
                            todosLosPedidos(ref miCola);
                            break;
                        case 4:
                            Console.Clear();
                            listarUltimoPedido(ref miCola);
                            break;
                        case 5:
                            Console.Clear();
                            listarPrimerPedido(ref miCola);
                            break;
                        case 6:
                            Console.Clear();
                            cantidadDePedidos(ref miCola);
                            break;
                        case 7:
                            Console.Clear();
                            limpiarCola(ref miCola);
                            break;
                        case 8:
                            Console.Clear();
                            eliminarCola(ref miCola);
                            break;
                        case 9:
                            Console.Clear();
                            buscarPedido(ref miCola);
                            break;
                        case 10:
                            Console.Clear();
                            Console.WriteLine("Gracias por su preferencia");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("\nError: la opción no es valida. Intentelo de nuevo.");
                            Console.WriteLine("\nApretar cualquier tecla para continuar la operación.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                catch
                {
                    opcion = 0;
                    Console.Clear();
                    Console.WriteLine("\nError: la opción no es valida. Intentelo de nuevo.");
                    Console.WriteLine("\nApretar cualquier tecla para continuar la operación.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (opcion != 10 && opcion != 8);
        }

        //Agrega un elemento a la cola.
        static void agregarPedido(ref Queue cola)
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese su número de pedido: ");
                int ingresarPedido = Convert.ToInt32(Console.ReadLine());

                if (ingresarPedido > 0 && ingresarPedido < 999)
                {
                    int indice = cola.Count + 1;
                    string pedido = indice + " – " + ingresarPedido;
                    cola.Enqueue(pedido);
                    Console.WriteLine("\nEl pedido '{0}' se agrego exitosamente.", pedido);

                }
                else
                {
                    Console.WriteLine("\nError: Ingresar un pedido mayor a 0 y menor a 999.\n");
                }
            }
            catch
            {
                Console.WriteLine("\nError: El pedido ingresado debe ser un número entero.\n");

            }
            Console.WriteLine("\nApretar cualquier tecla para continuar la operación.");
            Console.ReadKey();
            Console.Clear();
        }

        //Elimina el primer elemento de la cola.
        static void eliminarPedido(ref Queue cola)
        {
            //Validamos que pila tenga elementos a eliminar
            if (cola.Count != 0)
            {
                int indice = cola.Count - 1;
                string pedido = (string)cola.Dequeue();
                Console.Clear();
                Console.WriteLine("\nEl elemento '{0}' fue eleminador", pedido);
            }
            else
            {
                Console.WriteLine("\nError: No hay elementos a eliminar.");
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar la operación.");
            Console.ReadKey();
            Console.Clear();
        }

        //Elimina todos los elementos de la cola
        static void limpiarCola(ref Queue cola)
        {
            if(cola.Count != 0)
            {
                cola.Clear();
                Console.WriteLine("\nLa cola se limpio exitosamente.");
            }
            else
            {
                Console.WriteLine("\nError: La cola no posee elementos.");
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar la operación.");
            Console.ReadKey();
            Console.Clear();
        }

        //Lista todos los elementos que posee la cola
        static void todosLosPedidos(ref Queue cola)
        {
            if(cola.Count != 0)
            {
                Console.WriteLine("\nLista completa de pedidos: ");
                foreach (string dato in cola)
                {
                    Console.WriteLine("{0}", dato);
                }
            }
            else
            {
                Console.WriteLine("\nError: No hay elementos a listar.");
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar la operación.");
            Console.ReadKey();
            Console.Clear();
        }

        //Listar ultimo elemento de la cola
        static void listarUltimoPedido(ref Queue cola)
        {
            int i = 0;
            if (cola.Count != 0)
            {
                Console.WriteLine("Ultimo pedido: ");
                foreach(string dato in cola)
                {
                    i++;
                    if (cola.Count == i)
                    {
                        Console.WriteLine("{0}", dato);
                    }
                }
            }
            else
            {
                Console.WriteLine("\nError: No hay elemento a listar.");
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar la operación.");
            Console.ReadKey();
            Console.Clear();
        }

        //Listar primer elemento de la cola
        static void listarPrimerPedido(ref Queue cola)
        {
            if(cola.Count != 0)
            {
                Console.WriteLine(cola.Peek());
            }
            else
            {
                Console.WriteLine("\nError: No hay elemento a listar.");
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar la operación.");
            Console.ReadKey();
            Console.Clear();
        }
        
        //Muestra la cantidad de elementos que posee la cola.
        static void cantidadDePedidos(ref Queue cola)
        {
            if(cola.Count == 1)
            {
                Console.WriteLine("\nUsted posee solo 1 pedido.");
            }
            else if(cola.Count >= 1)
            {
                Console.WriteLine("\nUsted posee {0} pedidos.", cola.Count);
            }
            else
            {
                Console.WriteLine("\nUsted no posee pedido/s.");
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar la operación.");
            Console.ReadKey();
            Console.Clear();
        }

        //Elimina la cola.
        static void eliminarCola(ref Queue cola)
        {
            cola.Clear();
            Console.WriteLine("\nLa cola se elimino exitosamente.");
            Console.WriteLine("\nPresione cualquier tecla para continuar la operación.");
            Console.ReadKey();
            Console.Clear();
        }

        //Recorre la cola buscando el elemento espcificado por el usuario.
        static void buscarPedido(ref Queue cola)
        {
            int cont1 = 0;
            if (cola.Count != 0)
            {
                Console.Write("Ingrese pedido a buscar: ");
                string consultar = Console.ReadLine();

                Console.WriteLine("\nPedidos encontrados: ");
                foreach (string dato in cola)
                {
                    string consulta = dato[0] + " – " + consultar;

                    if(dato == consulta)
                    {
                        cont1++;
                        Console.WriteLine("{0}", consulta);
                    }
                }

                if (cont1 == 1) { 
                    Console.WriteLine("\nEl pedido que busca se encuentra en la cola.");
                    Console.WriteLine("Aparece una vez.");
                }
                else if(cont1 > 1)
                {
                    Console.WriteLine("\nEl pedido que busca se encuentra en la cola.");
                    Console.WriteLine("Aparece {0} veces.", cont1);
                }
                else
                {
                    Console.WriteLine("\nEl pedido que busca no se encuentra en la cola.");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar la operación.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nError: No hay elementos a listar.");
                Console.WriteLine("\nPresione cualquier tecla para continuar la operación.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
