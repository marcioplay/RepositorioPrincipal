using System;
using System.Globalization;
using CursoCSharpe2.ClassesEMetodos;
using System.Collections.Generic;
using System.Collections;
using static CursoCSharpe2.Exercicios.Uno;
using CursoCSharpe2.Exercicios;
using Encapsulamento4;
using Encapsulamento;
using Transportadora;
using static CursoCSharpe2.Exercicios.Celular;
using System.Linq;

namespace CursoCSharpe2.Exercicios
{
    public class Cantor
    {
        public string Nome;
        public int Idade;
        public double PrecoDisco;
    }
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;

    }

    public class Estoque
    {
        int Quantidade;

        public Estoque(int quantidade)
        {
            Quantidade = quantidade;
        }

        public void Solicitar(int valor)
        {
            if (valor > Quantidade)
            {
                throw new ArgumentException("Quantidade Não Disponivel");
            }

            Quantidade -= valor;
        }
    }
    public class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            // Validação antes de executar a operação
            if (valor > Saldo)
            {
                // Lançando uma Exceção caso o valor seja > do que o Saldo.
                throw new ArgumentException("Saldo Insuficiente");
            }

            Saldo -= valor;
        }
    }


    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int outronumero)
        {
            return num + outronumero;
        }

        public static int Subtracao(this int num, int outronumero)
        {
            return num - outronumero;
        }
    }

    delegate string StringOperacao(string s);

    delegate double Operacao(double x, double y);

    // Classe selada não permite "Herança".
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_407_033.65;
        }
    }

    class Avo
    {
        public virtual bool HonrarNomeFamilia() // Permitindo alteração no métidos usando o "virtual"
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public sealed override bool HonrarNomeFamilia() // Selando e reescrevendo o método usando "sealed override"
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        //public override bool HonrarNomeFamilia()
        //{
        //    return false;
        //}
    }

    //class SouFilho : SemFilho
    //{

    //}

    // Todos os metodos de uma interface, inplicitamente são abstratos e públicos
    interface OperacaoBinaria
    {
        int OperacaoInterface(int a, int b);
    }

    class Soma : OperacaoBinaria
    {
        public int OperacaoInterface(int a, int b)
        {
            return a + b;
        }
    }

    class Subtracao : OperacaoBinaria
    {
        public int OperacaoInterface(int a, int b)
        {
            return a - b;
        }
    }

    class Multi : OperacaoBinaria
    {
        public int OperacaoInterface(int a, int b)
        {
            return a * b;
        }
    }

    public class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Multi()
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach (var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.OperacaoInterface(a, b)}\n";
            }

            return resultado;
        }
    }

    public abstract class Celular
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return "Trim, trim, trim..";
        }

        public class Sansung : Celular
        {
            public override string Assistente()
            {
                return "Olá! meu nome é Bixby";
            }
        }

        public class Iphone : Celular
        {
            public override string Assistente()
            {
                return "Olá! meu nome é Siri";
            }
        }

        public class Motorola : Celular
        {
            public override string Assistente()
            {
                return "Olá, meu nome é kiko!";
            }
        }
    }
    public class Comida
    {
        public double Peso;

        public Comida(double peso)
        {
            Peso = peso;
        }

        public Comida() { }
    }
    public class Feijao : Comida
    {

    }

    public class Arroz : Comida
    {

    }

    public class Carne : Comida
    {


    }

    public class Pessoa
    {
        public double Peso;

        //public void Comer(Feijao feijao)
        //{
        //    Peso += feijao.Peso;
        //}

        //public void Comer(Arroz arroz)
        //{
        //    Peso += arroz.Peso;
        //}

        //public void Comer(Carne carne)
        //{
        //    Peso += carne.Peso;
        //}

        public void Comer(Comida comida)
        {
            Peso = comida.Peso;
        }
    }
    public class Bike : Transporte
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Acesso bike.");

            Console.WriteLine(InformacaoPublicaTransportadora);
            Console.WriteLine(CorTransporte);
            Console.WriteLine(RazaoSocial);

        }
    }

    public class JetSki
    {
        public readonly Transporte jet1 = new Transporte();

        public new void MeusAcessos()
        {
            Console.WriteLine("Acesso JetSki..");
            Console.WriteLine(jet1.InformacaoPublicaTransportadora);

        }
    }
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoNaoReconhecido..");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroDeCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia);
            // Console.WriteLine(UsaMuitoPhotoshop);

        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade4 amiga = new SubCelebridade4();

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoDistante...");
            Console.WriteLine(amiga.InfoPublica);
            // Console.WriteLine(amiga.CorDoOlho);
            //Console.WriteLine(amiga.NumeroDeCelular);
            //Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoFamilia);
            // Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }
    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
    }
    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"Cachorro {nome} inicicializado");
        }

        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{Nome} tem {Altura}cm de altura!";
        }
    }

    public class Gato : Animal
    {
        public string Cor { get; set; }

        public Gato(string nome) : base(nome)
        {
            Console.WriteLine($"Gato {nome} inicializado");
        }

        public Gato(string nome, string cor) : this(nome)
        {
            Cor = cor;
        }

        public override string ToString()
        {
            return $"O gato: {Nome} é de cor: {Cor}!";
        }

    }



    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int velocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = velocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                velocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                velocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                velocidadeAtual = novaVelocidade;
            }

            return velocidadeAtual;
        }

        public virtual int Acelerar() // Adicionado a palavra "virtual", você está sinalizando que o metodo pode ser subscrito
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }




    public class Uno : Carro
    { // Herdando da classe Carro
        public Uno() : base(200) // Criando o construtor e setando o valor
        {

        }

        public class Ferrari : Carro
        {
            public Ferrari() : base(350)
            {

            }

            public override int Acelerar() // Sobescrevendo um metodo pai, adicionando a palavra reservada "override"
            {                              // Necessário também inserir a palavra reservada "virtual" no metodo pai
                return AlterarVelocidade(15);
            }

            // Ocultar o metodo da classe pai usando a palavra "new"
            public new int Frear()
            {
                return AlterarVelocidade(-15);
            }

        }

        public class Porsche : Carro
        {
            public Porsche() : base(380)
            {

            }

            public override int Acelerar()
            {
                return AlterarVelocidade(20);
            }

            public new int Frear()
            {
                return AlterarVelocidade(-20);
            }

        }
    }


    public class Curso
    {
        public string Nome;
        public string Professor;
        public double Preco;

        public Curso(string nome, string professor, double preco)
        {
            Nome = nome;
            Professor = professor;
            Preco = preco;
        }
    }
    public class Game
    {
        public string Titulo;
        public double Preco;

        public Game(string titulo, double preco)
        {
            Titulo = titulo;
            Preco = preco;
        }
    }
    public class Produto2
    {
        public string Nome;
        public double Preco;

        public Produto2(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            Produto2 outroProduto = (Produto2)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode()
        {
            return Nome.Length;
        }
    }

    public class Dependente
    {
        public string Nome;
        public int Idade;
    }
    public struct SPonto
    {
        public int X;
        public int Y;
    }

    public class CPonto
    {
        public int X;
        public int Y;
    }
    interface Ponto
    {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }
    public enum Genero2 { Acao, Aventura, Terro, Animacao, Comedia };

    public class Filme
    {
        public string Titulo;
        public Genero2 GeneroDoFilme;
    }
    public class Cliente
    {
        public string Nome;
        public readonly DateTime DatadeNascimento; // A palavra "readonly", faz com que o valor atribuido no construtor não seja alterado. Em outras palavras, omutável

        public Cliente(string nome, DateTime dataDeNascimento)
        {
            Nome = nome;
            DatadeNascimento = dataDeNascimento;
        }

        public string GetDataDeNascimento()
        {
            return string.Format("{0}/{1}/{2}", DatadeNascimento.Day, DatadeNascimento.Month, DatadeNascimento.Year);
        }

        public Cliente()
        {

        }
    }

    public class FolhaFunncionario
    {
        string nome;
        double salario;
        double desconto;

        public string Nome
        {
            get
            {
                return "Nome: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        public double Preco { get; set; }

        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco);
        }

        public FolhaFunncionario(string nome, double salario, double desconto)
        {
            this.nome = nome;
            this.salario = salario;
            this.desconto = desconto;
        }

        public FolhaFunncionario()
        {

        }


    }


    public class CarroOpcional
    {
        double desconto = 0.1;
        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        // Propriedades autoimplementadas
        public double Preco { get; set; }

        // Somente Leitura

        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); // Lambda
        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public CarroOpcional()
        {

        }
    }
    public class Livro
    {
        string Titulo;
        string Escritor;
        string Genero;
        int Ano;

        public Livro(string titulo, string escritor, string genero, int ano)
        {
            Titulo = titulo;
            Escritor = escritor;
            Genero = genero;
            Ano = ano;
        }

        public Livro()
        {

        }

        public string GetTitulo()
        {
            return Titulo;
        }

        public void SetTitulo(string titulo)
        {
            Titulo = titulo;

        }

        public string GetEscritor()
        {
            return Escritor;
        }

        public void SetEscritor(string escritor)
        {
            Escritor = escritor;
        }

        public string GetGenero()
        {
            return Genero;
        }

        public void SetGenero(string genero)
        {
            Genero = genero;
        }

        public int GetAno()
        {
            return Ano;
        }

        public void SetAno(int ano)
        {
            Ano = ano;
        }


        public class Moto
        {
            private string Marca;
            private string Modelo;
            private uint Cilindrada;

            public Moto(string marca, string modelo, uint cilindrada)
            {
                Marca = marca;
                Modelo = modelo;
                Cilindrada = cilindrada;

            }

            public Moto()
            {

            }

            public string GetMarca()
            {
                return Marca;
            }

            public void SetMarca(string marca)
            {
                Marca = marca;
            }

            public string GetModelo()
            {
                return Modelo;
            }

            public void SetModelo(string modelo)
            {
                Modelo = modelo;
            }

            public uint GetCilindrada()
            {
                return Cilindrada;
            }

            public void SetCilindrada(uint cilindrada)
            {
                Cilindrada = cilindrada;
            }
        }
        class Jogo
        {
            public string Titulo;
            public double Preco;
            public static double Desconto;// A Palavra static, faz com que o atributo pertença a classe e não ao atributo

            public Jogo(string titulo, double preco, double desconto)
            {
                Titulo = titulo;
                Preco = preco;
                Desconto = desconto;
            }

            public Jogo()
            {

            }

            public double CalcularDesconto()
            {
                return Preco - Preco * Desconto;
            }
        }
        class CalculadoraEstatica
        {
            // Metodo de classe ou metodo estático
            public static int Somar(int a, int b)
            {
                return a + b;
            }

            // Metodo de instância
            public int Multiplicar(int a, int b)
            {
                return a * b;
            }

            public static int Subtrair(int a, int b)
            {
                return a - b;
            }
        }


        class CalculadoraComum
        {
            public int Somar(int a, int b)
            {
                return a + b;


            }

            public int Subtrair(int a, int b)
            {
                return a - b;
            }

            public int Multiplicar(int a, int b)
            {
                return a * b;
            }

            public int Dividir(int a, int b)
            {
                return a / b;
            }
        }
        class Produto
        {
            public string Nome;
            public string Tipo;
            public double Peso;
            public double Preco;

            public Produto(string nome, string tipo, double peso, double preco)
            {
                Nome = nome;
                Tipo = tipo;
                Peso = peso;
                Preco = preco;
            }

            public Produto()
            {

            }

            public string ExibirProduto()
            {
                return string.Format($"Produto: {Nome}\nTipo: {Tipo}\nPeso: {Peso}\nPreço: {Preco}");
            }
        }
        //class Carro
        //{
        //    public string Modelo;
        //    public string Fabricante;
        //    public int Ano;

        //    public Carro(string modelo, string fabricante, int ano)
        //    {
        //        Modelo = modelo;
        //        Fabricante = fabricante;
        //        Ano = ano;
        //    }

        //    public Carro()
        //    {

        //    }

        //    public string ExibirEntrada()
        //    {
        //        return string.Format($"Modelo: {Modelo}\nFabricante: {Fabricante}\nAno: {Ano}");
        //    }
        //}

        class CalculadoraCadeia
        {
            int memoria;
            public CalculadoraCadeia Somar(int a)
            {
                memoria += a;
                return this;
            }

            public CalculadoraCadeia Multiplicar(int a)
            {
                memoria *= a;
                return this;
            }

            public CalculadoraCadeia Limpar()
            {
                memoria = 0;
                return this;
            }

            public CalculadoraCadeia Imprimir()
            {
                Console.WriteLine(memoria);
                return this;
            }

            public int Resultado()
            {
                return memoria;
            }
        }
        class Praticas
        {

            delegate double Soma(double a, double b);
            delegate void ImprimirSoma(double a, double b);

            static double MinhaSoma(double a, double b) // Função com a mesma assinatura do delegate "Soma""
            {
                return a + b;
            }

            static void MeuImprimirSoma(double a, double b) // Função com a mesma assinatura do delegate "ImprimirSoma"
            {
                Console.WriteLine(a + b);
            }
            public static int Somar(int a = 2, int b = 5)
            {
                return a + b;
            }
            public static void AlterarRefMarcio(ref int numero)
            {
                numero = numero + 3000;
            }

            public static void AlterarOutMarcio(out int numero)
            {
                numero = 0;
                numero = numero + 4000;
            }

            public static void AlterarRef(ref int numero)
            {
                numero = numero + 1000;
            }

            public static void AlterarOut(out int numero)
            {
                numero = 0;
                numero = numero + 15;
            }
            public static void CadastroCliente(string nome, int idade, string email)
            {
                Console.WriteLine("Nome: {0}\nIdade: {1}\nEmail: {2}", nome, idade, email);
            }
            public static void FormatarData(int dia, int mes, int ano)
            {
                Console.WriteLine("Data: {0:D2}/{1:D2}/{2}", dia, mes, ano);

            }
            // Exemplo de função parametos variáveis
            public static void Familia(params string[] familias)
            {
                foreach (var familia in familias)
                {
                    Console.WriteLine("Integrantes da Familia: {0}", familia);
                }
            }
            public static void Apresentar(params string[] pessoas)
            {
                foreach (var pessoa in pessoas)
                {
                    Console.WriteLine("Ola! {0}", pessoa);
                }
            }
            //public delegate int Operacao2(int x, int y);

            //public static int Somar2(int x, int y)
            //{
            //    return x + y;
            //}

            //public static string Calculadora2(Operacao op, int x, int y)
            //{
            //    var resultado = op(x, y);
            //    return "Resultado: " + resultado;
            //}

            int a = 10;
            int b = 20;
            public static void Main()
            {

                Console.WriteLine("***********************************");
                Console.WriteLine("      Praticas e Exercicios C#     ");
                Console.WriteLine("***********************************");


                // ***** Tópicos Avançados - Link#02  *****

                //var alunos = new List<Aluno>
                //{
                //    new Aluno(){Nome= "Pedro", Idade = 24, Nota = 8.0 },
                //    new Aluno(){Nome= "Andre", Idade = 21, Nota = 4.3 },
                //    new Aluno(){Nome= "Ana", Idade = 25, Nota = 9.5 },
                //    new Aluno(){Nome= "Jorge", Idade = 20, Nota = 5.5 },
                //    new Aluno(){Nome= "Ana", Idade = 21, Nota = 7.7 },
                //    new Aluno(){Nome = "Julia", Idade = 22, Nota = 7.5},
                //    new Aluno(){Nome = "Márcio", Idade = 18, Nota = 6.8},

                //};

                //var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
                //    Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

                //// Metodo que retorna Default caso não encontre o que se procura

                //var fulano = alunos.SingleOrDefault(alunos => alunos.Nome.Equals("Fulano"));
                //    if(fulano == null)
                //{
                //    Console.WriteLine("Aluno inexixtente");
                //}

                //var ana = alunos.First(alunos => alunos.Nome.Equals("Ana"));
                //    Console.WriteLine(ana.Nota);

                //var sicrano = alunos.FirstOrDefault(alunos => alunos.Nome.Equals("Sicrano"));
                //    if(sicrano == null)
                //{
                //    Console.WriteLine("Aluno inexistente");
                //}

                //var outraAluna = alunos.LastOrDefault(alunos => alunos.Nome.Equals("Ana"));
                //    Console.WriteLine(outraAluna.Nota);

                //var menotNota = alunos.Min(alunos => alunos.Nota);
                //Console.WriteLine($"Menor nota: {menotNota}");

                //var maiorNota = alunos.Max(alunos => alunos.Nota);
                //Console.WriteLine($"Maior nota: {maiorNota}");

                //var somatorioNotas = alunos.Sum(alunos => alunos.Nota);
                //Console.WriteLine($"Soma de notas: {somatorioNotas}");

                //var mediaNotas = alunos.Average(alunos => alunos.Nota);
                //Console.WriteLine($"Média notas: {mediaNotas.ToString("f2")}");

                //var mediaAlunosAprovador = alunos.Where(alunos => alunos.Nota >= 7).Average(aluno => aluno.Nota);
                //Console.WriteLine($"Média notas alunos aprovados : {mediaAlunosAprovador.ToString("f2")}");

                // ***** Tópicos Avançados - Link#01  *****

                //var cantores = new List<Cantor>
                //{
                //    new Cantor(){Nome = "Phill Colins", Idade = 78, PrecoDisco = 120.90 },
                //    new Cantor(){Nome = "Jon Secada", Idade = 65, PrecoDisco = 90.90 },
                //    new Cantor(){Nome = "a-ha", Idade = 67, PrecoDisco = 89.78 },
                //    new Cantor(){Nome = "Bee Gees", Idade = 81, PrecoDisco = 130.89 },
                //    new Cantor(){Nome = "Pet Shop Boys", Idade = 59, PrecoDisco = 140.88 }

                //};

                //// Filtrando por valor
                //Console.WriteLine("### Disco com preço mias em conta ###");
                //var menoresPrecos = cantores.Where(a => a.PrecoDisco < 90.00);
                //foreach (var menor in menoresPrecos)
                //{
                //    Console.WriteLine(menor.Nome);
                //}

                //Console.WriteLine("### Cantores mais Jovens ###");

                //var cantoresMaisJovens = cantores.Where(a => a.Idade <= 65).OrderBy(a => a.Nome);
                //foreach(var cantor in cantoresMaisJovens)
                //{
                //    Console.WriteLine(cantor.Nome);
                //}
                //var alunos = new List<Aluno>
                //{
                //    new Aluno(){Nome= "Pedro", Idade = 24, Nota = 8.0 },
                //    new Aluno(){Nome= "Andre", Idade = 21, Nota = 4.3 },
                //    new Aluno(){Nome= "Ana", Idade = 25, Nota = 9.5 },
                //    new Aluno(){Nome= "Jorge", Idade = 20, Nota = 5.5 },
                //    new Aluno(){Nome= "Ana", Idade = 21, Nota = 7.7 },
                //    new Aluno(){Nome = "Julia", Idade = 22, Nota = 7.5},
                //    new Aluno(){Nome = "Márcio", Idade = 18, Nota = 6.8},

                //};

                //// Filtrando os alunos usando critérios de notas >= 7

                //Console.WriteLine("===Aprovados===========");

                //var aprovados = alunos.Where(a => a.Nota >= 7.0).OrderBy(a => a.Nome);
                //foreach (var aluno in aprovados)
                //{
                //    Console.WriteLine(aluno.Nome);
                //}

                //Console.WriteLine("### Chamada ###");

                //var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
                //foreach(var aluno in chamada)
                //{
                //    Console.WriteLine(aluno);
                //}
                //Console.WriteLine("Nome dos alunos aprovados");

                //var alunosAprovados =
                //    from aluno in alunos
                //    where aluno.Nota >= 7
                //    orderby aluno.Idade
                //    select aluno.Nome;
                //foreach(var aluno in alunosAprovados)
                //{
                //    Console.WriteLine(aluno);
                //}

                // ***** Explorando API  - Usando TimeSpan  *****

                //var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
                //Console.WriteLine(intervalo);

                //Console.WriteLine($"Minutos: {intervalo.Minutes}" );
                //Console.WriteLine($"Intervalo em minutos: {intervalo.TotalMinutes}");

                //var largada = DateTime.Now;
                //var chegada = DateTime.Now.AddMinutes(15);

                //var tempo = chegada - largada;
                //Console.WriteLine("Duração: " + tempo);

                //Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8)));
                //Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(8)));

                //Console.WriteLine("ToString 1 : " + intervalo.ToString("g"));
                //Console.WriteLine("ToString 2 : " + intervalo.ToString("G"));
                //Console.WriteLine("ToString 3 : " + intervalo.ToString("c"));

                //Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03").TotalMilliseconds);

                // ***** Explorando API  - Usando DateTime  *****

                //var dateTime = new DateTime(year: 2022, month: 8, day: 17);
                //Console.WriteLine(dateTime.Day);
                //Console.WriteLine(dateTime.Month);
                //Console.WriteLine(dateTime.Year);
                //Console.WriteLine($"Dia: {dateTime.Day}\nMês: {dateTime.Month}\nAno: {dateTime.Year}");

                //// Sem horas

                //var hoje = DateTime.Today;
                //Console.WriteLine(hoje);

                //// Com horas

                //var diaAtual = DateTime.Now;
                //Console.WriteLine(diaAtual);
                //Console.WriteLine("Hora: " + diaAtual.Hour);
                //Console.WriteLine("Minutes: " + diaAtual.Minute);

                //// Adicionando dia

                //var amanha = diaAtual.AddDays(1);
                //Console.WriteLine(amanha);

                //// Subtraindo dia

                //var ontem = diaAtual.AddDays(-1);
                //Console.WriteLine(ontem);


                //Console.WriteLine(diaAtual.ToString("dd"));
                //Console.WriteLine(diaAtual.ToString("d"));
                //Console.WriteLine(diaAtual.ToString("D"));
                //Console.WriteLine(diaAtual.ToString("g"));
                //Console.WriteLine(diaAtual.ToString("G"));


                // ***** Explorando API  - Usando Path  *****

                //var arquivo = @"E:\Curso C# 2022\PastaCSharp\exemplo_path_arquivo.txt";
                //var pasta = @"E:\Curso C# 2022\PastaCSharp";

                //if (!File.Exists(arquivo))
                //{
                //    using (StreamWriter sw = File.CreateText(arquivo))
                //    {
                //        sw.WriteLine("Um novo arquivo criado");
                //    }
                //}

                //if (!Directory.Exists(pasta))
                //{
                //    Directory.CreateDirectory(pasta);
                //}

                //Console.WriteLine(Path.GetExtension(arquivo));
                //Console.WriteLine(Path.GetFileName(arquivo));
                //Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));
                //Console.WriteLine(Path.GetDirectoryName(arquivo));
                //Console.WriteLine(Path.HasExtension(arquivo));

                //Console.WriteLine(Path.HasExtension(pasta));
                //Console.WriteLine(Path.GetFullPath(pasta));
                //Console.WriteLine(Path.GetPathRoot(pasta));


                // ***** Explorando API  - Arquivo: Usando DirectotyInfo  *****

                //var dirProjeto = @"E:\Curso C# 2022\PastaCSharp";
                //var dirInfo = new DirectoryInfo(dirProjeto);

                //if (!dirInfo.Exists)
                //{
                //    dirInfo.Create();
                //}

                //Console.WriteLine("Arquivos ===============");
                //var arquivos = dirInfo.GetFiles();

                //foreach(var arquivo in arquivos)
                //{
                //    Console.WriteLine(arquivo);
                //}

                //Console.WriteLine("\n==Diretórios =============");
                //var pastas = dirInfo.GetDirectories();

                //foreach(var pasta in pastas)
                //{
                //    Console.WriteLine(pasta);
                //}

                // ***** Explorando API  - Arquivo: Trabalhando com Diretórios  *****

                //var novoDir = @"E:\Curso C# 2022\PastaCSharp";
                //var novoDirDestino = @"E:\Curso C# 2022\PastaCSharpDestino";
                //var dirProjeto = @"E:\E:\Curso C# 2022\CursoCSharp";

                //if (Directory.Exists(novoDir))
                //{
                //    Directory.Delete(novoDir, true);
                //}

                //if (Directory.Exists(novoDirDestino))
                //{
                //    Directory.Delete(novoDirDestino, true);
                //}

                //Directory.CreateDirectory(novoDir);
                //Console.WriteLine(Directory.GetCreationTime(novoDir));

                // ***** Explorando API  - Arquivo: Usando FileInfo  *****

                //var caminhoOrigem = @"E:\Curso C# Completo Orientacao a Objetos\arq_origem.txt";
                //var caminhoDestino = @"E:\Curso C# Completo Orientacao a Objetos\arq_destino.txt";
                //var caminhoCopia = @"E:\Curso C# Completo Orientacao a Objetos\arq_copia.txt";


                //using (StreamWriter sw = File.CreateText(caminhoOrigem))
                //{
                //    sw.WriteLine("Arquivo original");
                //}

                //FileInfo origem = new FileInfo(caminhoOrigem);
                //Console.WriteLine(origem.Name);
                //Console.WriteLine(origem.IsReadOnly);
                //Console.WriteLine(origem.FullName);
                //Console.WriteLine(origem.Extension);

                //origem.CopyTo(caminhoCopia);
                //origem.MoveTo(caminhoDestino);

                // ***** Explorando API  - Arquivo: Lendo Dados  *****
                //var path = @"E:\Curso C# Completo Orientacao a Objetos\lendo_arquivo.txt";

                //if (!File.Exists(path)) 
                //using (StreamWriter sw = File.AppendText(path))
                //{
                //    sw.WriteLine("Produto;Preço;Qtde");
                //    sw.WriteLine("Caneta Bic Preta;3.59;89");
                //    sw.WriteLine("Borracha Branca;2.89;27");
                //}

                //try
                //{
                //    using (StreamReader sr = new StreamReader(path  + ".txt"))
                //    {
                //        var texto = sr.ReadToEnd();
                //        Console.WriteLine(texto);
                //    }
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);

                //}

                // ***** Explorando API  - Arquivo: Excrevendo Dados  *****

                //var path = @"E:\Curso C# Completo Orientacao a Objetos\primeiro_arquivo.txt";

                //if (!File.Exists(path))
                //{
                //    // Criando arquivo
                //    using (StreamWriter sw = File.CreateText(path))
                //    {
                //        sw.WriteLine("Esse é");
                //        sw.WriteLine("o nosso");
                //        sw.WriteLine("primeiro");
                //        sw.WriteLine("arquivo");
                //    }
                //}

                //using (StreamWriter sw = File.AppendText(path))
                //{
                //    sw.WriteLine("");
                //    sw.WriteLine("É possíve");
                //    sw.WriteLine("adiocnar");
                //    sw.WriteLine("mais texto");
                //}

                // ***** Exceções  - Criando Excecões Personalizadas  *****


                // ***** Exceções  - Exceções de tratamento e Erro  *****

                //var item1 = new Estoque(1850);

                //try
                //{
                //    item1.Solicitar(1700);
                //    Console.WriteLine("Retirada com Sucesso.");
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);

                //}
                //finally
                //{
                //    Console.WriteLine("Obrigado");
                //}

                //var conta = new Conta(1_223.45);

                //try
                //{
                //    conta.Sacar(1100);
                //    Console.WriteLine("Retirada com sucesso");
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}
                //finally
                //{
                //    Console.WriteLine("Obrigado!");
                //}


                // ***** Métodos e Funções - Métodos de Extensão  *****

                //int numero = 5;
                //Console.WriteLine(numero.Soma(5));
                //Console.WriteLine(numero.Subtracao(2));

                // ***** Métodos e Funções - Passando Delegates como Parâmetros  *****

                // Assistir novamente. Não rodou corretamente.

                //Operacao2 subtracao = (int x, int y) => x - y;
                //Console.WriteLine(subtracao(10, 5));

                //Console.WriteLine(Calculadora2(subtracao, 3, 5));
                //Console.WriteLine(Calculadora2(Somar2, 3,5));


                // ***** Métodos e Funções - Delegates com Funções Anônimas  *****

                //StringOperacao inverter = delegate (string s)
                //{
                //    char[] charArray = s.ToCharArray();
                //    Array.Reverse(charArray);
                //    return new string(charArray);
                //};

                //Console.WriteLine(inverter("C# é show!!!"));

                // ***** Métodos e Funções - Usando Delegates  *****

                //Soma op1 = MinhaSoma;
                //Console.WriteLine(op1(2, 3));

                //ImprimirSoma op2 = MeuImprimirSoma;
                //op2(15, 7);

                //Func<double, double, double> op3 = MinhaSoma;
                //Console.WriteLine(op3(3, 7));

                //Action<double, double> op4 = MeuImprimirSoma;
                //op4(8, 8);

                //Soma op5 = MinhaSoma;
                //Console.WriteLine(op5(6,8));

                //ImprimirSoma op6 = MeuImprimirSoma;
                //op6(5,78);

                //Func<double, double, double> op7 = MinhaSoma;
                //Console.WriteLine(op7(89,5));

                //Action<double, double> op8 = MeuImprimirSoma;
                //op8(100,54);




                // ***** Métodos e Funções - Delegate com Lambda *****

                //Operacao sum = (x, y) => x + y;
                //Operacao sub = (x, y) => x - y;
                //Operacao mult = (x, y) => x * y;


                //Console.WriteLine($"Resultado da soma usando o delegate: {sum(10, 5)}");
                //Console.WriteLine($"Resultado da sub usando o delegate: {sub(30,8)}");
                //Console.WriteLine($"Resultadp da multiplicação usando o delegate: {mult(3,15)}");


                // ***** Métodos e Funções - Exemplo Lambda *****

                // Criando uma função Action anonima - Lambda
                // Atenção! A função "Action" é uma função void. Ou seja, não tem retorno

                //Action algoNoConsole = () =>
                //{
                //    Console.WriteLine("Lambda com C#");
                //};

                //Action impressaoConsole = () =>
                //{
                //    Console.WriteLine("Funções em variáveis");
                //};

                //algoNoConsole();
                //impressaoConsole();

                //// Criando uma Func. Nesse caso terá retorno.

                //Func<int> jogarDado = () =>
                //{
                //    Random random = new Random();
                //    return random.Next(1, 7);
                //};

                //Console.WriteLine(jogarDado());

                //Func<int> sorteio = () =>
                //{
                //    Random random = new Random();
                //    return random.Next(1, 25);
                //};

                //Console.WriteLine(sorteio());

                //// Criando uma Fun onde é recebido um int como parametro e retorna uma string.
                //// Essa estrutura já tem implicitamente o "return".
                //Func<int, string> conversorHex = numero => numero.ToString("x");
                //Console.WriteLine(conversorHex(1234));

                //// Criando uma Fun onde é recebido 3 inteitos como parametro e retorna uma string.
                //// Essa estrutura já tem implicitamente o "return".

                //Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                //String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);

                //Console.WriteLine($"Curso realizado em {formatarData(14,08,2022)}")


                // ***** Orientação a Objetos - Classe e Métodos Sealed *****

                //SemFilho semFilho = new SemFilho();
                //FilhoRebelde filhoRebelde = new FilhoRebelde();
                //Console.WriteLine(semFilho.ValorDaFortuna());
                //Console.WriteLine(filhoRebelde.HonrarNomeFamilia());

                // ***** Orientação a Objetos - Interface *****

                //var calc = new Calculadora();
                //var resultado = calc.ExecutarOperacoes(20, 5);
                //Console.WriteLine(resultado);


                // ***** Orientação a Objetos - Classe Abstrata *****

                //var celulares = new List<Celular> {
                //new Sansung(),
                //new Iphone(),
                //new Motorola()
                //};


                //foreach(var celular in celulares)
                //{
                //    Console.WriteLine(celular.Assistente());
                //}

            List<string> nomes = new List<string> { "Marcio", "Jouze" };

            nomes.Remove("Marcio");
            nomes.Add("Matheus");
            nomes.Add("Ana");
            nomes.Add("Paulo");
            nomes.Add("Pedro");
            nomes.Insert(2, "Amarelo");


            foreach (var nome in nomes) {
                Console.WriteLine(nome);
            }

            Console.WriteLine(nomes.Count);
            Console.WriteLine();
            Console.WriteLine("********************");
            string s1 = nomes.Find(x => x[0] == 'A');
            Console.WriteLine($"Firt 'A': {s1}");

            string s2 = nomes.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Last 'A': {s2}");

            int s3 = nomes.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': {0}", s3);

            int s4 = nomes.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': {0}", s4);

            List<string> nomes2 = nomes.FindAll(x => x.Length == 5);
            foreach (var obj in nomes2) {
                Console.WriteLine(obj);
            }



                // ***** Orientação a Objetos - Polimorfismo *****

                //Feijao ingrediente1 = new Feijao();
                //ingrediente1.Peso = 0.3;

                //Arroz ingrediente2 = new Arroz();
                //ingrediente2.Peso = 0.25;

                //Carne ingrediente3 = new Carne();
                //ingrediente3.Peso = 0.35;

                //Pessoa cliente = new Pessoa();
                //cliente.Peso = 80.5;
                //cliente.Comer(ingrediente1);
                //cliente.Comer(ingrediente2);
                //cliente.Comer(ingrediente3);

                //Console.WriteLine($"O peso total do cliente agora é {cliente.Peso.ToString("f2")}Kg.");


                // ***** Orientação a Objetos - Encapsulamento *****

                //Transporte carro1 = new Transporte();
                //carro1.MeusAcessos();

                //new Carro1().MeusAcessos();
                //new Moto1().MeusAcessos();
                //new Bike().MeusAcessos();
                //new JetSki().MeusAcessos();

                //SubCelebridade4 sub = new SubCelebridade4();
                //sub.MeusAcessos();

                //new FilhoReconhecido().MeusAcessos();
                //new AmigoProximo().MeusAcessos();
                //new FilhoNaoReconhecido().MeusAcessos();
                //new AmigoDistante().MeusAcessos();

                // ***** Orientação a Objetos - Construtor Usando o this *****

                //var spike = new Cachorro("Spike", 65);
                //var dog = new Cachorro("Neymar", 85);
                //Console.WriteLine(spike);
                //Console.WriteLine(dog);
                //var cat = new Gato("Neymar", "Amarelo");
                //Console.WriteLine(cat);
                //string version = typeof(string).Assembly.ImageRuntimeVersion;
                //Console.WriteLine(version);


                // ***** Orientação a Objetos - Herança #02 *****

                // Exemplo após subescrita e ocultação de metodos

                //Console.WriteLine("Ferrari com o tipo carro..");
                //Carro carro4 = new Ferrari();
                //Console.WriteLine(carro4.Acelerar());
                //Console.WriteLine(carro4.Acelerar());
                //Console.WriteLine(carro4.Frear());
                //Console.WriteLine(carro4.Frear());
                //Console.WriteLine(carro4.Frear());


                //Console.WriteLine("Uno com tipo carro");
                //carro4 = new Uno(); // Polimorfismo
                //Console.WriteLine(carro4.Acelerar());
                //Console.WriteLine(carro4.Acelerar());
                //Console.WriteLine(carro4.Frear());
                //Console.WriteLine(carro4.Frear());
                //Console.WriteLine(carro4.Frear());

                //Console.WriteLine("Porshe com o tipo carro ");
                //Carro carro5 = new Porsche();
                //Console.WriteLine(carro5.Acelerar());
                //Console.WriteLine(carro5.Acelerar());
                //Console.WriteLine(carro4.Frear());
                //Console.WriteLine(carro4.Frear());
                //Console.WriteLine(carro4.Frear());

                //Console.WriteLine("Porshe com tipo carro..");
                //carro5 = new Uno();
                //Console.WriteLine(carro5.Acelerar());
                //Console.WriteLine(carro5.Acelerar());
                //Console.WriteLine(carro4.Frear());
                //Console.WriteLine(carro4.Frear());
                //Console.WriteLine(carro4.Frear());


                // ***** Orientação a Objetos - Herança #01 *****

                //Console.WriteLine("Uno...");
                //Uno carro1 = new Uno();
                //Console.WriteLine(carro1.Acelerar());
                //Console.WriteLine(carro1.Acelerar());
                //Console.WriteLine(carro1.Frear());
                //Console.WriteLine(carro1.Frear());

                //Console.WriteLine("Ferrari..");
                //Ferrari carro2 = new Ferrari();
                //Console.WriteLine(carro2.Acelerar());
                //Console.WriteLine(carro2.Acelerar());
                //Console.WriteLine(carro2.Frear());
                //Console.WriteLine(carro2.Frear());
                //Console.WriteLine(carro2.Frear());

                //Console.WriteLine("Porsche..");
                //Porsche Carro3 = new Porsche();
                //Console.WriteLine(Carro3.Acelerar());
                //Console.WriteLine(Carro3.Acelerar());
                //Console.WriteLine(Carro3.Frear());
                //Console.WriteLine(Carro3.Frear());




                // ***** Orientação a Objetos - Pilares da OO - Abstração *****

                // Pilares da OO:

                // 1 - Abastração: ID, Atributos e Comportamentos
                // 2 - Herança: Reuso de código e composição.
                // 3 - Encapsulamento: Esconder parte do código.
                // Palavras reservadas:
                // public - Todos teram acesso 
                // internal - siginifical que o atributo ou compostamento poderá ser acesso dentro do projeto
                // protected - Transmitido por herança
                // private - Visivel apenas na classe
                // Dica! Sempre começe o nível de encapsulamentom, mais restrito possivel. Havendo a necessidade você vai alterando
                // deixabdo menos restrito, ou, mais visivel
                // 4 - Polimorfismo - Também tem um objetivo de reuso de metodo. Se divide em duas partes:
                // Estática e Dinâmica

                // ***** Coleções- Dictionary *****

                //Atenção! O Dictionary aceita repetição na "string" mas não no "int"
                //var filmes = new Dictionary<int, string>();
                //filmes.Add(2000, "Gradiador");
                //filmes.Add(2002, "Homem-Aranha");
                //filmes.Add(2004, "Os Incriveis");
                //filmes.Add(2006, "O Grande Truque");

                //if (filmes.ContainsKey(2004)) // Metodo está contido?
                //{
                //    Console.WriteLine("2004 " + filmes[2004]); // Imprima
                //    Console.WriteLine("2004 " + filmes.GetValueOrDefault(2004));
                //}

                //Console.WriteLine(filmes.ContainsValue("Amnesia")); // Procura se o valor existe. Se não, retorna false.

                //Console.WriteLine(filmes.Remove(2004)); // Remove se achar o valor informado. Retorna "true" se existir

                //filmes.TryGetValue(2006, out string filme2006);
                //Console.WriteLine("2006: {0}", filme2006);

                //foreach(var chave in filmes.Keys) // Percorrendo os valores por chave
                //{
                //    Console.WriteLine(chave);
                //}

                //foreach (var valor in filmes.Values) // Percorrendo só os valores
                //{
                //    Console.WriteLine(valor);
                //}

                //foreach(KeyValuePair<int, string> filme in filmes) // Percorrendo a chave e valor ao mesmo tempo
                //{
                //    Console.WriteLine($"{filme.Value} é de {filme.Key}");
                //}

                //foreach(var filme in filmes) // Deixar que p próprio compilador resolva. Mesmo resultado anterior
                //{
                //    Console.WriteLine($"{filme.Value} é de {filme.Key}"); 
                //}





                // ***** Coleções- Igualdade Stack *****

                // Ao contrário da "FILA" o primeiro entrar é o ultimo a sair.
                // Também aceita tipo de dados diferente declarado na variavel.

                //var pilha = new Stack();
                //pilha.Push(3);
                //pilha.Push("a");
                //pilha.Push(true);
                //pilha.Push(3.14f);

                //foreach(var pilhaStack in pilha)
                //{
                //    Console.Write($" {pilhaStack} ");
                //}

                //Console.WriteLine($"\nPop: {pilha.Pop()}");  //Saca o ultimo elemento adicionado a variavel pop

                //foreach(var pilhaPop in pilha)
                //{
                //    Console.WriteLine($" {pilhaPop}");
                //}

                //Console.WriteLine($"\nPeek: {pilha.Peek()}"); // Casa o elemnto que está no topo e não remove
                //Console.WriteLine(pilha.Count); 



                // ***** Coleções- Igualdade (Equals e GetHashCode) *****

                //var p1 = new Produto2("A",1);
                //var p2 = new Produto2("A", 1);
                //var p3 = p2;
                //Console.WriteLine(p1 == p2); // False, aponta para endereços de memorias diferentes
                //Console.WriteLine(p2 == p3); // True, valor por referencia, aponta para o mesmo endereço de memoria

                //Console.WriteLine(p1.Equals(p2)); //False, pois o metodo Equal faz a mesma coisa, compara endereços de memoria


                // ***** Coleções- QUEUE - FILA *****

                //var lista = new Queue<string>(); // Usando o gereric só é possivel informar um único tipo de dado. Que nesse caso é string
                //lista.Enqueue("Fulano");
                //lista.Enqueue("Sicrano");
                //lista.Enqueue("Beltrano");

                //Console.WriteLine(lista.Peek()); // Destaca o primeiro elemento da lista sem remover
                //Console.WriteLine(lista.Count); // Exibi a quantidade de indices

                //Console.WriteLine(lista.Dequeue());
                //Console.WriteLine(lista.Count);

                //foreach(var pessoa in lista)
                //{
                //    Console.WriteLine(pessoa);
                //}

                //var salada = new Queue(); // Sintaxe para utilizar vários tipode de dados. É necessário importar para esse
                //// namespace o using: "using System.Collections;"
                //salada.Enqueue(3);
                //salada.Enqueue(true);
                //salada.Enqueue("String");
                //salada.Enqueue(10.8);

                //Console.WriteLine(salada.Peek());
                //Console.WriteLine(salada.Count);

                //Console.WriteLine(salada.Contains("String")); // Verifica se tem o valor na lista. Resultado true or false

                //foreach(var verdura in salada)
                //{
                //    Console.WriteLine(verdura);
                //}


                // ***** Coleções- SET *****

                // Obs. O Set NÃO é uma estrutura indexada. Diferente do list, o Set não aceita repetição.

                //var livro2 = new Produto2("A revolução dos Bichos", 49.9);
                //var livro3 = new Produto2("O Tatuador de Auschwitz", 79.9);
                //var carrinho2 = new HashSet<Produto2>();

                //// Palavra reservada "HashSet" para usar o set.
                //var comboCarrinho2 = new HashSet<Produto2> {
                //new Produto2("Boné", 49.9),
                //new Produto2("Camisa", 79.9),
                //new Produto2("Caneca", 25.9)
                //};

                //carrinho2.Add(livro2);
                //carrinho2.Add(livro3);

                //// Função "UnionWith" é igual a função "Range" utilizada no List.
                //carrinho2.UnionWith(comboCarrinho2);


                //foreach (var item in carrinho2)
                //{
                //    Console.WriteLine($"Livro: {item.Nome}\nPreco: {item.Preco.ToString("C")}");

                //}

                // ***** Coleções- ArrayList *****

                // Atenção: Para usar a estrutura "ArrayList" é necessário remover a palavra reservada "Generic" do import: "using System.Collections.Generic;"
                // O ArrayList aceita diferentes tipos de dados. Atenção: Não é uma opção muito recomendada.
                //var arrayList = new ArrayList { 
                //"Palavra",
                //3,
                //true

                //};

                //arrayList.Add(3.14);

                //foreach(var item in arrayList)
                //{
                //    Console.WriteLine("{0} => {1}", item, item.GetType());
                //}

                // ***** Coleções- list *****

                // Atenção: Para usar o "LIST" se faz necessário fazer o import do: "using System.Collections.Generic;"
                // Vale mencionar também que o "LIST" é uma estrutura indexada e aceita repetições.

                //var curso1 = new Curso("C#", "Leonardo", 25.9);
                //var curso2 = new Curso("SQL", "Leonardo", 40.9);
                //var curso3 = new Curso("HTML5", "Leonardo", 30.9);

                //var carrinhoCurso = new List<Curso>();
                //carrinhoCurso.Add(curso1);
                //carrinhoCurso.Add(curso2);
                //carrinhoCurso.Add(curso3);

                //foreach (var cursos in carrinhoCurso)
                //{

                //    Console.WriteLine($"Curso: {cursos.Nome}\nProfessor: {cursos.Professor}\nPreco: {cursos.Preco.ToString("C")}");
                //}

                //var jogo1 = new Game("Fifa 2022", 80.9);
                //var jogo2 = new Game("The Division 2", 49.9);
                //var jogo3 = new Game("The Witcher 3", 99.9);

                //var carrinhoDeCompra = new List<Game>();
                //carrinhoDeCompra.Add(jogo1);
                //carrinhoDeCompra.Add(jogo2);
                //carrinhoDeCompra.Add(jogo3);

                //foreach(var jogos in carrinhoDeCompra)
                //{
                //    Console.WriteLine($"Título: {jogos.Titulo}\nPreço: {jogos.Preco}");
                //    Console.WriteLine("******************");
                //}

                //var livro = new Produto2("O Senhor dos Aneis", 89.90);
                //var livro2 = new Produto2("A Cabana", 70.90);

                //var carrinho = new List<Produto2>();
                //carrinho.Add(livro);
                //carrinho.Add(livro2);

                //var packGame = new List<Game>
                //{
                //    new Game("Need for speed", 45.9),
                //    new Game("Assassins Cread Origin", 39.9)
                //};

                //foreach(var promocao in packGame)
                //{
                //    Console.WriteLine($"Titulo: {promocao.Titulo}\nPreco: {promocao.Preco}");
                //    Console.WriteLine("******************");
                //}

                //foreach (var itens in carrinho)
                //{
                //    Console.WriteLine($"Produto: {itens.Nome}\nPreço: {itens.Preco}");
                //    Console.WriteLine("******************");
                //}


                //var combo = new List<Produto2> {
                //new Produto2("Camisa", 29.89),
                //new Produto2("8ª temporada de Game of Thrones", 90.9),
                //new Produto2("Poster", 10)

                //};

                //carrinho.AddRange(combo);
                //Console.WriteLine(carrinho.Count);
                //carrinho.RemoveAt(3);
                //Console.WriteLine(carrinho.Count);

                //foreach(var item in carrinho)
                //{
                //    Console.WriteLine(carrinho.IndexOf(item));
                //    Console.WriteLine($"{item.Nome} {item.Preco}");
                //}



                // ***** Coleções- Array *****

                // Arrays são tipos homogeneos. Ou seja, não é possivel misturar tipos de dados. Ex: string, int, double...
                //string[] alunos = new string[4]; // Limitação de 5 valores.
                //alunos[0] = "Márcio";
                //alunos[1] = "Matheus";
                //alunos[2] = "Julia";
                //alunos[3] = "Jouze";
                //double[] notasAlunos = { 10.0, 9.5 };
                //double somatoria = 0;
                //double[] notas = { 9.8, 7.5, 6.4, 6.8};

                //foreach(var nota in notas)
                //{
                //    somatoria += nota;

                //}

                //// Outra forma de varrer o array
                ////for (var i= 0; i < notas.Length; i++)
                ////{
                ////    somatoria += notas[i];
                ////}

                //double media = somatoria / notas.Length;
                //Console.WriteLine(media.ToString("f2"));

                //foreach(var aluno in alunos)
                //{
                //    Console.WriteLine($"Seja bem vindo: {aluno}");
                //}

                //int[] anos = { 2022, 2019 };
                //Console.WriteLine($"Ano: {anos[0]}");
                //Console.WriteLine($"Ano: {anos[1]}");
                //foreach(var ano in anos)
                //{
                //    Console.WriteLine($"Impressão via foreach {ano}");
                //}

                //// Também é possível fazer uma leitura de arrau dessa forma
                //char[] letras = { 'A', 'R','R', 'A', 'Y' };
                //string palavra = new string(letras); // Sintaxe
                //Console.WriteLine(palavra);
                ;
                // ***** Classes e Métodos - Parâmetros com Valor Padrão *****

                //Console.WriteLine($"Resultado da soma passando os valores {Somar(10,10)}");
                //Console.WriteLine($"Resultado da soma sem informar valores {Somar()}");
                //Console.WriteLine($"Resultado da soma informando apenas um valor {Somar(5)}");
                //Console.WriteLine($"Resultado da soma passando parametros nomeados B = {Somar(b: 8)}");


                // ***** Classes e Métodos - Parâmetros por referência (Ref/Out) *****

                //int a = 5;
                //AlterarRefMarcio(ref a);
                //Console.WriteLine($"Resultado de valor Ref: {a}");

                //int u;
                //AlterarOutMarcio(out u);
                //Console.WriteLine($"Resultado de valor Out: {u}");


                //int c = 3;
                //AlterarRef(ref c);
                //Console.WriteLine(c);

                //int b;
                //AlterarOut(out b);
                //Console.WriteLine(b);



                // ***** Classes e Métodos - Atribuição por Valor x Referência *****

                //int numero = 3;
                //int copiaNumero = numero;
                //Console.WriteLine($"Numero = {numero}\nCopia Do Número = {copiaNumero}");

                //numero++;
                //Console.WriteLine($"Numero = {numero}\nCopia Do Número = {copiaNumero}");

                //Dependente dep = new Dependente { Nome = "Julia", Idade = 13 };
                //Dependente copiaDep = dep;

                //Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
                //Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

                //copiaDep.Nome = "Matheus";
                //dep.Idade = 8;

                //// Todos os valores setados as variaveis serão alteradas. Pois se trata de classe que é feita por referencia
                //// Alterando o tipo da classe "Dependente" para Struct. Todo o código será depurado normalmente. Só que os valores
                //// Serão destinados a endereços diferentes.
                //Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
                //Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");


                // ***** Classes e Métodos - Class Vs Struct *****

                //// No Struct os valores são apontados para endereços de memorias diferentes
                //SPonto ponto1 = new SPonto { X = 1, Y = 3 }; // Outra forma setar os valores para os atributos do objeto criado
                //SPonto copiaDoPonto1 = ponto1; // Atribuição feita por  VALOR
                //ponto1.X = 3; // Só altera o valor de X no ponto1. Não afeta o objeto copiaDoPonto1
                //Console.WriteLine("Ponto 1 X:{0}", ponto1.X);
                //Console.WriteLine("Copia do Ponto 1 X:{0}", copiaDoPonto1.X);

                //// No caso de Class, a atribuioção é feira por referencia. Ou seja, Alterando o valor de um atributo
                //// Todos os valores dos outros serão alterados.
                //CPonto ponto2 = new CPonto { X = 2, Y = 4 };
                //CPonto copiaDoPonto2 = ponto2; //Atribuição por REFERENCIA
                //ponto2.X = 4;
                //Console.WriteLine("Ponto 2 X:{0}",ponto2.X);
                //Console.WriteLine("Copia do Ponto 2 X:{0}", copiaDoPonto2.X);


                // ***** Classes e Métodos - Struct *****

                // Usando "Struct" é possível criar uma instancia sem a necessidade da palavra reservada "new"
                //Coordenada coordenadaInicial;
                //coordenadaInicial.X = 2;
                //coordenadaInicial.Y = 2;
                //Console.WriteLine("Coordenada Inicial");
                //Console.WriteLine("X = {0}", coordenadaInicial.X);
                //Console.WriteLine("Y = {0}", coordenadaInicial.Y);

                //Coordenada coordenadaInicial2;
                //coordenadaInicial2.X = 4;
                //coordenadaInicial2.Y = 4;
                //Console.WriteLine("Coordenada Inicial 2");
                //Console.WriteLine($"X = {coordenadaInicial2.X}");
                //Console.WriteLine($"Y = {coordenadaInicial2.Y}");

                //var coordenadaFinal = new Coordenada(x: 9, y: 1);
                //coordenadaFinal.MoverNaDiagonal(10);


                //Console.WriteLine("Coordenada Final");
                //Console.WriteLine("X = {0}", coordenadaFinal.X);
                //Console.WriteLine("Y = {0}", coordenadaFinal.Y);

                //var coordenadaFinal2 = new Coordenada(x: 8, y: 2);
                //coordenadaFinal2.MoverNaDiagonal(8);
                //Console.WriteLine("Coordenada Final 2");
                //Console.WriteLine($"X = {coordenadaFinal2.X}");
                //Console.WriteLine($"Y = {coordenadaFinal2.Y}");



                // ***** Classes e Métodos - Enumerações (Enum) *****

                //int id = (int)Genero2.Animacao;
                //Console.WriteLine("Enumerador de animacao: {0} ", id);

                //var filmePraFamilia = new Filme();
                //filmePraFamilia.Titulo = "A mumia";
                //filmePraFamilia.GeneroDoFilme = Genero2.Terro;
                //Console.WriteLine($"{filmePraFamilia.Titulo} é {filmePraFamilia.GeneroDoFilme}");


                // ***** Classes e Métodos - Atributos Readonly *****

                //var cliente1 = new Cliente("Márcio", new DateTime(year: 1978, month: 09, day: 03));
                //Console.WriteLine("Nome: {0}", cliente1.Nome);
                //Console.WriteLine("Data de Nascimento: {0}", cliente1.GetDataDeNascimento());

                //var cliente2 = new Cliente("Jouze", new DateTime(year: 1978, month: 09, day: 04));
                //Console.WriteLine("Nome: {0}", cliente2.Nome);
                //Console.WriteLine("Data de Nascimento: {0}", cliente2.GetDataDeNascimento());
                //cliente1.DatadeNascimento = new DateTime(year: 1978, month: 09, day: 09);


                // ***** Classes e Métodos - Propriedades *****

                //var carro1 = new CarroOpcional("Ar condicionado", 3599.9);
                //Console.WriteLine(carro1.PrecoComDesconto);

                //var carro2 = new CarroOpcional();
                //carro2.Nome = "Direção Elétrica";
                //carro2.Preco = 5500;
                //Console.WriteLine(carro2.Nome);

                // ***** Classes e Métodos - Getters & Setters *****

                //Console.WriteLine("Livraria do Márcio");
                //Console.WriteLine("******************");
                //var livro1 = new Livro("Joyland", "Stephen King", "Romance", 2020);
                //Console.WriteLine($"Livro: {livro1.GetTitulo()}\nEscritor: {livro1.GetEscritor()}\nGenero: " +
                //    $"{livro1.GetGenero()}\nAno: {livro1.GetAno()}");


                //Console.WriteLine("Livraria do Márcio");
                //Console.WriteLine("******************");
                //var livro2 = new Livro("Spartacus", "Escritor", "Romance", 1968);
                //Console.WriteLine($"Livro: {livro2.GetTitulo()}\nExcritor: {livro2.GetEscritor()}\nGenero: {livro2.GetGenero()}\nAno: {livro2.GetAno()}");

                //Console.WriteLine("******************");

                //Console.WriteLine("Livraria do Márcio");
                //Console.WriteLine("******************");

                //var livro2 = new Livro();
                //livro2.SetTitulo("Portões de Fogo");
                //livro2.SetEscritor("Steven Pressfield");
                //livro2.SetGenero("Romance");
                //livro2.SetAno(2019);
                //Console.WriteLine($"Livro: {livro2.GetTitulo()}\nEscritor: {livro2.GetEscritor()}\nGenero: {livro2.GetGenero()}\nAno: {livro2.GetAno()}");

                //var moto1 = new Moto("Honda", "Titan", 500);
                //Console.WriteLine($"Moto: {moto1.GetMarca()}");
                //Console.WriteLine($"Modelo: {moto1.GetModelo()}");
                //Console.WriteLine($"Cilindrada: {moto1.GetCilindrada()}");

                //Console.WriteLine("*********************");

                //var moto2 = new Moto("BMW", "Cruiser", 800);
                //Console.WriteLine("Moto: {0}", moto2.GetMarca());
                //Console.WriteLine("Modelo: {0}", moto2.GetModelo());
                //Console.WriteLine("Cilindrada: {0}", moto2.GetCilindrada());

                //Console.WriteLine("*********************");

                //var moto3 = new Moto("Yamaha", "Lander", 350);
                //Console.WriteLine(moto3.GetMarca());
                //Console.WriteLine(moto3.GetModelo());
                //Console.WriteLine(moto3.GetCilindrada());

                //var moto4 = new Moto();
                //moto4.SetMarca("Suzuki");
                //moto4.SetModelo("Hayabusa");
                //moto4.SetCilindrada(1200);
                //Console.WriteLine(moto4.GetMarca() + " " + moto4.GetModelo() + " " + moto4.GetCilindrada());


                // ***** Classes e Métodos - Parametros Nomeados *****

                //FormatarData(dia: 27, mes: 7, ano: 2022);
                //CadastroCliente(nome: "Márcio", idade: 43, email: "Márcioplay@gmail.com");


                // ***** Classes e Métodos - Parametros Variáveis *****

                //Apresentar("Márcio", "Jouze", "Matheus", "julia", "Chiquinha", "Bira");
                //Apresentar("Márcio", "Jouze");
                //Familia("Mãe", "Pai", "Filho", "Filha", "Esposa", "Eu");


                // ***** Classes e Métodos - Desafio Acessar atributo *****

                //Praticas desafio = new Praticas();
                //Console.WriteLine(desafio.a);
                //Console.WriteLine(desafio.b);


                // ***** Classes e Métodos - Atributos Estáticos *****


                //var jogo1 = new Jogo("The Witcher 3,", 40.0, 0.5);

                //// Atributo estatico setado direto a classe
                //Jogo.Desconto = 0.5; 

                //Console.WriteLine("O valor com desconto é: {0} ", jogo1.CalcularDesconto());


                //// Atributo desconto agora faz parte a classe. Pois ele passou a ser static
                //// Jogo.Desconto = 0.5;

                //var jogo2 = new Jogo();
                //jogo2.Titulo = "Fifa 2022";
                //jogo2.Preco = 50.0;
                ////jogo2.Desconto = 0.2;



                //Jogo.Desconto = 0.1;
                //Console.WriteLine("O valor com desconto é: {0}", jogo2.CalcularDesconto());

                // ***** Classes e Métodos - Métodos Estáticos *****

                //var numeroMultiplicar = new CalculadoraEstatica();
                //numeroMultiplicar.Multiplicar(2, 5);
                //var numeroSomar = CalculadoraEstatica.Somar(5, 5);
                //var numeroSubtrair = CalculadoraEstatica.Subtrair(30, 8);
                //var numeroSomar2 = CalculadoraEstatica.Somar(8, 8);

                //Console.WriteLine($"Resultado do metodo multiplicar são: { numeroMultiplicar.Multiplicar(2, 5)}");
                //Console.WriteLine($"Resultado do metodo somar são: {numeroSomar}");
                //Console.WriteLine($"Resultado do metodo subtrair são: {numeroSubtrair}");
                //Console.WriteLine(numeroSomar2);

                // ***** Classes e Métodos - Métodos com Retorno 2 *****

                //var calculadoraCadeia = new CalculadoraCadeia();
                //calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

                //var resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
                //Console.WriteLine(resultado);


                // ***** Classes e Métodos - Métodos com Retorno 1 *****

                //var calculo1 = new CalculadoraComum();
                //var resultado = calculo1.Somar(10, 12);
                //Console.WriteLine("O resultado da soma é: {0}", resultado);

                //var operacoesDiversas = new CalculadoraComum();
                //var resultadoSomar2 = operacoesDiversas.Somar(8, 89);

                //Console.WriteLine(resultadoSomar2);
                //Console.WriteLine(operacoesDiversas.Multiplicar(3, 8));
                //Console.WriteLine(operacoesDiversas.Subtrair(9, 6));
                //Console.WriteLine(operacoesDiversas.Dividir(10, 6));

                //var subtrair1 = new CalculadoraComum();
                //var resultado2 = subtrair1.Subtrair(30, 8);
                //Console.WriteLine("O resultado da subtração é: {0}", resultado2);

                //var multiplicar = new CalculadoraComum();
                //var resultado3 = multiplicar.Multiplicar(4, 10);
                //Console.WriteLine("O resultado da multiplicação é: {0}", resultado3);

                //var dividir1 = new CalculadoraComum();
                //var resultado4 = dividir1.Dividir(10, 2);
                //Console.WriteLine("O resultado da Divisão é {0}", resultado4);


                // ***** Classes e Métodos - Construtores *****

                //Produto produto1 = new Produto();
                //produto1.Nome = "Arroz";
                //produto1.Tipo = "Não Peresível";
                //produto1.Peso = 2;
                //produto1.Preco = 5.90;
                //Console.WriteLine(produto1.ExibirProduto());
                //Console.WriteLine("***********************");

                //var produto2 = new Produto("Feijão", "Não Perecivel", 2, 8.99);
                //Console.WriteLine(produto2.ExibirProduto());
                //Console.WriteLine("***********************");

                //var carro1 = new Carro("Onix", "GM", 2019);
                //Console.WriteLine("Carro 1:");
                //Console.WriteLine(carro1.ExibirEntrada());
                //Console.WriteLine("***********************");


                //var carro2 = new Carro("Ka", "Ford", 2020);
                //Console.WriteLine("Carro 2:");
                //Console.WriteLine(carro2.ExibirEntrada());
                //Console.WriteLine("***********************");

                //Carro carro3 = new Carro();
                //carro3.Modelo = "z8";
                //carro3.Fabricante = "BMW";
                //carro3.Ano = 2021;
                //Console.WriteLine("Carro 3:");
                //Console.WriteLine(carro3.ExibirEntrada());
                //Console.WriteLine("***********************");


                // ***** Classes e Métodos - Membros: Atributos e Métodos *****

                //Cadastro usuario1 = new Cadastro();
                //usuario1.Nome = "Márcio";
                //usuario1.Endereco = "Rua Manoel Salvador 118";
                //usuario1.Telefone = "81996750434";
                //usuario1.Idade = 43;
                //usuario1.Sexo = 'M';

                //var usuario2 = new Cadastro();
                //usuario2.Nome = "Matheus";
                //usuario2.Endereco = "Rua Oojuca 227 Areias";
                //usuario2.Telefone = "81996750434";
                //usuario2.Idade = 8;
                //usuario2.Sexo = 'M';

                //Console.WriteLine(usuario2.ApresentacaoCadastro());

                //var cliente = usuario1.ApresentacaoCadastro();
                //Console.WriteLine(cliente);


                //Pessoa p1 = new Pessoa();
                //p1.Nome = "Márcio";
                //p1.Idade = 43;

                //Pessoa p2 = new Pessoa();
                //p2.Nome = "Jouze";
                //p2.Idade = 43;
                //Console.WriteLine($"Meu nome é {p1.Nome} e tenho {p1.Idade} anos.");
                //Console.WriteLine($"Meu nome é {p2.Nome} e tenho {p2.Idade} anos");

                //Pessoa filho = new Pessoa();
                //filho.Nome = "Matheus";
                //filho.Idade = 8;

                //Pessoa filha = new Pessoa();
                //filha.Nome = "Julia";
                //filha.Idade = 13;

                //var pessoa1 = p1.Apresentar();
                //var pessoa2 = p2.Apresentar();
                //var pessoa3 = filho.Apresentar();
                //var pessoa4 = filha.Apresentar();

                //Console.WriteLine(pessoa1);
                //Console.WriteLine(pessoa2);
                //Console.WriteLine(pessoa3);
                //Console.WriteLine(pessoa4);

                //p1.ApresentarNoConsole();
                //p2.ApresentarNoConsole();
                //filho.ApresentarNoConsole();
                //filha.ApresentarNoConsole();

                // ***** Classes e Métodos - Métodos *****

                // ***** Classes e Métodos - Classes x Objetos *****

                // ***** Classes e Métodos *****


                // ***** Estruturas de controle - Estrutura DO CONTINUE *****

                //int intervalo = 50;
                //Console.WriteLine("O intervalo entre 1 e {0}", intervalo);

                //for(int i = 1; i <= intervalo; i++)
                //{
                //    if(i % 2 == 1)
                //    {
                //        continue;
                //    }

                //    Console.WriteLine(i + " ");
                //}

                //for (int i = 0; i <= intervalo; i+=2)
                //{
                //    Console.WriteLine(i + " ");
                //}

                // ***** Estruturas de controle - Estrutura DO BREAK *****

                //Random random = new Random();
                //int numero = random.Next(1, 51);

                //Console.WriteLine("O número que queremos é {0}", numero);

                //for(int i = 1; i <= 50; i++)
                //{
                //    Console.WriteLine("{0} é o número que queremos? ", i);
                //    if(i == numero)
                //    {
                //        Console.WriteLine("Sim!");
                //        break;
                //    }
                //    else
                //    {
                //        Console.WriteLine("Não");
                //    }
                //}

                //Console.WriteLine("Fim!");

                // ***** Estruturas de controle - Estrutura DO FOREACH *****

                //var letras = "Hello World!";
                //string[] nomes = { "Márcio", "Matheus", "Julia", "Jouze", "Mãe", "Pai" };
                //double[] notas = { 10.5, 5.8, 8.9 };

                ////foreach(var letra in letras)
                ////{
                ////    Console.WriteLine(letra);
                ////}

                //foreach (var nome in nomes)
                //{
                //    Console.WriteLine(nome);
                //}

                //foreach (var nota in notas)
                //{
                //    Console.WriteLine(nota);
                //}


                // ***** Estruturas de controle - Estrutura DO FOR *****


                //for (int i = 50; i >= 0; i -= 10)
                //{
                //    Console.WriteLine($"O valor de i é {i}");
                //}


                // ***** Estruturas de controle - Estrutura DO WHILE *****

                //int numero = 0;

                //do
                //{
                //    Console.WriteLine("Execução do laço DO WHILE");
                //    numero++;
                //} while (numero <= 10);

                // string senha = "123";
                // string senhauser;
                // int tentativa = 0;

                // do
                // {
                //     Console.Clear();
                //     Console.Write("Digite a senha: ");
                //     senhauser = Console.ReadLine();
                //     tentativa++;
                // } while (senhauser != senha);

                //Console.Clear();
                // Console.WriteLine("Senha correta. Número de tentativas {0} ", tentativa);

                //string nome;
                //string entrada;

                //do
                //{
                //    Console.Write("Qual o seu nome? ");
                //    nome = Console.ReadLine();
                //    Console.WriteLine($"Seja bem vindo {nome}");
                //    Console.Write($"Deseja continuar? ");
                //    entrada = Console.ReadLine();
                //} while (entrada.ToLower() == "s");


                // ***** Estruturas de controle - Estrutura WHILE ******

                //int numero = 25;

                //while (numero >= 0)
                //{
                //    Console.WriteLine(numero);
                //    numero -= 5;
                //}


                //int palpite = 0;
                //Random random = new Random();

                //int numeroSecreto = random.Next(1, 16);
                //bool numeroEncontrado = false;
                //int tentativasRestantes = 5;
                //int tentativas = 0;

                //while (tentativasRestantes > 0 && !numeroEncontrado)
                //{
                //    Console.WriteLine("Insira o seu palpite");
                //    int.TryParse(Console.ReadLine(), out int numero);

                //    tentativas++;
                //    tentativasRestantes--;

                //    if (numeroSecreto == numero)
                //    {
                //        numeroEncontrado = true;
                //        var conAnterior = Console.BackgroundColor;
                //        Console.BackgroundColor = ConsoleColor.Green;
                //        Console.WriteLine("Número encontrado em {0} tentativas", tentativas);
                //        Console.BackgroundColor = conAnterior;
                //    }
                //    else if (palpite > numeroSecreto)
                //    {
                //        Console.WriteLine("Menor...Tente novamente!");
                //        Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                //    }
                //    else
                //    {
                //        Console.WriteLine("Maior.. Tente novamente");
                //        Console.WriteLine("Tentativas restantes {0}", tentativasRestantes);
                //    }

                //}


                // ***** Estruturas de controle - Estrutura SWITCH ******

                //Console.WriteLine("Avalie nosso atendiento digitando entre 0 e 5 ");
                //Console.Write("Digite sua nota: ");
                //int.TryParse(Console.ReadLine(), out int nota);

                //switch (nota)
                //{
                //    case 0:
                //    case 1:
                //        Console.WriteLine("Pessimo");
                //        break;
                //    case 2:
                //        Console.WriteLine("Ruim");
                //        break;
                //    case 3:
                //    case 4:
                //        Console.WriteLine("Ótimo");
                //        break;
                //    case 5:
                //        Console.WriteLine("Excelente");
                //        break;
                //    default:
                //        Console.WriteLine("Valor inválido");
                //        break;
                //}

                //Console.WriteLine("Obrigado!");



                // ***** Estruturas de controle - Estrutura IF/ELSE IF ******

                //Console.Write("Digite a nota do aluno: ");
                //double.TryParse(Console.ReadLine(), out double nota1);

                //if (nota1 >= 7.0 && nota1 <= 10.0)
                //{
                //    Console.WriteLine("Aluno Aprovado");
                //}
                //else if (nota1 < 7.0 && nota1 >= 5.0)
                //{
                //    Console.WriteLine("Aluno em Recuperação");
                //}
                //else if (nota1 > 10.0)
                //{
                //    Console.WriteLine("Nota inválida");
                //}
                //else
                //{
                //    Console.WriteLine("Aluno Reprovado");
                //}

                //Console.WriteLine("Fim!");


                // ***** Estruturas de controle - Estrutura IF/ELSE ****** 

                //double nota = 4.0;

                //if (nota >= 7.0)
                //{
                //    Console.WriteLine("Aprovado");
                //}
                //else
                //{
                //    Console.WriteLine("Reprovado");
                //}


                // ***** Estruturas de controle - Estrutura IF ****** 

                //bool bomComportamento = false;

                //Console.Write("Digite a nota do aluno: ");
                //double.TryParse(Console.ReadLine(), out double nota);
                //Console.Write("Possui bom comportamento? (S/N)");
                //string entrada = Console.ReadLine();

                ////if(entrada == "S" || entrada == "s")
                ////    bomComportamento = true;

                ////bomComportamento = entrada == "S" || entrada == "s";
                //bomComportamento = entrada.ToLower() == "s"; // Nesse caso ele só verifica uma vez o "s"

                //if (nota >= 9.0 && bomComportamento)
                //{
                //    Console.WriteLine("Quadro de honra!");
                //}


                // ***** Fundamentos - Operador Ternário ****** 

                //var nota = 6.0;
                //bool bomComportamento = true;
                //var resultado = nota >= 7 && bomComportamento ? "Aprovado" : "Reprovado";
                //Console.WriteLine($"Você foi? {resultado}");

                // ***** Fundamentos - Operadores Unários ****** 

                //var valorNegativo = -5;
                //var numero1 = 2;
                //var numero2 = 3;
                //bool booleano = true;

                //Console.WriteLine(-valorNegativo); // Com o simbolo de - como o valor já é negativo passa a ser positivo
                //Console.WriteLine(!booleano); // inverte a lógica. True -> False.

                //numero1++; // Incremento pós-fixado
                //Console.WriteLine(numero1);

                //--numero1; // Decremento pré-fixado
                //Console.WriteLine(numero1);


                //Console.WriteLine(numero1++ == --numero2); // Evitar códigos que não sejam claros.
                //Console.WriteLine($"{numero1} {numero2}");



                // ***** Fundamentos - Operadores de Atribuição  *******

                //var num1 = 3; // 3
                //num1 = 7; // 7
                //num1 += 10; // 17
                //num1 -= 3; // 14
                //num1 *= 5; // 70
                //num1 /= 2; // 35
                //Console.WriteLine($"resultado final {num1}");

                //int a = 1; // 2
                //int b = a; // 0
                //a++;
                //b--;

                //Console.WriteLine($"A={a}, B={b}");

                // ***** Fundamentos - Operadores Lógicos  *******

                //var executouTrabalho1 = true;
                //var executouTrabalho2 = false;

                //var comprouTv50 = executouTrabalho1 && executouTrabalho2; // AND && (E)
                //Console.WriteLine("Comprou a tv 50 {0}", comprouTv50);

                //var comprouTv32 = executouTrabalho1 || executouTrabalho2; // OR || (OU)
                //Console.WriteLine("Comprou a tv 32 {0}", comprouTv32);

                //var tomarSorvete = executouTrabalho1 ^ executouTrabalho2; // OR EXCLUSIVO. UM E SOMENTE 1 DEVE SER VERDADEIRO
                //Console.WriteLine("Tomar sorvete? {0}", tomarSorvete);

                //Console.WriteLine("Mais saudável? {0}", !tomarSorvete); // NEGAÇÃO DO RESULTADO. OPERADOR UNÁRIO


                // ***** Operadores relacionais *******

                //Nas operações relacionais o resultado sempre será "True" or "False"

                //double nota = 6.0;
                //double notaDeCorte = 7.0;

                //Console.WriteLine("Nota invalida? {0} ", nota > 10.0);
                //Console.WriteLine("Nota invalida? {0}", nota < 0.0);
                //Console.WriteLine("Aprovado? {0}", nota == 7.0);
                //Console.WriteLine("Reprovado? {0}", nota <= 3.0);
                //Console.WriteLine("Nota válida? {0}", nota > 0.0 && nota <= 10.0);
                //Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
                //Console.WriteLine("Passou por média: {0}", nota >= notaDeCorte);
                //Console.WriteLine("Recuperação: {0}", nota < notaDeCorte);


                // ***** Fundamentos - Operadores aritméticos *******

                //var preco = 1000.0;
                //var imposto = 355;
                //var desconto = 0.1;

                //double total = preco + imposto;
                //double valortotal = total - (total * desconto);
                //Console.WriteLine($"O valor total com desconto é: {valortotal.ToString("C")}");

                //// IMC

                //double peso = 91.2;
                //double altura = 1.82;
                //double imc = (altura * altura) / peso;
                //Console.WriteLine($"O valor total da massa corporia é: {imc.ToString("f2")}");

                // Número par impar
                //int par = 24;
                //int impar = 55;
                //Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
                //Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);


                // ***** Fundamentos - Conversões *******

                //int numeroInteiro = 10;
                //double numeroQuebrado = numeroInteiro; // Conversão implicida
                //Console.WriteLine(numeroQuebrado);

                //double valordouble = 5.1;
                //int valortruncado = (int)valordouble; // Conversão explicita usando cast.
                //Console.WriteLine(valordouble);           

                //Console.Write("Digite seu nome: ");
                //string nome = Console.ReadLine();
                //Console.Write("Digite a sua idade: ");
                //int.TryParse(Console.ReadLine(), out int idade);

                //Console.WriteLine($"Meu nome é: {nome}. Tenho {idade} anos.");



                // ***** Fundamentos - Formatando números *******

                //double valor = 15.175;
                //double valor2 = 48.8574;
                //int numero = 250;

                //Console.WriteLine(valor.ToString("f1")); // Metodo que traz 1 casa decimal após a virgula.
                //Console.WriteLine(valor2.ToString("f2")); // Metodo que traz 3 casas decimais após a virgula.
                //Console.WriteLine(valor.ToString().Length); // Valor que traz o tamanho
                //Console.WriteLine(valor.ToString("C")); // Valor monetário Brasil. "R$"
                //Console.WriteLine(valor2.ToString("P")); // Valor pencentua
                //Console.WriteLine(valor.ToString("#.##")); // Padrão que trará duas casas cedimais.

                //CultureInfo cultura = new CultureInfo("pt-BR");
                //Console.WriteLine(valor.ToString("C0", cultura));
                //Console.WriteLine(numero.ToString("D10")); // Completando com zeros a esquerda



                // ***** Fundamentos - Lendo dados do console *******


                //Console.Write("qual é o seu nome: ");
                //string nome = Console.ReadLine();
                //Console.Write("informe a sua primeira nota separada por vingula: ");
                //double.TryParse(Console.ReadLine(), out double nota1);
                //Console.Write("informe a sua segunda nota separada por virgula: ");
                //double.TryParse(Console.ReadLine(), out double nota2);

                //double media = (nota1 + nota2) / 2;

                //string resultadofinal = media >= 7 ? "Aprovado" : "Reprovado";

                //Console.WriteLine($"Sua media dentre as notas: {nota1} e {nota2} é: {media.ToString("f1")}.");
                //Console.WriteLine($"Resultado final: {resultadofinal}");

                // ***** Fundamentos - Interpolação de strings *******

                //string nome = "Notbook Games";
                //string marca = "Dell";
                //int preco = 8500;


                //Console.WriteLine("O " + nome + " de marca " + marca + " custa " + preco);
                //Console.WriteLine("O {0} de marca {1} custa {2} reais", nome, marca, preco);
                //Console.WriteLine($"O {nome} de marca {marca} custa {preco}.");

                //var saudacao = "Olá!".ToUpper().Insert(3, " World").Replace("World", "Mundo!");
                //Console.WriteLine(saudacao);

                //var meuNome = "Márcio".ToUpper().Insert(6, " Rodrigo").Length;
                //var nomeFilho = "Matheus".ToUpper().Insert(7, " Fischer");
                //var nomeFilha = "Julia".ToUpper().Insert(5, " Fischer");
                //string valorImportante = null; // dá problema

                //Console.WriteLine(meuNome);
                //Console.WriteLine(nomeFilho);
                //Console.WriteLine(nomeFilha);
                //Console.WriteLine(valorImportante?.Length); // Adicionando o ?, o c# só irá acessar a variável
                ////se a mesma estiver inicializada.

            }

        }

    }

}


