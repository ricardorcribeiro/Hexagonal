using ProductManager.Domain.Dtos.Base;

namespace ProductManager.Domain.Dtos
{
    public class ClientDto : DtoBase
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
    }
}
