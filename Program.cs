using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Exercicio_01
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = "Vinicius", sobrenome = "Cazuza", responsive = "null", operacao = ""; 
            bool sair = false;
            int imparPar = 0, idade = 0, result = 0;
            string[] id = {};
            id = new string[10];
            

            Console.WriteLine($"\nTem um tal de Vinicius Cazuza que não pode entrar nesse Sistema, caso seu nome seja esse nem tente!\nCaso Contrario seja bem-Vindo(a) \n");
            Console.WriteLine($"\nOlá por gentileza digite seu Primeiro Nome: \n");
            name = Console.ReadLine();
            Console.WriteLine($"\nAgora digite seu Segundo Nome: \n");
            sobrenome = Console.ReadLine();



            while (sair == false)
                {
                    id = new string[] {name + " " + sobrenome};
                    if (id [0] != "Vinicius Cazuza" )
                    {
                        
                        if (idade == 0 )
                        {
                            Console.WriteLine($"\nAgora quantos anos você tem ?: \n");
                        idade = int.Parse(Console.ReadLine());
                        }
                        if (idade >= 18){
                        Console.WriteLine($"\n\n\n {id[0]} Seja Bem-Vindo(a) ao nosso Sistema!");
                        sair = true;
                        responsive = "s";
                        }
                        else
                        {   

                                Console.WriteLine($"\nVerificamos que você não tem idade para entrar nesse Sistema! \n\n Deseja corrigir a sua idade ? \n(s) Sim \n(n) Não\n");
                                responsive = Console.ReadLine();
                                    if (responsive == "s")
                                    {
                                    Console.WriteLine($"\nOk por gentileza, digite sua idade novamente:");
                                    idade = int.Parse(Console.ReadLine());
                                    }
                                    else
                                    {
                                        sair = true;
                                        responsive = "null";
                                    }
                        }
                    }
                    else 
                        {
                            Console.WriteLine($"\nVerificamos que você esta BANIDO desse Sistema! \n\n Deseja inserir outro Nome e Sobrenome ? \n(s) Sim \n(n) Não\n");
                            responsive = Console.ReadLine();
                                if (responsive == "s")
                                {
                                Console.WriteLine($"\nOk por gentileza, digite seu Nome novamente:");
                                name = Console.ReadLine();
                                Console.WriteLine($"\nNome registrado com sucesso!\n\n Agora digite seu Segundo Nome: \n");
                                sobrenome = Console.ReadLine();
                                    
                                }
                                    else if (responsive == "n")
                                    {
                                        sair = true;
                                    }
                                        else 
                                        {
                                            Console.WriteLine("Não entendi a sua resposta");
                                        }
                        
                        }
                }
                    if (sair == true && responsive != "n" && responsive != "null")
                        {
                        Console.WriteLine($"\n {name}, seu cadastro foi feito, parabens!\n");
                         responsive = "!";
                        }
                        
                            
        while (responsive == "s" || responsive == "!" && responsive != "null")
            { 
                Console.WriteLine($"Agora {name}, vamos fazer uma coisa bem legal, me diga um numero qualquer e eu irei te dizer se é Impar ou Par, Let's Go ?! \n");
                imparPar = int.Parse(Console.ReadLine());

                result = (imparPar % 2);

                if (result == 1)
                    {
                        Console.WriteLine($"\nSeu número é Impar, sei muito né, obrigado");
                    }
                        else 
                        {
                            Console.WriteLine($"\nSeu número é Par, incrivel né!!");
                        }
                    
                Console.WriteLine($"\nDeseja digitar outro número {name} ?\n(s) Sim\n(n) Não\n");
                responsive = Console.ReadLine ();
            }
        while (responsive == "n" && responsive != "null" )
            { 
                Console.WriteLine($"\nAgora {name}, vamos fazer uma taboada, Let's Go ?! \n");
                Console.WriteLine($"Me diga o de qual operacao voce gostaria de fazer:\n(*) Multiplicacao \n");
                operacao = Console.ReadLine();
                int cont = 1, resultado, valor;

                    if (operacao == "+")
                    {
                        Console.WriteLine($"\n{name}Ok!! Voce escolheu Adicao, incrivel\n Agora me diga, qual numero gostaria de Taboar ??\n");
                        valor = int.Parse(Console.ReadLine());

                        while (cont < 10)
                        {
                            resultado = (cont + valor);
                            Console.WriteLine(cont + " + " + valor + " = " + resultado);
                            cont++;
                        }

                        Console.WriteLine($"\nGostaria de parar ??\n(s) Sim\n(n) Não\n");
                        responsive = Console.ReadLine();
                    }
                    else if (operacao == "*")
                        {
                            Console.WriteLine($"\nOk {name}!! Voce escolheu Multiplicacao, incrivel\n Agora me diga, qual numero gostaria de Taboar ??\n");
                            valor = int.Parse(Console.ReadLine());

                            while (cont < 10)
                            {
                                resultado = (cont * valor);
                                Console.WriteLine(cont + " * " + valor + " = " + resultado);
                                cont++;
                        
                            }

                            Console.WriteLine($"\nGostaria de parar ??\n(s) Sim\n(n) Não\n");
                            responsive = Console.ReadLine();                           
                        }
                    else
                        {
                            Console.WriteLine($"\n{name} Nao entendi a sua resposta, acho que errou a Tecla\n Gostaria de parar agora? \n(s) Sim\n(n) Não\n");
                            responsive = Console.ReadLine();
                        }
            }

            while(responsive == "s" || responsive == "sNovo" && responsive != "null")
            {
                if (responsive != "sNovo") 
                {
                    Console.WriteLine($"\n\nAgora que tal uma brincadeirinha ? \n(s) Sim\n(n) Não\n");
                responsive = Console.ReadLine();
                }
                if (responsive != "n")
                {
                Console.WriteLine($"\n\nJá jogou Pedra, Papel e Tesoura ? Let's Go \n(P)Pedra \n(p)Papel \n(t)Tesoura \n\n");
                    
                string jokenPow = Console.ReadLine();

                int advNumber, jokenPowNumber;

                        Random adv = new Random();
                        advNumber = adv.Next(3);


                    if ( jokenPow == "P")
                    {
                        jokenPowNumber = 1;

                            if ( jokenPowNumber > advNumber )
                            {
                                Console.WriteLine($"\nVocê escolheu Pedra!! \nE eu coloquei Tesoura! =( \n\nParabens você ganhou!!");
                            }
                            
                            if ( jokenPowNumber == advNumber )
                            {
                                Console.WriteLine($"\nVocê escolheu Pedra!! \nE eu coloquei Pedra! =D \n\nEmpatamos!!");
                            }
                            
                            if ( jokenPowNumber < advNumber )
                            {
                                Console.WriteLine($"\nVocê escolheu Pedra!! \nE eu coloquei Papel ! ;) \n\nAcho que eu ganheeei!!");
                            }

                            Console.WriteLine($"\nGostaria de CONTINUAR ??\n(s) Sim\n(n) Não\n");
                            responsive = (Console.ReadLine()+"Novo");       
                            
                    }
                    if ( jokenPow == "p")
                    {
                        jokenPowNumber = 2;

                            if ( advNumber == 1 )
                            {
                                Console.WriteLine($"\nVocê escolheu Papel!! \nE eu coloquei Pedra! =( \n\nParabens você ganhou!!");
                            }
                            
                            if ( jokenPowNumber == advNumber )
                            {
                                Console.WriteLine($"\nVocê escolheu Papel!! \nE eu coloquei Papel! =D \n\nEmpatamos!!");
                            }
                            
                            if ( advNumber == 0)
                            {
                                Console.WriteLine($"\nVocê escolheu Papel!! \nE eu coloquei Tesoura ! ;) \n\nAcho que eu ganheeei!!");
                            }

                            Console.WriteLine($"\nGostaria de CONTINUAR ??\n(s) Sim\n(n) Não\n");
                            responsive = (Console.ReadLine()+"Novo");
                    }
                    if ( jokenPow == "t")
                    {
                        jokenPowNumber = 0;

                            if ( advNumber == 2)
                            {
                                Console.WriteLine($"\nVocê escolheu Tesoura!! \nE eu coloquei Papel! =( \n\nParabens você ganhou!!");
                            }
                            
                            if ( jokenPowNumber == advNumber )
                            {
                                Console.WriteLine($"\nVocê escolheu Tesoura!! \nE eu coloquei Tesoura! =D \n\nEmpatamos!!");
                            }
                            
                            if ( advNumber == 1)
                            {
                                Console.WriteLine($"\nVocê escoleu Tesoura!! \nE eu coloquei Pedra ! ;) \n\nAcho que eu ganheeei!!");
                            }
                            
                            Console.WriteLine($"\nGostaria de CONTINUAR ??\n(s) Sim\n(n) Não\n");
                            responsive = (Console.ReadLine()+"Novo");
                        }
                    }
            }


            Console.WriteLine($"\nMuito obrigado pelo tempo juntos, volte sempre!!\n");
                
        }
    }
}
