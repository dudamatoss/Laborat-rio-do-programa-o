using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class ClienteController : Controller
{
    private static List<Cliente> clientes = new List<Cliente>();

    [HttpGet]

    public ActionResult<List<Cliente>> Get()
    {
        return clientes;
    }

    [HttpGet("{id}")]
    public ActionResult<Cliente> Get(int id)
    {
        Cliente cliente = null;
        foreach (var c in clientes)
        {
            if (c.Id == id)
            {
                cliente = c;
                break;

            }
        }
        if (cliente == null)
        {
            return NotFound();
        }
        return cliente;
    }
    [HttpPost]
    public ActionResult Post(Cliente cliente)
    {
        cliente.Id = clientes.Count + 1;
        clientes.Add(cliente);
        return Created();
    }
    [HttpPut("{id}")]
    public ActionResult Put(int id, Cliente clienteAtualizado)
    {
        Cliente cliente = null;
        foreach (var c in clientes)
        {
            if (c.Id == id)
            {
                cliente = c;
                break;

            }
        }
        if (cliente == null)
        {
            return NotFound();
        }
        cliente.Nome = clienteAtualizado.Nome;
        cliente.Email = clienteAtualizado.Email;
        cliente.Telefone = clienteAtualizado.Telefone;
        return NoContent();
    }
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        Cliente clienteRemover = null;
        foreach (var c in clientes)
        {
            if (c.Id == id)
            {
                clienteRemover = c;
                break;

            }
        }
        if (clienteRemover == null)
        {
            return NotFound();
        }
        clientes.Remove(clienteRemover);
        return NoContent();
    }
}