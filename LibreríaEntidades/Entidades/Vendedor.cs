﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreríaEntidades.Entidades
{
    public class Vendedor:Persona
    {
        public Vendedor(string nombre, string apellido, string dni, string email, string telefono, string direccion) : base(nombre, apellido, email, telefono, direccion)
        {
            DNI = dni;
        }

        public string DNI { get; set; }
    }
}
