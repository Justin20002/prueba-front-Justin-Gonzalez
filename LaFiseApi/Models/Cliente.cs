using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaFiseApi_.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cliente : ControllerBase
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public required string sexo {  get; set; }
        public decimal Ingresos     { get; set; }   

        public required List<CuentaBancaria> cuentas { get; set; }



    }
}
