using System;
using System.Collections.Generic;

namespace PIZZARIA_API.Models;

public partial class TelefoneCliente
{
    public string CpfCliente { get; set; } = null!;

    public string Telefone { get; set; } = null!;

    public virtual Cliente CpfClienteNavigation { get; set; } = null!;
}
