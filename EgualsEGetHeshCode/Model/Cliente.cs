using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgualsEGetHeshCode.Model
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

       
        public override bool Equals(object obj)

        {

            if (!(obj is Cliente))
            {

                return false;
            }
            else
            {
                Cliente other = obj as Cliente;
                return Email.Equals(other.Email);
            }
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
