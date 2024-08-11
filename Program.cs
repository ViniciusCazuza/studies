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
            string name = "Vinicius", sobrenome = "Cazuza", responsive = "null";
            bool sair = false;
            int imparPar = 0;
            int result = 0;
            string[] id = {};
            id = new string[10];
            id = new string[] {name + " " + sobrenome};
            

            Console.WriteLine($"Olá por gentileza digite seu Primeiro Nome: \n");
            name = Console.ReadLine();
            Console.WriteLine($"Agora digite seu Segundo Nome: \n");
            sobrenome = Console.ReadLine();



            while (sair == false)
                {
                    if (id [0] != "Vinicius Cazuza")
                    {
                        Console.WriteLine($"\nNome registrado com sucesso!\n\n {id} Seja Bem-Vindo(a) ao nosso Sistema!");
                        sair = true;
                    }
                        else 
                        {
                            Console.WriteLine($"\nVerificamos que já existe esse nome em nosso Banco de Dados! \n\n Deseja inserir outro username ? \n(s) Sim \n(n) Não\n");
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
                    if (sair == true && responsive != "n")
                        {
                        Console.WriteLine($"\n {id}, seu cadastro foi feito, parabens!\n");
                         responsive = "!";
                        }
                            else 
                            {
                            Console.WriteLine($"\nOk, o seu cadastro termina aqui! Bye Bye!!");
                            }
                            
        while (responsive == "s" || responsive == "!")
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
                
        }
    }
}