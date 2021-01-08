using System;
using System.Collections.Generic;
using System.Text;

namespace GetHashCode_and_Equals.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        // Verifica se é igual apenas pelo e-mail
        public override bool Equals(object obj)
        {
            if (!(obj is Client))
                return false;

            Client other = obj as Client;

            return Email.Equals(other.Email);
        }

        // Verifica se é igual apenas pelo e-mail
        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
