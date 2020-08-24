using System;
namespace Workout
{
    public class Snack
    {
        int precio;
        int units;
            
        public Snack(int p, int u)
        {
            precio = p;
            units = u;
        }

        public void set_precio(int p)
        {
            precio = p;
        }

        public void set_un(int u)
        {
            units = u;
        }

        public int get_precio()
        {
            return precio;
        }

       public int get_units()
        {
            return units;
        }
    }
}

