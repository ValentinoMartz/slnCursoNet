using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreríaEntidades.Entidades
{
    public class ClienteIndividuo:Persona
    {
        public ClienteIndividuo(string Nombre, string Apellido, string cuit, string Email, string Telefono, string Direccion) : base(Nombre, Apellido, Email, Telefono, Direccion)
        {
         CUIT = cuit;
        }

        public string CUIT { get; set; }
    }
}
