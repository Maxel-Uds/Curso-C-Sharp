namespace exercicio2.Entities
{
    public class Studant
    {
        public int Number { get; set; }

        public Studant(int number)
        {
            Number = number;
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Studant other = obj as Studant;
            return Number.Equals(other.Number);
        }
    }
}