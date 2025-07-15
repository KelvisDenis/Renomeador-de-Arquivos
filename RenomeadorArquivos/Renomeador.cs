using System;
using System.IO;

namespace RenomeadorArquivos
{
    public static class Renomeador
    {
        public static void RenomearArquivos(string caminho)
        {
            if (!Directory.Exists(caminho))
                throw new DirectoryNotFoundException("A pasta não foi encontrada.");

            string[] arquivos = Directory.GetFiles(caminho);

            Array.Sort(arquivos); 
            int contador = 1;

            foreach (var arquivo in arquivos)
            {
                string extensao = Path.GetExtension(arquivo);
                string novoNome = contador.ToString("D2") + extensao;
                string novoCaminho = Path.Combine(caminho, novoNome);

                if (File.Exists(novoCaminho))
                    throw new IOException($"O arquivo {novoNome} já existe!");

                File.Move(arquivo, novoCaminho);
                contador++;
            }
        }
    }
}
