using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductManager.Domain.Entities.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Infra.SQLRepository.Converters
{
    public class CpfConverter : ValueConverter<Cpf, string>
    {
        public CpfConverter() : base(
            c => c,
            s => s
            )
        {

        }
    }
}
