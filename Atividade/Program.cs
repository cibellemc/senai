using Atividade;

float val_pag;

Console.WriteLine("Informar nome: ");
string var_Nome = Console.ReadLine();

Console.WriteLine("Informar endereço");
string var_Endereco = Console.ReadLine();

Console.WriteLine("Pessoa Física (f) ou Jurídica (j)?");
string var_tipo = Console.ReadLine();

if (var_tipo == "f")
{
    // --- Pessoa Física ----
    Pessoa_Fisica pf = new()
    {
        Nome = var_Nome,
        Endereco = var_Endereco
    };

    Console.WriteLine("Informar CPF:");
    pf.Cpf = Console.ReadLine();

    Console.WriteLine("Informar RG:");
    pf.Rg = Console.ReadLine();

    Console.WriteLine("Informar valor de compra:");
    val_pag = float.Parse(Console.ReadLine());

    pf.Pagar_Imposto(val_pag);

    Console.WriteLine("\n\n-------- Pessoa Física ---------");
    Console.WriteLine("Nome ..........: " + pf.Nome);
    Console.WriteLine("Endereço ......: " + pf.Endereco);
    Console.WriteLine("CPF ...........: " + pf.Cpf);
    Console.WriteLine("RG ............: " + pf.Rg);

    Console.WriteLine("\nValor de compra: " + pf.Valor.ToString("C"));
    Console.WriteLine("Imposto .......: " + pf.Valor_imposto.ToString("C"));
    Console.WriteLine("Total a pagar : " + pf.Total.ToString("C"));
}

if (var_tipo == "j")
{
    // Pessoa Jurídica
    Pessoa_Juridica pj = new()
    {
        Nome = var_Nome,
        Endereco = var_Endereco
    };

    Console.WriteLine("Informar CNPJ:");
    pj.Cnpj = Console.ReadLine();

    Console.WriteLine("Informar Ie:");
    pj.Ie = Console.ReadLine();

    Console.WriteLine("Informar valor de compra:");
    val_pag = float.Parse(Console.ReadLine());

    pj.Pagar_Imposto(val_pag);

    Console.WriteLine("\n\n-------- Pessoa Jurídica ---------");
    Console.WriteLine("Nome ..........: " + pj.Nome);
    Console.WriteLine("Endereço ......: " + pj.Endereco);
    Console.WriteLine("CNPJ ..........: " + pj.Cnpj);
    Console.WriteLine("Ie ............: " + pj.Ie);

    Console.WriteLine("\nValor de compra: " + pj.Valor.ToString("C"));
    Console.WriteLine("Imposto .......: " + pj.Valor_imposto.ToString("C"));
    Console.WriteLine("Total a pagar : " + pj.Total.ToString("C"));
}
