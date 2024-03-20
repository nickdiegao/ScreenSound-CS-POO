class ClasseExemplo
{
    public int numIndicador { get; set; }   
    public string nomeDoTitular {  get; set; }  
    public double saldoDaConta { get; set; }
    public int senhaDaConta { get; set; }
    
    public void exibirInformaçõesDaConta()
    {
        Console.WriteLine($"Número da conta: {numIndicador}");
        Console.WriteLine($"Nome do titular da conta: {nomeDoTitular}");
        Console.WriteLine($"Saldo da conta: {saldoDaConta}");
    }
} 