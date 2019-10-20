namespace bici
{
    class Bici
    {
        private string marca;
        private int current_velocity, velocities;
        public void print()
        {
            Console.WriteLine("Marca: {0}", marca);
            Console.WriteLine("Velocity: {0}", current_velocity);
        }
        public void init(string marca, int cv, int vs)
        {
            this.marca=marca;
            current_velocity=cv;
            velocities=vs;
        }
        public void sube()
        {
            current_velocity=current_velocity+1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bici bici=new Bici();
            bici.init("BiciMex", 2, 13);
            bici.sube();
            bici.print();
        }
    }
}