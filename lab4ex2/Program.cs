using System;


namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m, k. Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.
              Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i rezultatul.
              Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i rezultatul. .*/



            Console.WriteLine("Introduceti dimensiunea  pentru lungimea n a matricei: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti dimensiunea pentru lungimea  m a matricei: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti dimensiunea pentru dimensiunea k a matricei: ");
            int k = int.Parse(Console.ReadLine());

            int[,,] matrice = new int[n, m, k];



             AfisareMatrice( matrice,  n,  m,  k);
       

            Console.WriteLine("Suma matricei este:" + SumaElementeMatrice(matrice, n, m, k));

            Console.WriteLine("Elementul maxim al matricei este:" + MaximMatrice(matrice, n, m, k));
        }





            static void AfisareMatrice(int[,,] matrice, int n, int m, int k)
            {
                
                Console.WriteLine("\n" + "Introduceti elementele matricei3D: ");

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        for (int l = 0; l < k; l++)
                        {
                        matrice[i, j, l] = int.Parse(Console.ReadLine());
                         
                        }

                    }
                  

                }

                 Console.WriteLine("Matricea rezultata este:  ");
                
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        for (int l = 0; l < k; l++)
                        {
                            Console.Write("{0} ", matrice[i, j, l]);
                        }
                        Console.Write("\n");

                    }


                }

            }


            static int SumaElementeMatrice(int [,,] matrice,int n, int m, int k)
            { 
              int sumaMatrice = 0;
             
                for(int i = 0; i < n; i++) 
                {
                    for (int j = 0; j < m; j++)
                    {
                        for (int l = 0; l < k; l++)
                            {
                                sumaMatrice = sumaMatrice + matrice[i, j, l];

                            }
                    }


                }
                return sumaMatrice;

            }


        static int MaximMatrice(int[,,] matrice, int n, int m, int k)
        {
            int maximMatrice = matrice[0,0,0];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int l = 0; l < k; l++)
                    {
                       if (matrice[i, j, l] > maximMatrice)
                        {
                            maximMatrice = matrice[i, j, l];

                        }

                    }
                }

            }
            return maximMatrice;

        }

     }

 }
