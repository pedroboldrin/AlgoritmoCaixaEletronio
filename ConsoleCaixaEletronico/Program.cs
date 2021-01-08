using System;
namespace ConsoleCaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            var Qtd200 = 0;

            var Qtd100 = 0;

            var Qtd50 = 0;

            var Qtd20 = 0;

            var Qtd10 = 0;

            var Qtd5 = 0;

            var Qtd2 = 0;

            Console.WriteLine("Bem Vindo Ao Caixa Eletronico!!!\n \n");
            Console.WriteLine("Sistema Iniciando, por favor defica a quantidade de cada nota!!!");
            Console.WriteLine("\nNotas de 200: ");
            Qtd200 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNotas de 100: ");
            Qtd100 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNotas de 50: ");
            Qtd50 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNotas de 20: ");
            Qtd20 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNotas de 10: ");
            Qtd10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNotas de 5: ");
            Qtd5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNotas de 2: ");
            Qtd2 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            var saldoCaixa = (200 * Qtd200) + (100 * Qtd100) + (50 * Qtd50) + (20 * Qtd20) + (10 * Qtd10) + (5 * Qtd5) + (2 * Qtd2);
            var salvarSaldoCaixa = saldoCaixa;



            var condicao = "";
            var sair = "";

            var novamente = 0;
            do
            {
                do
                {
                    var QtdNotasSacadas = "";
                    condicao = "";
                    if (saldoCaixa < 1000)
                        Console.WriteLine("\nAtencao!!! esse caixa tem somente saldo de " + saldoCaixa + " reais");
                    else
                        Console.WriteLine("\nO saque deve ser maisor que 2 reais e Menor que 1000 reais.");

                    Console.WriteLine("\nDigite o Valor do Saque: ");
                    var valorSaque = Convert.ToInt32(Console.ReadLine());
                    var valorSacado = valorSaque;
                    if (valorSaque >= 2 && valorSaque <= 1000 && valorSaque <= saldoCaixa)
                    {
                        sair = "";
                        novamente = 0;
                        // 200
                        if (valorSaque >= 200)
                        {
                            var QtdNotas = valorSaque / 200;

                            if (Qtd200 >= QtdNotas)
                            {
                                valorSaque = valorSaque % 200;
                                Qtd200 -= QtdNotas;
                                QtdNotasSacadas += "Notas 200: " + QtdNotas;
                            }
                            else if (Qtd200 > 0)
                            {
                                valorSaque -= Qtd200 * 200;
                                QtdNotasSacadas += " - Notas 200: " + Qtd200;
                                Qtd200 -= Qtd200;
                            }
                        }
                        // 100
                        if (valorSaque >= 100)
                        {
                            var QtdNotas = valorSaque / 100;

                            if (Qtd100 >= QtdNotas)
                            {
                                valorSaque = valorSaque % 100;
                                Qtd100 -= QtdNotas;
                                QtdNotasSacadas += " - Notas 100: " + QtdNotas;
                            }
                            else if (Qtd100 > 0)
                            {
                                valorSaque -= Qtd100 * 100;
                                QtdNotasSacadas += "Notas 100: " + Qtd100 + " - ";
                                Qtd100 -= Qtd100;
                            }
                        }
                        // 50
                        if (valorSaque >= 50)
                        {
                            var QtdNotas = valorSaque / 50;

                            if (Qtd50 >= QtdNotas)
                            {
                                valorSaque = valorSaque % 50;
                                Qtd50 -= QtdNotas;
                                QtdNotasSacadas += " - Notas 50: " + QtdNotas;
                            }
                            else if (Qtd50 > 0)
                            {
                                valorSaque -= Qtd50 * 50;
                                QtdNotasSacadas += " - Notas 50: " + Qtd50;
                                Qtd50 -= Qtd50;
                            }
                        }
                        // 20
                        if (valorSaque >= 20)
                        {
                            var QtdNotas = valorSaque / 20;

                            if (Qtd20 >= QtdNotas)
                            {
                                valorSaque = valorSaque % 20;
                                Qtd20 -= QtdNotas;
                                QtdNotasSacadas += " - Notas 20: " + QtdNotas;
                            }
                            else if (Qtd20 > 0)
                            {
                                valorSaque -= Qtd20 * 20;
                                QtdNotasSacadas += " - Notas 20: " + Qtd20;
                                Qtd20 -= Qtd20;
                            }
                        }
                        // 10
                        if (valorSaque >= 10)
                        {
                            var QtdNotas = valorSaque / 10;

                            if (Qtd10 >= QtdNotas)
                            {
                                valorSaque = valorSaque % 10;
                                Qtd10 -= QtdNotas;
                                QtdNotasSacadas += " - Notas 10: " + QtdNotas;
                            }
                            else if (Qtd10 > 0)
                            {
                                valorSaque -= Qtd10 * 10;
                                QtdNotasSacadas += " - Notas 10: " + Qtd10;
                                Qtd10 -= Qtd10;
                            }
                        }
                        // 5
                        if (valorSaque >= 5)
                        {
                            var QtdNotas = valorSaque / 5;

                            if (Qtd5 >= QtdNotas)
                            {
                                valorSaque = valorSaque % 5;
                                Qtd5 -= QtdNotas;
                                QtdNotasSacadas += " - Notas 5: " + QtdNotas;
                            }
                            else
                            {
                                valorSaque -= Qtd5 * 5;
                                QtdNotasSacadas += " - Notas 5: " + Qtd5;
                                Qtd5 -= Qtd5;
                            }
                        }
                        // 2
                        if (valorSaque >= 2)
                        {
                            var QtdNotas = valorSaque / 2;

                            if (Qtd2 >= QtdNotas)
                            {
                                valorSaque = valorSaque % 2;
                                Qtd2 -= QtdNotas;
                                QtdNotasSacadas += " - Notas 2: " + QtdNotas + " - ";
                            }
                            else
                            {
                                valorSaque -= Qtd2 * 2;
                                QtdNotasSacadas += "Notas 2: " + Qtd2 + " - ";
                                Qtd2 -= Qtd2;
                            }
                        }

                        if (valorSaque == 0)
                        {
                            sair = "sim";
                            Console.WriteLine("Saque de " + valorSacado + " retirado com sucesso\n" +
                                "Nesse saque foram utilizadas: " + QtdNotasSacadas);
                            saldoCaixa = salvarSaldoCaixa - valorSacado;
                            salvarSaldoCaixa = saldoCaixa;
                            if (saldoCaixa == 0)
                            {
                                Console.WriteLine("\nSaldo deste caixa zerado. Tente novamente mais tarde.");
                                novamente = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nO caixa nao tem notas suficente para cobrir o seu saque por faltar " +
                                valorSaque + ". \nDigite 1 para tentar novamente ou qualquer tecla para cancelar " +
                                "o saque");
                            if (novamente != 1)
                                sair = "sim";
                        }
                    }
                    else
                    {
                        if (valorSaque < 2 || valorSaque > 1000)
                        {
                            Console.WriteLine("\nO valor do saque deve ser maior ou igual a 2 e menor igual 1000 reais." +
                                " Digite 1 para tentar novamente e qualquer tecla para cancelar o saque");
                            novamente = Convert.ToInt32(Console.ReadLine());
                            if (novamente != 1)
                                sair = "sim";
                        }
                        else if (valorSaque > saldoCaixa)
                        {
                            Console.WriteLine("\nO valor de seu saque é maior que o total disponivel neste caixa. " +
                                "\nDigite 1 para tentar novamente e qualquer tecla para cancelar o saque");
                            novamente = Convert.ToInt32(Console.ReadLine());
                            if (novamente != 1)
                                sair = "sim";
                        }
                    }
                } while (sair != "sim");

                if (novamente == 0)
                {
                    Console.WriteLine("\nDigite 1 para sacar novamente ou qualquer tecla para sair\n");
                    condicao = Console.ReadLine();
                }
            } while (condicao == "1");

            Console.WriteLine("\nFinalizando o programa!!!");
        }
    }
}

