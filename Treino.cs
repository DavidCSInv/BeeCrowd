using System;
using System.Globalization;

/*namespace PrimeiroPorjeto
{
    internal class Program
    {
        static void Main(string[] args )
        {
            Console.Write("Ola mundo");
            Console.Write("BANANA ");
            
            /*É utilizado o writeline para quebrar a linha e não fazer a junção de duas
                                             * frases.
        }
    }
} */
/*
namespace curso
{
    class program 
    {

        static void Main(string[] args)
        {
            double x = 10.45445484451541984;

            Console.WriteLine(x);
            Console.WriteLine(x.ToString ("F3"));
            Console.WriteLine(x.ToString ("F1"));
            Console.WriteLine(x.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
} */

/*namespace writeline_basico
{
    class program
    {
        static void Main(string[] args)
        {
            double x = 8.48754;
            int y = 5;
            string d = "David";
            char s = 'M';

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(d);
            Console.WriteLine(s);

            Console.WriteLine("Ola mundo !");
            Console.WriteLine("Bom dia !");
            Console.WriteLine("Até mais");

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F5", CultureInfo.InvariantCulture));

            Console.WriteLine("Resultado" + y);
            Console.WriteLine("O valor do troco é " + x + "Reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + "REAIS");

            Console.WriteLine();
            Console.WriteLine("O paciente: " + d + " tem " + y + " Anos e seu sexo é: " + s);

            Console.ReadLine();


        }
    }
}*/

/*namespace writeline+readline_basico
{
    class program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            double resultado;

            resultado = (double) x / y;
            Console.WriteLine(resultado.ToString(CultureInfo.InvariantCulture));            
            Console.ReadLine();
        }
    }
}*/


/*namespace readline_basico
{
    class program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            Console.WriteLine("AAAAAAAAAA MAS VOCÊ DISSE  " + frase);
            Console.WriteLine("AAAAAAAAAA MAS VOCÊ DISSE  " + x);
            Console.WriteLine("AAAAAAAAAA MAS VOCÊ DISSE  " + y);
            Console.WriteLine("AAAAAAAAAA MAS VOCÊ DISSE  " + z);
        }

    }
}*/

/*namespace split_basico
{
    class program
    {
        static void Main(string[] args)
        {
            /*string frase = Console.ReadLine();
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
          
            /*Console.WriteLine("AAAAAAAAAA MAS VOCÊ DISSE  " + frase);
            Console.WriteLine("AAAAAAAAAA MAS VOCÊ DISSE  " + p1);
            Console.WriteLine("AAAAAAAAAA MAS VOCÊ DISSE  " + p2);
            Console.WriteLine("AAAAAAAAAA MAS VOCÊ DISSE  " + p3);
        }
    }
}*/


/*namespace teste
{  
    class program
    {
        static void Main (string[] args)
        {
            int P1 = int.Parse(Console.ReadLine());
            char P2 = char.Parse(Console.ReadLine());
            double P3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = (Console.ReadLine().Split(' '));
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            char sexo = char.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou :");
            Console.WriteLine(P1);
            Console.WriteLine(P2);
            Console.WriteLine(P3.ToString("F2", CultureInfo.InvariantCulture)) ;

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(sexo);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}*/

/*namespace entrada_de_dados
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo :");

            string nome = (Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Quantos quartos tem na sua casa ? ");

            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Entre com um preço de produto : ");

            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Entre seu ulitmo nome,idade e altura (mesma linha):");

            string[] inf = Console.ReadLine().Split(' ');
            string nome1 = inf[0];
            int idade = int.Parse(inf[1]);
            double altura = double.Parse(inf[2], CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Os dados digitaram foram :");
            Console.WriteLine(nome);
            Console.WriteLine("Quartos : " + quantidade);
            Console.WriteLine("Preço de algum produto : " + valor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Ultimo nome :" + nome1);
            Console.WriteLine("Idade : " + idade);
            Console.WriteLine("Altura :" + altura.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Favor validar");
        }


    }

} */

/*namespace funcoes_matematicas
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = 2.0;
            double y = 3.0;
            double z = 4.0;
            
            double A, B, C;

            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25);

            Console.WriteLine("A raiz quadrada de :" + x + " É " + A);
            Console.WriteLine("A raiz quadrada de :" + y + " É " + B);
            Console.WriteLine("A raiz quadrada de :" + 25 + " É " + C);

            A = Math.Pow(x,y);
            B = Math.Pow(x, 10);
            C = Math.Pow(25, 30);

            Console.WriteLine("o resultado de " + x  + " elevado a " + y + " é " + A);
            Console.WriteLine("o resultado de " + x  + " elevado a " + 10 + " é " + B);
            Console.WriteLine("o resultado de " + 25 + " elevado a " + 30 + " é " + C);

            A = Math.Abs(x);
            B = Math.Abs(y);
            C = Math.Abs(-3);

            Console.WriteLine("O valor absoluto de :" + x + " é " + A);
            Console.WriteLine("O valor absoluto de :" + y + " é " + B);
            Console.WriteLine("O valor absoluto de :" + -3 + " é " + C);
        }
    }
}*/

/*namespace exercicio
{
    class program
    {
        static void Main (string[] args)
        {
            double largura, comprimento, preco, area, valor;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura*comprimento;
            valor = preco * area;

            Console.WriteLine("AREA =" + area.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO =" + valor.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}*/

/*namespace exercicio2
{
    class program
    {
        static void Main(string [] args)
        {
            int A,B,X;


            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            X = A + B;


            Console.WriteLine("X = " + X);

        }


    }
}*/



/*namespace exercicio2
{
    class program
    {
        static void Main(string[] args)
        {

            double AREA, PI, RAIO, X;

            X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            PI = 3.14159;
            RAIO = Math.Pow(X, 2);
            AREA = PI * RAIO;

            Console.WriteLine("A=" + AREA.ToString("f4", CultureInfo.InvariantCulture));

        }

    }
}*/


/*namespace exercicio2
{
    class program
    {
        static void Main(string[] args)
        {
            double A, B, MEDIA;
           
            A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            MEDIA = (3.5*A + 7.5 * B)/11.0; 
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));
        
        }
    }
}

/*AQUI COMO AS VARIAVEIS TEM PESO É NECESSARIO MULTIPLICAR AMBOS POR SEUS PESOS é uma MEDIA PONDERADA.
  
 * TAMBEM É NECESSARIO DIVIDIR POR SEU VALOR TOTAL DE MEDIA*/

/*
namespace exercicio3
{
    class program
    {
        static void Main(string[] args)
        {
            double FIXO, VENDA, SOMA;
            
            string nome;

            nome = Console.ReadLine();
            FIXO = double.Parse(Console.ReadLine());
            VENDA = double.Parse(Console.ReadLine());
            SOMA = (VENDA * 15/100) + FIXO;
            

            Console.WriteLine("TOTAL = R$ " + SOMA.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}*/
/*
namespace areas
{
    class Program
    {
        static void Main (string [] args)
        {
            double tringulo,circulo,trapezio,quadrado,retangulo,pi;

            //A = BASE, B = LADO, C = ALTURA//

           string[] vet = Console.ReadLine().Split(' ');
           double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
           double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
           double c = double.Parse(vet[2], CultureInfo.InvariantCulture);
            pi = 3.14159;
            tringulo = (a * c) / 2;
            circulo = pi * Math.Pow(c, 2);
            trapezio = (a + b) * c / 2;
            quadrado = Math.Pow(b, 2);
            retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + tringulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}*/
/*
namespace o_maior
{
    class Program
    {
        static void Main (string[] args)
        {
            int a, b, c,maiorab,maiorabc;
            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            maiorab = (a+b+Math.Abs(a-b)) / 2;
            maiorabc = (maiorab + c + Math.Abs(maiorab - c)) / 2;

            Console.WriteLine(maiorabc + " eh o maior");
        }
    }
}
*/
/*
namespace media_combustivel
{
    class PROGRAM
    {
        static void Main(string[] args)
        {
            int m;
            double d,media;

            m = int.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());

            media = m / d;

            Console.WriteLine(media.ToString("F3",CultureInfo.InvariantCulture) + " km/l");


        }
    }
}*/
/*
namespace distancia_entre_pontos
{
    class program
    {
        static void Main (string [] args)
        {
            float x, x1, y, y1;
            string[] vet = Console.ReadLine().Split(' ');
            x = float.Parse(vet[0]);
            y = float.Parse(vet[1]);

            string[] vet1 = Console.ReadLine().Split(' ');
            x1 = float.Parse(vet1[0]);
            y1 = float.Parse(vet1[1]);

           double d = Math.Sqrt((Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2)));
        

           Console.WriteLine(d.ToString("F4",CultureInfo.InvariantCulture));

        }
    }
}*/
/*
namespace distancia
{
    class Program
    {
        static void Main (string[] args)
        {
            int x,y;
            x = int.Parse(Console.ReadLine());
            y = x * 2;

            Console.WriteLine (y + "minutos");
        }

    }
}
*/
/*namespace gasto_combustivel
{ 
    class Program
    {
        static void Main (string [] args)
        {
            int h, v;
            double combustivel,resultado;

            h = int.Parse(Console.ReadLine());
            v = int.Parse(Console.ReadLine());
            combustivel = (h * v);
            resultado = combustivel / 12;

            Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}*/
/*namespace cedulas
{ 
    class program   
    {
        static void Main (string [] args)
        {
            int N, calculo, resto, nota;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);
            resto = N;

            nota = 100;
            calculo = resto / nota;
            Console.WriteLine(calculo + " nota(s) de R$" + nota+",00");

            resto = resto % nota;

            nota = 50;
            calculo = resto / nota;
            Console.WriteLine(calculo + " nota(s) de R$" + nota + ",00");
            resto = resto % nota;

            nota = 20;
            calculo = resto / nota;
            Console.WriteLine(calculo + " nota(s) de R$" + nota + ",00");
            resto = resto % nota;

            nota = 10;
            calculo = resto / nota;
            Console.WriteLine(calculo + " nota(s) de R$" + nota + ",00");
            resto = resto % nota;

            nota = 5;
            calculo = resto / nota;
            Console.WriteLine(calculo + " nota(s) de R$" + nota + ",00");
            resto = resto % nota;

            nota = 2;
            calculo = resto / nota;
            Console.WriteLine(calculo + " nota(s) de R$" + nota + ",00");
            resto = resto % nota;

            nota = 1;
            calculo = resto / nota;
            Console.WriteLine(calculo + " nota(s) de R$" + nota + ",00");



        }
    }
}*/

/*
namespace cedulas
{
    class program
    {
        static void Main(string[] args)
        {

            int horas;

            Console.WriteLine("Quantas horas ?");
            
            horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia, para você");
            }
            
            else if (horas < 18)

            {
                Console.WriteLine("Boa tarde, para você");
            }
            else
            {
                Console.WriteLine("Boa noite.");
            }


        }
    } }*/
/*
namespace nota { 
    class program
    {
        static void Main (string[] args)
        {
            double nota, nota1, final;

            Console.WriteLine("Ola indique sua primeira nota : ");
            nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("indique sua segunda nota : ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            final = nota + nota1;

            if (final > 60)
            {
                Console.WriteLine("Parabens você passou, sua nota final é " + final.ToString("F2",CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Parabens você reprovou, sua nota final é " + final.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
            } 
        }
    }
}*/
/*
    namespace nota
    {
        class program
        {
            static void Main(string[] args)
            {

                double A, B, C, delta,x,x1;

                String[] vet = Console.ReadLine().Split(' ');
                A = double.Parse(vet[0], CultureInfo.InvariantCulture);
                B = double.Parse(vet[1], CultureInfo.InvariantCulture);
                C = double.Parse(vet[2], CultureInfo.InvariantCulture);

                delta = Math.Pow(B, 2) - 4 * A * C;

                if ((A * C) == 0.0 || delta < 0.0 )
                {
                
                    Console.WriteLine("Impossivel Calcular");

                }

                else

                {
                    x = (-B + Math.Sqrt(delta)) / (2.0 * A);
                    x1 = (-B - Math.Sqrt(delta)) / (2.0 * A);

                    Console.WriteLine("X1 = " + x.ToString("F5",CultureInfo.InvariantCulture));
                    Console.WriteLine("X2 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                }
            }
        }
    }


*/
/*namespace nota
{
    class program
    {
        static void Main(string[] args)
        {

            int a, b, c;

            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            if (a < b && a < c)
            {
                Console.WriteLine("MENOR = " + a);
            }
            else if (b < a && b<c) {
                Console.WriteLine("MENOR = " + b);
            }
            else
            {
                Console.WriteLine("MENOR = " + c);
            }
        }
    }
}
*/
/*
namespace cobrança
{
    class program
    {
        static void Main(string[] args)
        {

            double cobra;

            int minutos;

            minutos = int.Parse(Console.ReadLine());

            cobra = 50.00;

            if (minutos > 100){

                cobra += (minutos - 100) * 2;

            }

                Console.WriteLine("Valor a pagar : R$" + (cobra));

        }
    }
}*/
/*
namespace banana
{
    class program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1:
                    dia = "Domingo";
                break;

                case 2:
                    dia = "Segunda";
                break;
                case 3:
                    dia = "Terça";
                break;
                case 4:
                    dia = "Quarta";
                break;
                case 5:
                    dia = "Quinta";
                break;
                case 6:
                    dia = "Sexta";
                break;
                case 7:
                    dia = "SabAAAAAAAAAASSO";
                break;

                default:
                    dia = "Numero invalido";
                    break;

            }
            Console.WriteLine("O dia da semana é : " + dia);

        }
    }*/
/*
namespace banana
{
    class program
    {
        static void Main(string[] args)
        {

            int A, B;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);

            B = int.Parse(vet[1]);

            if ((A % B) == 0 || (B % A) == 0)
            {

                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}*/

