using ProductManager.Domain.Entities.Base;
using ProductManager.Domain.Entities.Structs;

namespace ProductManager.Domain.Entities
{
    public class Client : EntityBase
    {
        public Client()
        {

        }
        public Client(string name, string cpf)
        {
            SetName(name);
            Cpf = cpf; 
        }
        public string Name { get; private set; }
        public Cpf Cpf { get; private set; }

        private void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("invalid name");
            if (name.Length < 3 && name.Length > 20)
                throw new Exception("zise name invalid");

            Name = name;
        }
    }
}
