namespace ExCursos
{
    public class Curso
    {
        public string Nome { get; private set; }
        public double CargaHoraria { get; private set; }
        public PublicoAlvo PublicoAlvo { get; set; }
        //public string PublicoAlvo { get; private set; }
        public double ValorCurso { get; private set; }

        public Curso() { }

        public Curso(string nome, double cargaHoraria, PublicoAlvo publicoAlvo, double valorCurso)
        {
            if (nome == string.Empty) //tenho que colocar isto aqui, para quando correr o teste, a exceção é lançada e passa o teste.
            {
                throw new ArgumentException();
            }
            if (nome == null) //posso colocar em vez de empty e null: if (string.IsNullOrEmpty)
            {
                throw new ArgumentException();
            }
            if (cargaHoraria < 1) 
            {
                throw new ArgumentException();
            }
            if (valorCurso < 1)
            {
                throw new ArgumentException();
            }
            Nome = nome;
            CargaHoraria = cargaHoraria;
            PublicoAlvo = publicoAlvo;
            ValorCurso = valorCurso;
        }
        
    }
}