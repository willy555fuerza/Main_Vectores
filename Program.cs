using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Main_Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MENU DE VECTORES
            int n, f, aux, opcion,l,r;
            int[] vec;
            vec = new int[100];
            Random radom = new Random();
            do
            {
                Console.WriteLine("***********************************************************************************************************");
                Console.WriteLine("MENU DE OPCIONES                                  THE BEST COMPANNY  WILLSTARS                            *");
                Console.WriteLine("***************************************** ***************************** ***********************************");
                Console.WriteLine("1.VECTORES MANUAL                        * *************  ************ ************************************");
                Console.WriteLine("2.VECTORES ALEARTORIO                  **** *********** ** ********** *************************************");
                Console.WriteLine("3.MOSTRAR                            ******* ********* **** ******** **************************************");
                Console.WriteLine("4.FIBONACCI                        ********** ******* ****** ****** ***************************************");
                Console.WriteLine("5.ORDENAMIENTO BORBUJA          *************** **** ******** **** ****************************************");
                Console.WriteLine("6.ORDENAMIENTO INSERCCION     ****************** * ***********  * *****************************************");
                Console.WriteLine("7.VECTOR QUE MARQUE X IMPARES  ****************************************************************************");
                Console.WriteLine("***********************************************************************************************************");
                Console.WriteLine("0.SALIR");
                Console.WriteLine("***********************************************************************************************************");

                opcion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("");
                switch (opcion)
                {

                    case 1:
                        Console.WriteLine("************************************** 1 VECTORES MANUAL *******************************************");

                        Console.Write("DIGITE LA DIMENSION DEL VECTOR: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("INGRESE VALOR: ");
                            vec[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("VECTORES A MOSTRAR: ");
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("[" + vec[i] + "]");
                        }
                        
                        break;


                    case 2:
                        Console.WriteLine("************************************** 2 VECTORES ALEARTORIO ***************************************");

                        for (int i = 0; i < vec.Length; i++)
                        {
                            vec[i] = radom.Next(0, 30);

                        }
                        Console.Write("DIGITE LA CANTIDAD QUE QUIERE MOSTRAR: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("[" + vec[i] + "]");
                           
                        }

                        break;

                    case 3:
                        Console.WriteLine("************************************** 3 MOSTRAR ***************************************************");

                        Console.Write("DIGITE LA CANTIDAD QUE QUIERE MOSTRAR: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("[" + vec[i] + "]");
                          
                        }
                        break;
                    case 4:

                        Console.WriteLine("************************************** 4 FIBONACCI *************************************************");

                        Console.Write("DIGITE LA CANTIDAD QUE QUIERE MOSTRAR: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        vec[0] = 0;
                        vec[1] = 1;
                        l = 2;


                        while (l < n)
                        {
                            vec[l] = vec[l - 1] + vec[l - 2];
                            l++;
                        }
                        for (f = 0; f < n; f++)
                        {

                            Console.Write("[" + vec[f] + "]");
                          
                        }


                        break;

                    case 5:
                        Console.WriteLine("************************************** 5 ORDENAMIENTO BORBUJA *************************************");

                        for (int i = 0; i < vec.Length; i++)
                        {
                            vec[i] = radom.Next(0, 30);

                        }
                        Console.Write("DIGITE LA CANTIDAD QUE QUIERE MOSTRAR: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("[" + vec[i] + "]");
                        }
                        Console.WriteLine("");
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = i + 1; j < n; j++)
                                if (vec[i] > vec[j])
                                {
                                    aux = vec[i];
                                    vec[i] = vec[j];
                                    vec[j] = aux;

                                }

                        }

                        for (int i = 0; i < n; i++)
                        {

                            Console.Write("[" + vec[i] + "]");
                           
                        }
                        break;

                    case 6:
                        Console.WriteLine("************************************** 6 ORDENAMIENTO INSERCCION **********************************");

                        for (int i = 0; i < vec.Length; i++)
                        {
                            vec[i] = radom.Next(30);
                        }
                        Console.Write("DIGITE LA CANTIDAD QUE QUIERE MOSTRAR: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("[" + vec[i] + "]");
                        }

                        for (int i = 1; i < n; i++)
                        {
                            aux = vec[i];
                            f = i - 1;
                            while (f >= 0 && vec[f] > aux)
                            {
                                vec[f + 1] = vec[f];
                                f = f - 1;

                            }
                            vec[f + 1] = aux;
                        }
                        Console.WriteLine("");

                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("[" + vec[i] + "]");
                           
                        }

                        break;

                    case 7:
                        Console.WriteLine("************************************** 7 VECTOR QUE MARQUE X IMPARES **********************************");

                        Console.WriteLine("VECTOR QUE MARQUE X PARES");

                        Console.Write("INGRESE DIMENSION: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (l = 0; l < n; l++)
                        {
                            vec[l] = radom.Next(1, 30);
                        }
                        for (l = 0; l < n; l++)
                        {
                            Console.Write("[" + vec[l] + "]");
                        }
                        Console.WriteLine("");
                        for (l = 0; l < n; l++)
                        {
                            if (vec[l] % 2 == 1)
                            {
                                Console.Write("[" + vec[l] + "]");
                            }
                            else
                            {
                                vec[l] = l;
                                Console.Write("[" + "X" + "]");
                            }
                            Console.Write("");
                        }

                        break;

                    case 0:
                        Console.WriteLine("***************************************************************************************************");

                        Console.Clear();
                        Console.Write("NOS VEMOS AL AÑO !!!");
                        break;
                    default:
                        Console.WriteLine("valor Incorrecto");
                        Console.WriteLine("***************************************************************************************************");

                        break;
                }
                Console.ReadKey();
                Console.WriteLine("***********************************************************************************************************");

            }
            while (opcion != 0);
        }
    }
}
