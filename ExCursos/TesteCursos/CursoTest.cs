using ExCursos;
using ExpectedObjects;

namespace TesteCursos
{
    public class CursoTest
    {
        //verificar se um novo curso � criado com fact
        [Fact(DisplayName = "DeveCriarCurso")]
        public void DeveCriarCurso()
        {
            var cursoEsperado = new
            {
                Nome = "Software Developer",
                CargaHoraria = (double)1000.0,
                PublicoAlvo = PublicoAlvo.Estudante,
                ValorCurso = (double)100
            };
                       
            var curso = new Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.ValorCurso);

            cursoEsperado.ToExpectedObject().ShouldMatch(curso);
       
        }

        /*---------------verificar se todos os campos do curso s�o obrigat�rios ---------*/

        [Fact]
        public void CursoNaoDeveTerNomeVazio()
        {
            //objeto esperado:
            var cursoEsperado = new
            {
                Nome = "Software Developer",
                CargaHoraria = (double)1000.0,
                PublicoAlvo = PublicoAlvo.Estudante,
                ValorCurso = (double)100
            };

            //valida se h� uma exce��o:
            Assert.Throws<ArgumentException>(() => 
                new Curso(string.Empty, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.ValorCurso));
        }

        [Fact] 
        public void CursoNaoDeveTerNomeNulo()
        {
            //objeto esperado:
            var cursoEsperado = new
            {
                Nome = "Software Developer",
                CargaHoraria = (double)1000.0,
                PublicoAlvo = PublicoAlvo.Estudante,
                ValorCurso = (double)100
            };

            //valida se h� uma exce��o:
            Assert.Throws<ArgumentException>(() =>
                new Curso(null, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.ValorCurso));
        }

        //este m�todo substitui os dois anteriores
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void CursoNaoDeveTerNomeInvalido(string nomeInvalido) //vazio ou empty
        {
            //objeto esperado:
            var cursoEsperado = new
            {
                Nome = "Software Developer",
                CargaHoraria = (double)1000.0,
                PublicoAlvo = PublicoAlvo.Estudante,
                ValorCurso = (double)100
            };

            //valida se h� uma exce��o:
            Assert.Throws<ArgumentException>(() =>
                new Curso(nomeInvalido, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.ValorCurso));
        }

        //Se carga horario = 0, erro no teste, logo ir ao curso e lan�ar um argument exception para passar o teste
        [Fact]
        public void CursoNaoDeveTerCargaHorariaMenorQueUm()
        {
            //objeto esperado:
            var cursoEsperado = new
            {
                Nome = "Software Developer",
                CargaHoraria = (double)1000.0,
                PublicoAlvo = PublicoAlvo.Estudante,
                ValorCurso = (double)100
            };

            //valida se h� uma exce��o:
            Assert.Throws<ArgumentException>(() =>
                new Curso(cursoEsperado.Nome, 0, cursoEsperado.PublicoAlvo, cursoEsperado.ValorCurso));
        }

        //Testar v�rios valores de carga hor�ria:
        [Theory]
        [InlineData(0)]
        //[InlineData(1)] //este valor daria erro no teste pq � valido, se retirar,e tiver apenas valores inv�lidos o teste passa
        [InlineData(-2)]
        [InlineData(-99)]
        public void CursoNaoDeveTerCargaHorariaMenorQue1(double cargaHorariaInvalida)
        {
            //objeto esperado:
            var cursoEsperado = new
            {
                Nome = "Software Developer",
                CargaHoraria = (double)1000.0,
                PublicoAlvo = PublicoAlvo.Estudante,
                ValorCurso = (double)100
            };

            //valida se h� uma exce��o:
            Assert.Throws<ArgumentException>(() =>
                new Curso(cursoEsperado.Nome, cargaHorariaInvalida, cursoEsperado.PublicoAlvo, cursoEsperado.ValorCurso));
        }

        //Testar valor do curso
        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void CursoNaoDeveTerValorMenorQueUm(double valorCursoInvalido)
        {
            //objeto esperado:
            var cursoEsperado = new
            {
                Nome = "Software Developer",
                CargaHoraria = (double)1000.0,
                PublicoAlvo = PublicoAlvo.Estudante,
                ValorCurso = (double)100
            };

            //valida se h� uma exce��o:
            Assert.Throws<ArgumentException>(() =>
                new Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, valorCursoInvalido));
        }
    }
}