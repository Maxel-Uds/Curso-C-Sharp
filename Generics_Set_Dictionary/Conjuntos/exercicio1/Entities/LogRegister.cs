using System;

namespace exercicio1.Entities
{
    public class LogRegister
    {
        public string Name { get; set; }
        public DateTime Moment { get; set; }

        public LogRegister(string name, DateTime moment) 
        {
            Name = name;
            Moment = moment;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is LogRegister))
            {
                return false;
            }

            LogRegister other = obj as LogRegister;
            return Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}