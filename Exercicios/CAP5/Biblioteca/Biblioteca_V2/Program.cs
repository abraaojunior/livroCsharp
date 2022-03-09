using System;
using static System.Console;
using Libraryclass;

namespace Biblioteca_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            //iniciando classe com herança
            Revistas MinhasRevistas = new Revistas(3,2021);
            //iniciando as outras propriedades herdadas
            MinhasRevistas.Autor = "Microsoft";
            MinhasRevistas.Titulo = "MSDN Magazine";
            MinhasRevistas.Paginas = 20;
            MinhasRevistas.Status = true;
            //imprimindo os valores de minha classe
            WriteLine("Revista Mes: "+ MinhasRevistas.MesPublicacao);
            WriteLine("Revista Ano: "+ MinhasRevistas.AnoPublicacao);
            WriteLine("Revista Autor: "+ MinhasRevistas.Autor);
            WriteLine("Revista Titulo: "+ MinhasRevistas.Titulo);
            WriteLine("Revista Status: "+ MinhasRevistas.Status);
            WriteLine();
            //iniciando a classe com o construtor nulo
            Biblioteca MinhaBiblioteca = new Biblioteca();
            //quando inicializo com o construtor vazio, tenho a nessecidade 
            //de setar o valor da propriedade
            MinhaBiblioteca.Autor = "Des Dearlove";
            MinhaBiblioteca.Titulo = "O estilo Bil Gates de Gerir";
            MinhaBiblioteca.Paginas = 203;
            MinhaBiblioteca.Status = true;
            //imprimindo os valores de minha classe
            WriteLine("Autor: "+MinhaBiblioteca.Autor);
            WriteLine("Titulo: "+MinhaBiblioteca.Titulo);
            WriteLine("Paginas: "+MinhaBiblioteca.Paginas);
            WriteLine("Status: "+MinhaBiblioteca.Status);
            WriteLine();
            //Inicializando nossa classe com o novo construtor
            Biblioteca MeusLivros = new Biblioteca("Juan Garcia Sola", "Linguagem C", 296, true);
            //imprimindo os valores de minha classe
            WriteLine("Autor: "+ MeusLivros.Autor);
            WriteLine("Titulo: "+MeusLivros.Titulo);
            WriteLine("Paginas: "+MeusLivros. Paginas);
            WriteLine("Status: "+MeusLivros.Status);
            WriteLine();


        }
    }
}