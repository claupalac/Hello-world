using System;
using System.Collections.Generic;

namespace Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] snacks = new int[40,40];
            int num_casos = Convert.ToInt32(Console.ReadLine());
            int num_snacks=0;
            int presupuesto=0;
            int menor_precio = 64000;

            for (int i = 0; i<num_casos;i++)
            {
                num_snacks= Convert.ToInt32(Console.ReadLine());
                presupuesto = Convert.ToInt32(Console.ReadLine());

                for(int i2=0;i2<num_snacks;i2++)
                {
                    snacks[i2, 0]=Convert.ToInt32(Console.ReadLine());

                    if (menor_precio > snacks[i2, 0])
                    {
                        menor_precio = snacks[i2, 0];
                    }
                }

                for (int i3 = 0; i3 < num_snacks; i3++)
                {          
                    snacks[i3,1] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int total = 0;
            int indice = num_snacks - 1;
            int aux = 0;
            Console.WriteLine("precio menor:"); Console.WriteLine(menor_precio);
            while ((presupuesto > 0) & (presupuesto>menor_precio))
            {
                bool bandera = true;
                
                for (int k=indice; k>= 0; k--)   
                {
                    
                    if ((snacks[k, 1] > 0) & (snacks[k, 0] <= presupuesto))
                    {
                        if (bandera)
                        {
                            aux = snacks[k, 0];
                            bandera = false;
                        }
                        total += snacks[k, 0];
                        snacks[k, 1] = snacks[k, 1] - 1;  
                    }
                 
                        
                }
                presupuesto = presupuesto - aux;
                
            }

            Console.WriteLine(total);



            Console.ReadKey();
        }
    }
}
