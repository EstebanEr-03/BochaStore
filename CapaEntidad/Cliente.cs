using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
   /*     CREATE TABLE CLIENTE(
    IdCliente int primary key identity,
    Nombres varchar(100),
	Apelldios varchar(100),
	Correo varchar(100),
	Clave varchar(100),
	Reestrablecer bit default 0,
    FechaRegistro datetime default getdate()
)*/




        public int IdCliente { get; set; }  
        public string Nombres { get; set; }  
        public string Apelldios { get; set; }  
        public string Correo { get; set; }  
        public string Clave { get; set; }  
        public bool Reestrablecer { get; set; }  
    }
}
