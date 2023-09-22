using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cliente
{
    public int clidocumento { get; set; }
    public string clinombre { get; set; }
    public string clidireccion { get; set; }
    public string clitelefono { get; set; }
    public string clicorreo { get; set; }
}

public class Factura
{
    public int facnumero { get; set; }
    public DateTime facfecha { get; set; }
    public int faccliente { get; set; }
    public decimal facvalortotal { get; set; }
    public int facvendedor { get; set; }
    public int clifk { get; set; }
}

public class FacturaDetalle
{
    public int facnumero { get; set; }
    public int facproducto { get; set; }
    public int faccantidad { get; set; }
}

public class Producto
{
    public int codigo { get; set; }
    public string nombre { get; set; }
    public decimal precio { get; set; }
    public int cantidad { get; set; }
}

public class Vendedor
{
    public string venuusuario { get; set; }
    public string venpassword { get; set; }
}
