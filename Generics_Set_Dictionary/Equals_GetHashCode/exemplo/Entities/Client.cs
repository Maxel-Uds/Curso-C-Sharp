using System;

namespace exemplo.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Client))
            {
                throw new ArgumentException("O argumento não é um cliente!");
            }

            Client other = obj as Client;
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}