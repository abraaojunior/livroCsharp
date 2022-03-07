//namespace que ira conter a classe de controle dos livros e metodos

namespace Libraryclass
{
    //principal classe de controle de livros na biblioteca
    public class Biblioteca
    {
        private string _Titulo; //recebe o titulo do livro
        private string _Autor; //recebe nome do autor
        private int _Paginas; //recebe num de paginas do livro
        private bool _Status; //recebe saindo (FALSE)    ou entrando (TRUE)

        public Biblioteca()//contrutor sem parametros
        {
            
        }
        public  Biblioteca(string Titulo, string Autor, int Paginas, bool Status)
        {
            _Titulo = Titulo;
            _Autor = Autor;
            _Paginas = Paginas;
            _Status = Status;
        }
        public string Titulo
        {
            get{return _Titulo;}
            set{_Titulo = value;}
        }
        public string Autor
        {
            get{return _Autor;}
            set{_Autor = value;}
        }
        public int Paginas
        {
            get{return _Paginas;}
            set{_Paginas = value;}
        }
        public bool Status
        {
            get{return _Status;}
            set{_Status = value;}
        }

    }
}