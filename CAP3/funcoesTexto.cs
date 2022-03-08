using static System.Console;
using System;
using System.Linq;

namespace livrocsharp
{
    class funcoesTexto
    {
        static void Main(string[] args)
        {
            WriteLine("      Funções de Textos      ");
            string empresa = "      Microsoft Corporation     ";

            WriteLine("TRIM - retira os espaçoes em branco antes e depois da expressão");
            WriteLine($"Nome sem espaços: {empresa.Trim()}");
            WriteLine("Length - retorna a quantidade de caracteres");
            WriteLine($"Tamanho do texto: {empresa.Length}");
            empresa = empresa.Trim();
            WriteLine($"Tamanho após o Trim(): {empresa.Length}");

            WriteLine("ToUpper - converte todo os caracteres para maiúsculo");
            WriteLine($"Converte para maiúsculo: {empresa. ToUpper()}");

            WriteLine("ToLower - converte todo os caracteres para minúsculo");
            WriteLine($"Converte para minúsculo: {empresa.ToLower()}");

            var nomeUpper = "AIRTON SENNA";
            var nomeLower = "airton senna";
            // comp aração 1
            if ( nomeUpper == nomeLower)
            WriteLine("1 - nomes iguais");
            else
            WriteLine("1 - nomes diferentes");
            // comp aração 2
            if ( nomeUpper.ToLower() == nomeLower)
            WriteLine("2 - nomes iguais");
            else
            WriteLine("2 - nomes diferentes");
            // comp aração 3
            if (nomeUpper.Equals( nomeLower, StringComparison.OrdinalIgnoreCase))
            WriteLine("3 - nomes iguais");
            else
            WriteLine("3 - nomes diferentes");

            WriteLine("Remove - extrai x caracteres a partir da esquerda da expressão");
            WriteLine($"texto esquerdo: { empresa. Remove(9)}");
            WriteLine("Captura apenas o primeiro nome das pessoas");
            string[] nomes = {"Fabricio dos Santos", "José da Silva", "Roberta Brasil"};
            foreach(var n in nomes)
            {
                WriteLine($"{ n. Remove(n.IndexOf(" "))}");
                
            }      
            WriteLine("Replace - troca o conteúdo da expressão");
            WriteLine($"texto atual: {empresa}");
            var
            novaEmpresa = empresa.Replace("Microsoft", "Google");
            WriteLine($"texto trocado: { novaEmpresa}");
            WriteLine("Split - divide e extrai cada palavra em um array");
            string NivelLivro = "ESte livro é básico de c#.";
            string[] blocos = NivelLivro.Split(' ');
            var contador = 1;
            foreach(var exp in blocos)
            {
                WriteLine($"texto {contador++}: {exp}");
            }
            
            WriteLine($"Qtde de palavras: {blocos.Count()}");
            WriteLine("Substring é usado para extrair parte do texto");
            
            WriteLine(NivelLivro.Substring(5, 14));
            string[] cesta = {"5 Laranjas", "10 Goiabas vermelhas", "5 Pêssegos doces", "5 Bananas"};
            int qtde = 0;
            foreach(var p in cesta)
            {
                // p.IndexOf(“ “) +1 retorna a posição inicial logo após o número
                // ex: 5 Laranjas = posição 1+1 = 2
                WriteLine($"{ p.Substring(p.IndexOf(" ") +1 )}");
                //Ler apenas os numeros para somar na varialvel qtde
                qtde += Convert.ToInt32(p.Substring(0, p.IndexOf(" ")));
            }
            WriteLine($"Qtde total: {qtde:n0}");
            WriteLine("IsNullOrEmpty verifica se a string está nula ou vazia");
            string nome = "Abraao";
            string ultimoNome = "Junior";
            string nomeDoMeio = null;

            if(!String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(nomeDoMeio) && !String.IsNullOrEmpty(ultimoNome))
            {
                WriteLine($"Nome completo: {nome} {nomeDoMeio} {ultimoNome}");
            }
            else if(!String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(nomeDoMeio))
            {
                WriteLine($"Nome e Sobrenome: {nome} {nomeDoMeio}");
            }
            else //(!String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(ultimoNome))
            {
                WriteLine($"Nome e ultimo nome: {nome} {ultimoNome}");
            }
        }
    }
}