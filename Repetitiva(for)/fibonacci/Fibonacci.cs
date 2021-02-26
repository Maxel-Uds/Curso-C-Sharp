namespace fibonacci
{
    public class Fibonacci
    {
        public static int X ;
        public static int Y;
        public static int Z;

        public static int Sequecia() {
            return X;
        }

        public static void Soma() {
            X = Y + Z;
            Z = Y;
            Y = X;
        }
    }
}