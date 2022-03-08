using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace livrocsharp
{
    class funcoesDatas
    {
        static void Main(string[] args)
        {
            int dia = 12;
            int mes = 05;
            int ano = 2021;
            DateTime dtAniversario = new DateTime( ano, mes, dia);
            DateTime dtFesta = new DateTime( 2021, 08, 25);
            WriteLine("------ Funções de Datas -------");
            WriteLine($"Aniversário: {dtAniversario}");
            WriteLine($"Aniversário: {dtAniversario: dd/MM/yyyy}");
            WriteLine($"Aniversário: {dtAniversario: dddd/MMM/yyyy}");
            WriteLine($"Aniversário: {dtAniversario: dddd dd/ MMMM/yyyy}");
            DateTime hoje = DateTime.Today;
            WriteLine("TODAY - retorna a data atual");
            WriteLine($"TODAY: {hoje:dd/MM/yyyy}");
            DateTime DataHora = DateTime.Now;
            WriteLine("NOW - retorna a data e a hora atual");
            WriteLine($"Data e Hora: {DataHora: dd/MM/yyyy hh:mm:ss}");
            DateTime DataHoraNow = DateTime.Now;
            WriteLine("DAY / MONTH / YEAR - capturar o dia, mês e ano separadamente");
            WriteLine($"Dia: { DataHora. Day}");
            WriteLine($"Mês: {DataHoraNow.Month}");
            WriteLine($"Ano: {DataHoraNow.Year}");

            DateTime dtPedido = DateTime.Today;
            //adicionando 35 dias
            DateTime dtVencto = dtPedido.AddDays(35);
            //adicionando 2 meses
            DateTime dtPagto = dtVencto.AddMonths(2);
            WriteLine($"Pedido feito em {dtPedido:dd/MMM/YYYY} vence em {dtVencto:dd/MMM/yyy}");
            WriteLine($"Formatação completa: {dtVencto.ToLongDateString()}");
            WriteLine($"Formatação curta: {dtVencto.ToShortDateString()}");
            //dia da semana
            WriteLine($"dia da semana: {dtVencto.DayOfWeek}");
            WriteLine($"dia da semana em portugues: {dtVencto.ToString("dddd", new CultureInfo("pt-BR"))}");
            WriteLine($"Número do dia da semana: {(int)dtVencto.DayOfWeek}");
            //dia do ano
            WriteLine($"dia do ano: {dtVencto.DayOfYear}");
            //subtrair 2 datas
            var qtdeDias = dtPagto.Subtract(dtPedido);
            WriteLine($"Entre o pedido e o pgt foram: {qtdeDias:dd} dias");
            WriteLine("Conversão de Texto para Date");
            string dataTexto = "15/07/2021";
            DateTime dataTextoConvertida;
            // tentativa (TryParse) de conversão de dataTexto
            // caso dê certo a saída OUT será em dataTextoConvertida
            if( DateTime. TryParse(dataTexto, out dataTextoConvertida))
            {
                WriteLine("Data com conversão aceita");
            }
            else
            {
                WriteLine("Erro na conversão da data");
            }
            string dataTextoErrada = "15/metade do ano/2021";
            DateTime dataTextoErradaConvertida;
            if( DateTime.TryParse(dataTextoErrada, out dataTextoErradaConvertida))
            {
                WriteLine("Data com conversão aceita");            
            }
            else
            {
                WriteLine("Erro na conversão da data");
            }
            //continuar pg 73 -> DATAS EM OBJETOS
            // uso de Datas em Objetos
            var pedido = new Pedido
            {
                PedidoID = 1,
                DtPedido = DateTime.Today,
                DtPagto = DateTime.Today.AddDays(45),
                Valor = 1500
            };

            WriteLine($"Pedido: {pedido.PedidoID} - " +
                $"{pedido.DtPedido:dd/MMM/yyyy} - " +
                $"vencto: {pedido.DtVencimento():dd/MMM/yyyy} - " +
                $"dias atraso: {pedido.DiasAtraso().TotalDays} - " +
                $"valor: {pedido.Valor:n2} - " +
                $"multa: {pedido.Multa:n2}");
            
        }
    }
    public class Pedido
    {
        public int PedidoID { get; set; }
        public DateTime DtPedido { get; set; }
        public DateTime DtVencimento() => DtPedido.AddDays(30);
        public DateTime DtPagto { get; set; }
        public TimeSpan DiasAtraso() => DtPagto.Subtract(DtVencimento());
        public decimal Valor { get; set; }
        public decimal Multa => Valor * 0.10M;
    }
    /*Boxing é a conversão de um tipo de valor para o tipo de objeto
        ou qualquer tipo de interface implementado por este tipo de valor.
        O boxing está implícito.*/
    /*int percentual = 10;
    object objeto1 = percentual;

    /*Unboxing é o inverso do Boxing. É a conversão de um tipo de referência em
        tipo de valor. O unboxing extrai o valor do tipo de referência e 
        atribui a um tipo de valor. O unboxing é explícito, ou seja,
        precisamos declarar, por exemplo (int) objeto2.*/
    
    /*object objeto2 = 10;
    int desconto = (int)objeto2;*/

}