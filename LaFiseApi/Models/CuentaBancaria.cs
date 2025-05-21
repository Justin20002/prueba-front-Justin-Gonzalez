using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaFiseApi_.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentaBancaria : ControllerBase
    {
        public int Id { get; set; }
        public string NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }  
        public int ClienteId { get; set; }
        public required Cliente Cliente { get; set; }    
    }
}
