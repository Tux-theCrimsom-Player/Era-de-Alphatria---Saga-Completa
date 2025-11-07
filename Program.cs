using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using static System.Threading.Thread;
namespace Era_de_Alphatria_versão_todos_os_capítulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menucap; // menu
            double vidap, staminap, manap, carismap, percepcaop, forcap, velocidadep, inteligenciap; // personagem
            bool afinidadep; // personagem
            do
            {
                WriteLine("\n< { _ - Era de Alphatria - _ } >");
                WriteLine("< { _ - Menu de Capítulos");
                WriteLine("0 - Sair / Créditos");
                WriteLine("\n1- Era de Alphatria, Revolução do Espelho");
                WriteLine("\n");
                Write("Escolha o capítulo desejado: ");
                menucap = ToInt32(ReadLine());
                switch (menucap)
                {
                    case 0:
                        {
                            WriteLine("Sessão Encerrada, obrigado por jogar!");
                            WriteLine("\n-__-_-{ < Créditos...");
                            WriteLine("Desenvolvedor: Tux The Crimson Player");
                            WriteLine("\nInspirações: Muitas coisas, não vai ser possível listar kkkkkkk");
                            WriteLine("\nMétodos de divulgação: Tik Tok e Facebook");
                            WriteLine("\nAgradecimentos: Agradeço a todos aqueles que me apoiaram e me acompanharam nessa jornada, sendo eles meus professores, meus amigos, e agradeço também a essa vida incrível que eu estou tendo pelo menos até agora que estou escrevendo esta linha kkkkkkk, brincadeirinhas a parte eu querendo ou não sou grato a minha vida por ter sido recheada de oportunidades...");
                            WriteLine("\nPalavrinha do dev: A sua vida, assim como ela é valiosa, ela é como se fosse uma história, onde nela aquele que decide o final cinemático é niguém mais ninguém menos que você, e como só se vive uma vez, não joga fora essa oportunidade de fazer uma história boa, principalmente se for por causa de alguém, afinal, essa história é sua...");
                        }
                        break;
                    case 1:
                        {
                            Clear();
                            WriteLine("Capítulo 1: Era de Alphatria, Revolução do Espelho");

                            WriteLine("Muito tempo atrás, antes mesmo do tempo ser algo conhecido por nós, ainda existente, só que não mais neste plano, havia uma deusa chamada Alphatra, elda criou tudo que conhecemos, acredite você ou não...");
                        }
                        break;
                }
            } while (menucap != 0);

            ReadKey();
        }
        public static int CombateD20()
        {
            double multiplicadorp = 0, multiplicadornpc = 0;
            int d20p, d20npc, d20c;
            Random dado = new Random();
            d20p = dado.Next(0, 21);
            d20npc = dado.Next(-1, 20);
            d20c = d20p - d20npc;
            switch (d20c)
            {
                case 1:
                    {
                        WriteLine("\n{System_Joselma}: Fracasso...");
                        multiplicadornpc = 2;
                        multiplicadorp = 0.1;
                    }
                    break;
                case 2:
                    {
                        WriteLine("\n{System_Joselma}: Fracasso...");
                        multiplicadornpc = 1.8;
                        multiplicadorp = 0.2;
                    }
                    break;
                case 3:
                    {
                        WriteLine("\n{System_Joselma}: Fracasso...");
                        multiplicadornpc = 1.7;
                        multiplicadorp = 0.3;
                    }
                    break;
                case 4:
                    {
                        WriteLine("\n{System_Joselma}: Ataque mediocre...");
                        multiplicadornpc = 1.5;
                        multiplicadorp = 0.5;
                    }
                    break;
                case 5:
                    {
                        WriteLine("\n{System_Joselma}: Ataque fraco...");
                        multiplicadornpc = 1;
                        multiplicadorp = 1;
                    }
                    break;
                case 6:
                    {
                        WriteLine("\n{System_Joselma}: Ataque simples.");
                        multiplicadornpc = 0.9;
                        multiplicadorp = 1.1;
                    }
                    break;
                case 7:
                    {
                        WriteLine("\n{System_Joselma}: Ataque simples.");
                        multiplicadornpc = 0.9;
                        multiplicadorp = 1.1;
                    }
                    break;
                case 8:
                    {
                        WriteLine("\n{System_Joselma}: Ataque composto.");
                        multiplicadornpc = 0.8;
                        multiplicadorp = 1.2;
                    }
                    break;
                case 9:
                    {
                        WriteLine("\n{System_Joselma}: Ataque composto.");
                        multiplicadornpc = 0.79;
                        multiplicadorp = 1.21;
                    }
                    break;
                case 10:
                    {
                        WriteLine("\n{System_Joselma}: Ataque elaborado.");
                        multiplicadornpc = 0.78;
                        multiplicadorp = 1.22;
                    }
                    break;
                case 11:
                    {
                        WriteLine("\n{System_Joselma}: Ataque elaborado.");
                        multiplicadornpc = 0.77;
                        multiplicadorp = 1.23;
                    }
                    break;
                case 12:
                    {
                        WriteLine("\n{System_Joselma}: Ataque elaborado.");
                        multiplicadornpc = 0.76;
                        multiplicadorp = 1.24;
                    }
                    break;
                case 13:
                    {
                        WriteLine("\n{System_Joselma}: Ataque elaborado.");
                        multiplicadornpc = 0.76;
                        multiplicadorp = 1.24;
                    }
                    break;
                case 14:
                    {
                        WriteLine("\n{System_Joselma}: Meta Atingida!");
                        multiplicadornpc = 0.75;
                        multiplicadorp = 1.25;
                    }
                    break;
                case 15:
                    {
                        WriteLine("\n{System_Joselma}: Meta Atingida!");
                        multiplicadornpc = 0.75;
                        multiplicadorp = 1.25;
                    }
                    break;
                case 16:
                    {
                        WriteLine("\n{System_Joselma}: Meta Atingida!");
                        multiplicadornpc = 0.75;
                        multiplicadorp = 1.25;
                    }
                    break;
                case 17:
                    {
                        WriteLine("\n{System_Joselma}: Ótimo!");
                        multiplicadornpc = 0.65;
                        multiplicadorp = 1.35;
                    }
                    break;
                case 18:
                    {
                        WriteLine("\n{System_Joselma}: Excelente!");
                        multiplicadornpc = 0.5;
                        multiplicadorp = 1.5;
                    }
                    break;
                case 19:
                    {
                        WriteLine("\n{System_Joselma}: Perfeito!");
                        multiplicadornpc = 0.25;
                        multiplicadorp = 1.75;
                    }
                    break;
                case 20:
                    {
                        WriteLine("\n{System_Joselma}: Supimpa!");
                        multiplicadornpc = 0.1;
                        multiplicadorp = 2;
                    }
                    break;
                default:
                    WriteLine("\n{System_Joselma}: ERRO");
                    break;
            }
            return d20c;
        }
        public static int Racismo()
        {
            int racap, quimeratype;
            double vidap, staminap, manap, carismap, percepcaop, forcap, velocidadep, inteligenciap;
            bool afinidadep, regeneracaovampiricap;
            WriteLine("\n< { _ - Menu de Personagem - _ } >");
            WriteLine("-Menu de raças...");
            Sleep(500);
            WriteLine("1- Humano");
            Sleep(500);
            WriteLine("\n2- Elfo");
            Sleep(500);
            WriteLine("\n3- Orc");
            Sleep(500);
            WriteLine("\n4- Goblin");
            Sleep(500);
            WriteLine("\n5- Quimera");
            Sleep(500);
            WriteLine("\n6- Híbrido Dracônico");
            Sleep(500);
            WriteLine("\n7- Fada");
            Sleep(500);
            WriteLine("\n8- Sereia / Tritão");
            Sleep(500);
            WriteLine("\n9- Vampiro");
            Sleep(500);
            WriteLine("\n10- Homem-Fera / Mulher-Fera");
            Write("Insira o número correspondente a raça desejada: ");
            racap = ToInt32(ReadLine());
            switch (racap)
            {
                case 1:
                    {
                        vidap = 1000;
                        staminap = 1000;
                        manap = 1000;
                        carismap = 1000;
                        percepcaop = 1000;
                        forcap = 1000;
                        velocidadep = 1000;
                        inteligenciap = 1000;
                        afinidadep = true;
                        regeneracaovampiricap = false;
                        WriteLine("\n< - VOCÊ ESCOLHEU HUMANO - >");
                        WriteLine("Seus status são relativamente comuns, não tendo uma vantagem, mas você tem o uso de afinidade, que permite seus ataques ficarem mais fortes com os 'buffs de equipamento'.");
                    }
                    break;
                case 2:
                    {
                        vidap = 1000;
                        staminap = 500;
                        manap = 1000;
                        carismap = 1000;
                        percepcaop = 1000;
                        forcap = 500;
                        velocidadep = 1000;
                        inteligenciap = 2000;
                        afinidadep = false;
                        regeneracaovampiricap = false;
                        WriteLine("\n< - VOCÊ ESCOLHEU ELFO - >");
                        WriteLine("Sua inteligência é a mais alta, porém você é um ser muito reservado e frágil comparado aos outros.");
                    }
                    break;
                case 3:
                    {
                        vidap = 1000;
                        staminap = 1000;
                        manap = 1000;
                        carismap = 1000;
                        percepcaop = 1000;
                        forcap = 2000;
                        velocidadep = 500;
                        inteligenciap = 500;
                        afinidadep = false;
                        regeneracaovampiricap = false;
                        WriteLine("\n< - VOCÊ ESCOLHEU ORC - >");
                        WriteLine("Você é forte, mas você tem os passos pesados e uma limitação de QI.");
                    }
                    break;
                case 4:
                    {
                        vidap = 750;
                        staminap = 1250;
                        manap = 250;
                        carismap = 250;
                        percepcaop = 250;
                        forcap = 250;
                        velocidadep = 1750;
                        inteligenciap = 250;
                        afinidadep = false;
                        regeneracaovampiricap = false;
                        WriteLine("\n< - VOCÊ ESCOLHEU GOBLIN - >");
                        WriteLine("Sua raça nos ramos comuns é considerada a mais asquerosa, porém pela sua alta stamina e velocidade, sua raça é considerada privilégio nos ramos mais obscuros, como o roubo.");
                    }
                    break;
                case 5:
                    {
                        Random tipagem = new Random();
                        quimeratype = tipagem.Next(0, 4);
                        switch (quimeratype)
                        {
                            case 1:
                                {
                                    vidap = 1000;
                                    staminap = 1000;
                                    manap = 1000;
                                    carismap = 10;
                                    percepcaop = 2000;
                                    forcap = 1000;
                                    velocidadep = 1000;
                                    inteligenciap = 2000;
                                    afinidadep = false;
                                    regeneracaovampiricap = false;
                                    WriteLine("\n< - VOCÊ ESCOLHEU QUIMERA, SEUS GENES SÃO O DA RAZÃO - >");
                                    WriteLine("Os seus genes são a variação que surgiu dos genes dos elfos, carisma não lhe importa, força não lhe importa, o que lhe importa é ser racional...");
                                }
                                break;
                            case 2: {
                                    vidap = 1000;
                                    staminap = 1000;
                                    manap = 1000;
                                    carismap = 1000;
                                    percepcaop = 100;
                                    forcap = 2000;
                                    velocidadep = 2000;
                                    inteligenciap = 100;
                                    afinidadep = false;
                                    regeneracaovampiricap = false;
                                    WriteLine("\n< - VOCÊ ESCOLHEU QUIMERA, SEUS GENES SÃO O DA AGRESSÃO - >");
                                    WriteLine("Os seus genes são a variação que surgiu dos genes dos orcs, você vive para protejer os fracos...");
                            }
                            break;
                            case 3: {
                                    vidap = 500;
                                    staminap = 500;
                                    manap = 500;
                                    carismap = 500;
                                    percepcaop = 500;
                                    forcap = 500;
                                    velocidadep = 500;
                                    inteligenciap = 500;
                                    afinidadep = true;
                                    regeneracaovampiricap = true;
                                    WriteLine("\n< - VOCÊ ESCOLHEU QUIMERA, SEUS GENES SÃO O DO DOPPELGÄNGER - >");
                                    WriteLine("Seus genes, são vindos da raça humana, mas... Por acaso isso importa? Você não lembra como nasceu, quem eram seus pais, se já morreu, não importa mais, mas nada mais lhe importa, desde que aquele acidente entre o divíno e o mortal ocorreu, seu único motivo de vida é imitar, ser um reflexo feito de carne, ossos, alma e entranhas. Movido a vitalidade daqueles em sua volta, agora, tu és simplesmente um ser emocionalmente vazio, como uma casca oca de uma árvore...");
                            }
                            break;
                        }
                    }
                    break;
                    case 6: {
                                    vidap = 2000;
                                    staminap = 2000;
                                    manap = 2000;
                                    carismap = 1000;
                                    percepcaop = 2;
                                    forcap = 2000;
                                    velocidadep = 2000;
                                    inteligenciap = 1;
                                    afinidadep = false;
                                    regeneracaovampiricap = false;
                                    WriteLine("\n< - VOCÊ ESCOLHEU HÍBRIDO DRACÔNICO - >");
                                    WriteLine("Forte e capaz, porém tolo e ingênuo.");
                    }
                    break;
                    case 7: {
                                    vidap = 750;
                                    staminap = 250;
                                    manap = 1250;
                                    carismap = 1750;
                                    percepcaop = 250;
                                    forcap = 250;
                                    velocidadep = 250;
                                    inteligenciap = 250;
                                    afinidadep = false;
                                    regeneracaovampiricap = false;
                                    WriteLine("\n< - VOCÊ ESCOLHEU FADA - >");
                                    WriteLine("Apesar de ser biologicamente frágil, sua gentileza é o que lhe faz forte.");
                    }
                    break;
                    case 8: {
                        vidap = 2000;
                                    staminap = 1000;
                                    manap = 1000;
                                    carismap = 1000;
                                    percepcaop = 1000;
                                    forcap = 900;
                                    velocidadep = 1100;
                                    inteligenciap = 1000;
                                    afinidadep = false;
                                    regeneracaovampiricap = false;
                                    WriteLine("\n< - VOCÊ ESCOLHEU SEREIA / TRITÃO - >");
                                    WriteLine("Você.");
                    }
            }
            return racap;
        }
    }
}