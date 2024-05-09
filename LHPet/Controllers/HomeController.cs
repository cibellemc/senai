using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    public IActionResult Index()
    {
        Cliente cliente1 = new(01, "Cibelle", "123.456.789-00", "cibelle02@gmail.com", "Sakura");
        Cliente cliente2 = new(02, "Kaic", "213.456.789-00", "kaic02@gmail.com", "Sophia");
        Cliente cliente3 = new(03, "Marcos", "313.456.789-00", "marcos02@gmail.com", "Raul");
        Cliente cliente4 = new(04, "Edmilson", "013.456.789-00", "edmilson02@gmail.com", "Fujão");
        Cliente cliente5 = new(05, "Maria", "113.456.789-00", "maria02@gmail.com", "Nina");

        List<Cliente> listaClientes = [];
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new(01, "C# PET S / A", "14.182.102 / 0001 - 80", "c - sharp@pet.org");
        Fornecedor fornecedor2 = new(02, "CtrlAlt Dog", "15.836.698 / 0001 - 57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new(03, "BootsPet INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new(04, "TikTok Dogs", "87.945.350 / 0001 - 09", "noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new(05, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us");

        List<Fornecedor> listaFornecedores = [];
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
