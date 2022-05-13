Alteração teste github 2ª vez

Acessar o Visal Studio via Terminal para acompanhar o curso CFB


1º inserir via prompt a linha: C:\Users\Basis Tecnologia>PATH %path%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319

2º acessar o caminho: C:\Users\Basis Tecnologia\source>cd repos\

3º Para compilar executar a linha a seguir: C:\Users\Basis Tecnologia\source\repos\Aula25\Aula25>csc Program.cs

4º Por fim, para dorar o programa, executar a linha a seguir: C:\Users\Basis Tecnologia\source\repos\Aula25\Aula25>Program


*******************************************

Algoritimo para converter real para dolar

double Real, Dolar;

            Console.Write("Informe o valor em R$: ");
            Real =  Convert.ToDouble(Console.ReadLine());

            Dolar = (Real / 3.45);

            //Console.WriteLine("O valor de {0} reais convertido para dolar é de U$$ {1}", Real, Dolar); // Para comentário.
			Console.WriteLine("O valor convertido de R$ para U$ é de:" + Math.Round(Dolar, 2).ToString()); // Math.Round(Dolar, 2).ToString() Metodo para colocar 2 duas casas após a vírgula.

            Console.ReadKey();
			
**********************************************
Algoritimo  para saber o total da area bem como a quantidada de tinta a ser gasta

            Console.WriteLine("***********************");
            Console.WriteLine("    Consumo de Tinta   ");
            Console.WriteLine("***********************");

            Console.Write("Informe a largura da parede: ");
            double.TryParse(Console.ReadLine(), out double larguraDaParede);

            Console.Write("informe a altura da parede: ");
            double.TryParse(Console.ReadLine(), out double alturaDaParede);

            double area = larguraDaParede * alturaDaParede;
            double tinta = (larguraDaParede * alturaDaParede) / 2;

            Console.WriteLine($"A areá que deverá ser pinta é de {area.ToString("f2")}m2. ");
            Console.WriteLine($"E a quantidade de tinta a ser utilizadaa será de {tinta.ToString("f2")}litros");

***********************************************
Algoritimo para calcular a media do aluno

            Console.WriteLine("***********************");
            Console.WriteLine("    Media do Aluno  ");
            Console.WriteLine("***********************");

            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Informe a primeira nota: ");
            double.TryParse(Console.ReadLine(), out double nota1);

            Console.Write("Informe a segunda nota: ");
            double.TryParse(Console.ReadLine(), out double nota2);

            double media = (nota1 + nota2) / 2;

            string resultado = media >= 7 ? "Aprovado" : "Reprovado";

            Console.WriteLine($"O aluno: {nome} dentre as notas: {nota1} e {nota2} teve" +
             $" a média: {media.ToString("f2")}. Com isso, o resultado final é: {resultado}");			

***********************************************
Algoritimo para calcular a idade

            Console.WriteLine("************************************");
            Console.WriteLine("Programa para calcular a idade atual");
            Console.WriteLine("************************************");

            Console.Write("Em que ano estamos? ");
            int.TryParse(Console.ReadLine(), out int anoAtual);
            Console.Write("Em que ano você nasceu? ");
            int.TryParse(Console.ReadLine(), out int anoNascimento);

            int idadeAtual = anoAtual - anoNascimento;

            Console.WriteLine($"Sua idade atual é {idadeAtual} anos de idade.");
			
***********************************************
Algoritimo para validar a maioridade
   
            Console.writeline("************************************");
            Console.writeline("programa para calcular a idade atual");
            Console.writeline("************************************");

            Console.write("em que ano estamos? ");
            int.tryparse(Console.readline(), out int anoatual);
            Console.write("em que ano você nasceu? ");
            int.tryparse(Console.readline(), out int anonascimento);

            int idadeatual = anoatual - anonascimento;

            Console.writeline($"sua idade atual é {idadeatual} anos de idade.");

            if (idadeatual >= 18) {
                console.writeline("maior de idade");
            } else {
                Console.writeline("manor de idade");
            }
		

***********************************************
Algoritmo para saber o dobro e terca parte de um numero

	    Console.WriteLine("**********************************************");
            Console.WriteLine("Programa para saber a terca parte de um numero");
            Console.WriteLine("**********************************************");

            Console.Write("Informe o primeiro numero: ");
            int.TryParse(Console.ReadLine(), out int valor1);
            Console.Write("Informe o segundo numero: ");
            int.TryParse(Console.ReadLine(), out int valor2);

            double soma = valor1 + valor2;
            double tercaParte = soma / 3;

            Console.WriteLine($"A soma entre {valor1} e {valor2} é: {soma}");
            Console.WriteLine($"A terça parte de {soma} é {tercaParte}");
			
************************************************
Algoritimo para calcular a Media do aluno, dentre duas notas com o nome do curso

double Nota1, Nota2, Media;

            Console.WriteLine("********************");
            Console.WriteLine("*******Curso********");
            Console.WriteLine("********************");
            Console.Write("Digite a primeira nota: ");
            Nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            Nota2 = Convert.ToDouble(Console.ReadLine());

            Media = (Nota1+Nota2)/2;

            Console.WriteLine("Sua média é {2}",Nota1,Nota2,Media);

            if (Media >= 7)
            {
                Console.WriteLine("Você foi Aprovado");
            }
            else
            {
                Console.WriteLine("Você foi reprovado");
            }
                    Console.ReadKey();
					

***********************************
Algoritimo para descobrir o numero antecessor e sucessor do valor informado

            Console.WriteLine("********************************************************");
            Console.WriteLine("Programa para saber o antecessor e sucessor de um número");
            Console.WriteLine("********************************************************");

            Console.Write("Informe um número ");
            int.TryParse(Console.ReadLine(), out int numero);

            int antecessor = numero - 1;
            int sucessor = numero + 1;

            Console.WriteLine($"O numero que antessede e sussede {numero} é: {antecessor} / {sucessor}");
			
************************************
Algoritimo para saber o valor de Delta

    int A, B, C, Delta;

            Console.Write("Digite um valor para A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor para B: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor para B: ");
            C = int.Parse(Console.ReadLine());

            Delta = (B*B) - (4*A*C);

            Console.Write("O valor de delta é {3}", A, B, C, Delta);

            Console.ReadKey();


*************************************
Algorittmo pra descobrir se o numero é par ou impar

            Console.WriteLine("********************************************************");
            Console.WriteLine("    Programa para saber o se o número é par ou impar    ");
            Console.WriteLine("********************************************************");

            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out int numero);

            if (numero % 2 == 0) {
                Console.WriteLine($"O número {numero} é par");
            } else {
                Console.WriteLine($"O número {numero} é impar");


            }

****************************************
Algoritimo para cucular o IMC

            Console.WriteLine("************************");
            Console.WriteLine("    Cauculo de IMC      ");
            Console.WriteLine("************************");
            Console.Write("Informe o seu peso em KG: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a sua altura M: ");
            double altura = double.Parse(Console.ReadLine());

            double IMC = peso / (altura * altura);

            if (IMC < 20)
            {
                Console.WriteLine("\nIMC = " + IMC + " -> Abaixo do peso.");
            }
            else if ((IMC >= 20) && (IMC <= 24))
            {
                Console.WriteLine("\nIMC = " + IMC + " -> Peso normal.");
            }
            else if ((IMC >= 25) && (IMC <= 29))
            {
                Console.WriteLine("\nIMC = " + IMC + " -> Acima do peso.");
            }
            else if ((IMC >= 30) && (IMC <= 34))
            {
                Console.WriteLine("\nIMC = " + IMC + " -> Obesidade.");
            }
            else
            {
                Console.WriteLine("\nIMC = " + IMC + " -> Muito obeso.");

            }

                Console.ReadKey();
				
				
				
********************************************************
Algoritimo para saber a media e aproveitamento do aluno

            Console.WriteLine("********************************************************");
            Console.WriteLine("     Programa para saber a média fina do aluno");
            Console.WriteLine("********************************************************");

            Console.Write("Informe a 1ª nota: ");
            double.TryParse(Console.ReadLine(), out double nota1);

            Console.Write("Informe a 2ª nota: ");
            double.TryParse(Console.ReadLine(), out double nota2);

            Console.Write("Informe a 3ª nota: ");
            double.TryParse(Console.ReadLine(), out double nota3);

            double media = (nota1 + nota2 + nota3) / 3;

            if (media < 5) {
                Console.WriteLine("Aproveitamento F");
            } else if (media >= 5 && media < 5.9) {
                Console.WriteLine("Aproveitamento E");
            } else if (media >= 6 && media < 6.9) {
                Console.WriteLine("Aproveitamento D");
            } else if (media >= 7 && media < 7.9) {
                Console.WriteLine("Aproveitamento C");
            } else if (media >= 8 && media < 8.9) {
                Console.WriteLine("Aproveitamento B");
            } else {
                Console.WriteLine("Aproveitamento A");
            }

            Console.WriteLine($"Sua média final foi: {media.ToString("f2")}");


        }

********************************************
Algoritimo para descontar 8% do valor do produto 

            Console.WriteLine("**********************");
            Console.WriteLine(" Desconto em Produto  ");
            Console.WriteLine("**********************");

            Console.WriteLine("Digite o valor do produto R$ ");
            double V = double.Parse(Console.ReadLine());
            double percentual = 8.0 / 100.0; // 8%
            double valor_final = V - (percentual * V);

            Console.WriteLine("O valor final do produto com desconto é de R$: " + valor_final);

            Console.WriteLine("\nPressione qualquer tecla para sair..."); // A funcção \n se faz necess´rio para quebrar uma linha.
         
            Console.ReadKey();


*********************************************
Algoritimo para tirar a média do aluno entre 3 notas

            double n1, n2, n3, media;
            string nome, endereco, idade; 

            Console.WriteLine("*************************");
            Console.WriteLine("      Média do aluno     ");
            Console.WriteLine("*************************");
            Console.Write("Qual é o seu nome?  ");
            nome = string.Format(Console.ReadLine());
            Console.Write("Digite o seu endereço: ");
            endereco = string.Format(Console.ReadLine());
            Console.Write("Informe sua idade: ");
            idade = string.Format(Console.ReadLine());
            Console.Write("Digite a primeiro nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            n3 = double.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            Console.WriteLine("\nO aluno: " +nome+ "\nResidente em: "+endereco+"\nIdade: "+idade+"\nTeve a média: " + media);

            Console.WriteLine("\nPressione qualquer tecla para sair...");

            Console.ReadKey();

*******************************
Algoritimo média de duas notas:

            double n1,n2,media;
           
            Console.WriteLine("*************************");
            Console.WriteLine("      Média do aluno     ");
            Console.WriteLine("*************************");			
		    Console.Write("Digite a Primeira nota: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());

            media = (n1 + n2) / 2;

            if (media >= 7) // IF significa "Se"

            {
                Console.WriteLine("Aluno teve a media: " +media+ "\nResultado: Aprovado");
            }
            else // ELSE significa "Se não"
            {
                Console.WriteLine("Aluno teve a media: " + media + "\nResultado: Reprovado");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");

            Console.ReadKey();

*********************************
Algoritimo simples IF

Operadores de Comparação

Maior ou Igual >=
Menor ou Igual <=
Igual ==
Diferente !=
Atribuição =


            int nota = 50;
            string resultado = "Reprovado";

            if (nota>=60)
            {
                resultado = "Aprovado";
            }
            Console.WriteLine("Resultado: " + resultado);

            Console.ReadKey();

*****************************************
Algoritimo para tirar a média com IF Aninhado

       static void Main(string[] args)
        {

            double Nota1, Nota2, Media;

            Console.WriteLine("********************");
            Console.WriteLine("*******Curso********");
            Console.WriteLine("********************");
            Console.Write("Digite a primeira nota: ");
            Nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            Nota2 = Convert.ToDouble(Console.ReadLine());

            Media = (Nota1 + Nota2) / 2;

            Console.WriteLine("Sua média é {2}", Nota1, Nota2, Media);

            if (Media >= 7)
            {
                if (Media >= 9)
                {
                    Console.WriteLine("Você foi Aprovado com louvor");
                }
                else
                {
                    Console.WriteLine("Você foi Aprovado");
                }
                }
                else
                {
                if (Media >= 4)
                {
                    Console.WriteLine("Você está em recuperação");
                }
                else
                {
                    Console.WriteLine("Você está reprovado");
                }

                          }
            Console.ReadKey();

        }
    }
}

********************************
Algoritimo de escolha usando o SWITCH - IF

static void Main()
        {
            int tempo;
            char escolha;
            
            Console.WriteLine("Belo Horizonte/MG -> Vitória/ES");
            Console.WriteLine("Escolha o transporte: [a]Avião [c]Carro [o]Ônibus");
            escolha = char.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 'a':
                case 'A':
                    tempo = 50;
                    break;
                case 'c':
                case 'C':
                    tempo = 480;
                    break;
                case 'o':
                case 'O':
                    tempo = 660;
                    break;
                default:
                    tempo = -1;
                    break;
                    }
                    if (tempo < 0)
                    {
                        Console.WriteLine("Transporte indisponivel");
                    }
                    else 
                    {
                        Console.WriteLine("O tempo para o transporte escolhido é de: " + tempo+ " minutos");
                    }
                    Console.ReadKey();
            }
        }
    }

***********************************
Algoritimo para avaliar atendimento.

	    Console.WriteLine("*********************************");
            Console.WriteLine("Programa para avaliar atendimento");
            Console.WriteLine("*********************************");

            Console.WriteLine("Qual a sua avaliação para o nosso atendimento");
            Console.Write("Digite o valor entre (0 e 5): ");
            int.TryParse(Console.ReadLine(), out int avaliacao);

            switch (avaliacao) {
                case 0:
                    Console.WriteLine("Atendimento Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Atendimento Ruim");
                    break;
                    case 3:
                    case 4:
                    Console.WriteLine("Atendimento Bom");
                    break;
                case 5:
                    Console.WriteLine("Atendimento ótimo");
                    break;
                default:
                    Console.WriteLine("Nota inválida");
                    break;
            }

            Console.WriteLine("Obrigado por responder.");




        }


*******************************
Algoritimo usando VETOR / ARRAY


            //int n1, n2, n3, n4, n5;
            //int[] n = new int[5];
            //int[] num = new int[3] { 55,77, 99 }; //Outro tipo de declaração de Array
            //int[] num = { 55, 77, 99 }; // Informando direto os valores no Array
            string[] veiculos = new string[3];

            veiculos[0] = "Carro";
            veiculos[1] = "Avião";
            veiculos[2] = "Navio";

            //n[0] = 11;
            //n[1] = 22;
            //n[2] = 33;
            //n[3] = 44;
            //n[4] = 55;

            Console.WriteLine(veiculos[1]);

            Console.ReadKey();
        }
    }
}

*********************************
Algoritimo usando MATRIZES / VETOR BIDIRECIONAL

            int[,] n = new int[3,5];
            /* Comentário - Matriz de 5 colunas e 3 linhas
			
            10 12 14 15 16 
            17 18 19 20 21
            30 40 50 60 70

           Fim do comenátio 
            */ 

            n[0,0] = 10;
            n[0,1] = 12;
            n[0,2] = 14;
            n[0,3] = 15;
            n[0,4] = 16;

            n[1, 0] = 17;
            n[1, 1] = 18;
            n[1, 2] = 19;
            n[1, 3] = 20;
            n[1, 4] = 21;

            n[2, 0] = 30;
            n[2, 1] = 40;
            n[2, 2] = 19;
            n[2, 3] = 20;
            n[2, 4] = 21;

            Console.WriteLine(n[0,1]);

            Console.ReadKey();



        }
    }
}

**************************************
Algoritimo usando LOOP / FOR

// Vai imprimir o texto "CFB cursos" 10 vezes.       
	   {
            for (int num = 0; num < 10; num++)
                Console.WriteLine("CFB Cursos");
            
                Console.ReadKey();

        }
    }
}

// Exemplo 2 Vai imprimir o valor de num com incremento

          for (int num = 0; num < 10; num++)
                Console.WriteLine("Valor de num"+num);
            
                Console.ReadKey();

        }
    }
}


// Exemplo 3 LOOP FOR UTILIZANDO MATRIZ-ARRAY

            int[] num = new int[10];

            for (int i = 0; i < 10; i++){
                num[i] = 0;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("O valor de num para a pos{0}: {1}", i, num[i]);
            }

                Console.ReadKey();

        }
    }
}

// Exemplo 3 LOOP FOR UTILIZANDO MATRIZ-ARRAY e SETANDO O INCREMENTO COM O "LENGTH"


            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++){
                num[i] = 0;
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("O valor de num para a pos{0}: {1}", i, num[i]);
            }

                Console.ReadKey();

        }
    }
}


**************************************
Algoritimo usando WHILE - EM QUANTO

            int[] num = new int[10];

            int i = 0;

            while (i<10) {
                Console.WriteLine("CFB Cursos");
                i++;
            }

            Console.ReadKey();

        }
    }
}


****************************
Algoritimo usando DO - WHILE - 

// Nessa condição o WriteLine será executado pelo menos 1 vez.

            int num = 5;

            do{
                Console.WriteLine("CFB cussos"); 
            } while (num < 5);

            Console.ReadKey();
        }
    }
}

// Exemplo de programa de senha. Onde será executado até que a senha digita seja a declarada na variável senha.

            string senha = "123";
            string senhauser;
            int tentativa = 0;

            do{
                Console.Clear();
                Console.WriteLine("Digite a senha");
                senhauser = Console.ReadLine();
                tentativa++;
            } while (senhauser != senha);
			
            Console.Clear();
            Console.WriteLine("Senha correta. Numero de tentativas: "+tentativa);

            Console.ReadKey();
        }
    }
}

******************************
Algoritimos Metodos de Arrays

            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[5];
            int[,] matriz = new int[2, 5] { { 11, 22, 00, 44, 55 }, { 66, 77, 88, 99, 00 } };// Matriz de 2 colunas e 5 linhas

            Random random = new Random(); // A classe "Random" traz a numeração aleatório.
            for (int i = 0; i < vetor1.Length; i++) {
                vetor1[i] = random.Next(50);
            }
            Console.WriteLine("Elemento do vetor1"); // O "for" é para percorrer toda linha
            foreach (int n in vetor1) {
                Console.WriteLine(n); // Console.WriteLine usa-se para impressão na tela
            }

            // puclic static int BinarySearch(array,valor) // BinarySearch retorna a posição do elemento procurado.
            // Caso o valor retorne -1, é porque o valor não foi encontrado no array
            Console.WriteLine("BinarySearch");
            int procurado = 33;
            int pos = Array.BinarySearch(vetor1,procurado);
            Console.WriteLine("Valor {0} na posição {1}", pos, procurado);
            Console.WriteLine("****************************************");
			
			
			// public static void Copy(Ar_origem,Ar_destino,qtde_elementos);
            Console.WriteLine("Copy");
            Array.Copy(vetor1, vetor2, vetor1.Length);
            foreach (int n in vetor2) {
                Console.WriteLine(n);
            }
            Console.WriteLine("--------------------------------------");
			
			
			    // public static void CopyTo(Ar_destino,a_partir_desta_posicao)
            Console.WriteLine("CopyTo");
            vetor1.CopyTo(vetor3, 0);
            foreach (int n in vetor3) {
                Console.WriteLine(n);
            }
            Console.WriteLine("--------------------------------------");



            Console.ReadKey(); // Usa-se para congelar a tela´no final. Só será prosseguido após telcra o "Enter"
        }
    }
}


*****************************************
Algoritimo Métodos C#

Definição

O que são métodos? São conjunto de instruções/Blocos que pode ser chamado a qualquer momento no programa.

Ex: 1

        static void Main()
        {
            cfb(); // Declarando o metodo
        }
        static void cfb(){
            Console.WriteLine("CFB Cursos");
            Console.WriteLine("Curso de C#");
            Console.WriteLine("Youtube");

            Console.ReadKey();

        }

    }
}


Ex: 2

        static void Main() {
            soma(10, 5);
        }

        static void soma(int n1, int n2) {
            int res = n1 + n2;
            Console.WriteLine("A soma de {0} e {1} é igual a: {2}", n1, n2, res);

            Console.ReadKey();
        }
 

    }
}

*****************************
Algoritimo usando Passagem por valor e por referência

Exemplo sem o REF.



       static void Main(){
            int num = 10;
            dobrar(num);
            Console.WriteLine(num);
        }
        static void dobrar(int valor){
            valor *= 2;
        }
          
        }

        }          
    

Exemplo com o REF

        static void Main()
        {
            int num = 50;
            dobrar2(ref num);
            Console.WriteLine(num);
        }
        static void dobrar1(ref int valor)
        {
            valor *= 2;
        }
        static void dobrar2(ref int valor)
        {
            valor *= 2;
        }

        } 

        }
		
********************************
Algoritimo usando Argumento out

Exemplo usando o out.

       static void Main(){
            int divid, divis, quoc, rest;
            divid=10;
            divis=5;
            quoc = divide(divid, divis, out rest);

            Console.WriteLine("{0]/{1}: quociente={2} e resto={3}",divid,divis,quoc,rest);

        }
        static int divide(int dividendo, int divisor, out int resto){
            int quociente;
            quociente=dividendo/divisor;
            resto=dividendo%divisor;
            return quociente;
        }
    }
}

********************************
Algoritimo usando Argumento usando params

        static void Main(string[] args)
        {
            soma(10,10,10,85);
        }
        static void soma(params int[] n)
        {
            int res = 0;

            if (n.Length < 1)
            {
                Console.WriteLine("Não existem valores a serem somados");
            }
            else if (n.Length < 2)
            {
                Console.WriteLine("Valores insuficientes para soma {0}", n[0]);
            }
            else {
                for (int i = 0; i < n.Length; i++) {
                    res += n[i];
                }
                Console.WriteLine("A soma dos valores é {0}",res);

                Console.ReadKey();
              
            }
          
        }

    }
}


Acessar o Visal Studio via Terminal para acompanhar o curso CFB


1º inserir via prompt a linha: C:\Users\Basis Tecnologia>PATH %path%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319

2º acessar o caminho: C:\Users\Basis Tecnologia\source>cd repos\

3º Para compilar executar a linha a seguir: C:\Users\Basis Tecnologia\source\repos\Aula25\Aula25>csc Program.cs

4º Por fim, para dorar o programa, executar a linha a seguir: C:\Users\Basis Tecnologia\source\repos\Aula25\Aula25>Program


********************************
Algoritimo usando Argumento usando Classes e objetos.


//------ESBOÇO DA CLASSE MOSTRADA NA AULA:---------------------------------------//

//      [ModificadorClasse] class NOME_DA_CLASSE
//      {
//      Variáveis / Propriedades
//      [EspecificadorAcesso] tipo NOME_PROPRIEDADE;
//      
//      Metodos
//      [EspecificadorAcesso] retorno NOME_METODO([arg1,...])
//      {
//      corpo do método
//      }
// }

//-------O QUE SÃO E APLICAÇÕES:-----------------------------------------------//

//      [ModificadorClasse]: Define a visibilidade da classe.
//      public: pública, sem restrição de visualização.
//      abstract: Classe-Base para outrsas classes, não podem ser instanciados a objetos desta classe
//      sealed: Classe não pode ser herdada
//      static: Classe não permite a instanciação de objetos e seus membros devem ser "static"
//
//      [EspecificadorAcesso]: Onde um membro da classe pode ser acessado
//      public: pública, sem restrição de acesso.
//      private: Só podem ser acessados pela própria classe.
//      protected: Podem ser acessados na própria classe e nas classes derivadas
//      abstract: Os métodos não tem implementação somente os cabeçalhos
//      sealed: O método não pode ser redefinido.
//      virtual: O método pode ser redefinido em uma classe derivada.
//      static: o método pode ser chamado mesmo sem a instanciação de um objeto.

  public class Jogador // Classe
    {
        public int energia=100; // Propriedade

        public bool vivo=true; // Propriedade
    }
    class Program
    {
        static void Main()
        {
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador();
            Jogador j3 = new Jogador();

            j1.energia = 50;
            Console.WriteLine("A enegia do jogador 1 é {0}",j1.energia);
            Console.WriteLine("A enegia do jogador 1 é {0}",j2.energia);
        }

               

    }
}


********************************
Algoritimo usando Construtores e Destrutores.

Exemplo 1

    public class Jogador{

        public int energia;
        public bool vivo;
        public string nome;
		
        public Jogador(string n) { // Metodo Construtor
        {
            energia = 100;
            vivo = true;
            nome = n;
        }
    }
        class Program
        {
            static void Main()
            {
                Jogador j1 = new Jogador("Bruno");
                Jogador j2 = new Jogador("Márcio");

                Console.WriteLine("Nomo do jogador 1 {0}", j1.nome);
                Console.WriteLine("Nomo do jogador 2 {0}", j2.nome);
            }

        }

    }
}

Exemplo 2

    public class Jogador{

        public int energia;
        public bool vivo;
        public string nome;
        public Jogador(string n) { 
        {
            energia = 100;
            vivo = true;
            nome = n;
        }
    }
        class Program
        {
            static void Main()
            {
                string nome1;
                Console.WriteLine("Digite o nome do jogador 1"); // Recebendo do teclado
                nome1 = Console.ReadLine();
                Jogador j1 = new Jogador(nome1);
                Jogador j2 = new Jogador("Márcio");

                Console.WriteLine("Nomo do jogador 1 é {0}", j1.nome);
                Console.WriteLine("Nomo do jogador 2 é {0}", j2.nome);
            }

        }

    }
}

Exemplo 3

public class Jogador{

        public int energia;
        public bool vivo;
        public string nome;
		
        public Jogador(string n) { // Metodo Construtor
        {
            energia = 100;
            vivo = true;
            nome = n;
			
			~Jogador(); // Metodo destrutor recebi o "~"
        }
    }
        class Program
        {
            static void Main()
            {
                Jogador j1 = new Jogador("Bruno");
                Jogador j2 = new Jogador("Márcio");

                Console.WriteLine("Nomo do jogador 1 {0}", j1.nome);
                Console.WriteLine("Nomo do jogador 2 {0}", j2.nome);
            }

        }

    }
}