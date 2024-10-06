using ApiDesdeCero.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiDesdeCero.Controllers
{
    [ApiController]
    [Route("Cliente")]
    public class ClienteController : ControllerBase
    {
        //Creacion de API crear
        [HttpGet] //Solicitar Informacion
        [Route("Listar")] //Crear Ruta es decir URL
        public dynamic ListarCliente()
        {
            //Todo el Codigo
            List<Cliente> lista = new List<Cliente>()
            {
                new Cliente
                {
                    id = "1",
                    nombre="Erick",
                    Edad="25",
                    correo="erick@gmail.com"
                },
                new Cliente
                {
                    id = "2",
                    nombre="Pepe",
                    Edad="19",
                    correo="pepe@gmail.com"
                }
            };
            return lista;
   
        }

        [HttpPost] //Solicitar Informacion
        [Route("Guardar")] //Crear Ruta es decir URL
        public dynamic GuardarCliente(Cliente cliente)
        {
            //Guarda en la DB y le asigna un ID
            cliente.id = "3"; //Solo guardado en memoria

            return new
            {
                success = true,
                message = "Cliente Registrado con Exito",
                result = cliente
            };
        }

        
    }
}
