//namespace que irá conger a classe de controle de livros e seus metodos

namespace Libraryclass
{
    //nova classe para controlar as revistas
    public class Revistas:Biblioteca
    {
     //   propriedades da classe
     private int _MesPublicacao;
     private int _AnoPublicacao;
     //contrutor da classe
     public Revistas(int MesPublicacao, int AnoPublicacao)
     {
         _MesPublicacao = MesPublicacao;
         _AnoPublicacao = AnoPublicacao;
     }
     public int MesPublicacao
     {
         get{return _MesPublicacao;}
         set{MesPublicacao = value;}
     }
     public int AnoPublicacao
     {
         get{return _AnoPublicacao;}
         set{AnoPublicacao = value;}
     }
    }
    //principal classe de controle de livros na Biblioteca
    public class Biblioteca
    {
        private string _Titulo; //recebe o titulo do livro
        private string _Autor; //recebe o nome do autor
        private int _Paginas; //recebe o num de paginas
        private bool _Status; //recebe (FALSE)saindo ou (TRUE)entrando

        public Biblioteca()
        {

        }
        public Biblioteca(string Titulo, string Autor, int Paginas, bool Status)
        {
            _Titulo = Titulo;
            _Autor = Autor;
            _Paginas = Paginas;
            _Status = Status;
        }
        public string Titulo
        {
            get set
        }
        

    }
}