using RenomeadorArquivos;



Console.WriteLine("Renomeador de Arquivos iniciado!");
Console.Write("Digite o caminho completo da pasta: ");
string? caminho = Console.ReadLine();

if (string.IsNullOrEmpty(caminho)) Console.WriteLine("Caminho inválido.");

try{
    Renomeador.RenomearArquivos(caminho);
    Console.WriteLine("Renomeação concluída com sucesso!");
}


catch (Exception ex){
    Console.WriteLine($"Erro: {ex.Message}");
}
