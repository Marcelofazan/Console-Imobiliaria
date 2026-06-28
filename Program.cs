using System;
using System.Globalization;

namespace Imobiliaria
{
    class Program
    {
        static string fone(int iddd, string itelefone)
        {
            return "015" + iddd + itelefone; 
        }
        static void props(proprietario AliasProp)
        {
             Console.WriteLine("\n" + "Proprietarios Cadastrado com Sucesso *_______________________________________________________________________________*" + "\n" +
                                     "Nome Proprietário: " + AliasProp.nome + " RG: " + AliasProp.rg + " CPF: " + AliasProp.cpf + "\n" +
                                     "Telefone: " + fone(AliasProp.contproprietario.ddd, AliasProp.contproprietario.telefone) + "\n");
        }
        static double calcularepasse(double nvaloraluguel, double nvalorcondominio, double nvalorimobiliaria, int nqt)
        {
            double ntotaluguel, nimoboliaria, nliquido, nrepasse;
            ntotaluguel = nvaloraluguel + nvalorcondominio;
            nimoboliaria = ntotaluguel * nvalorimobiliaria / 100;
            nliquido = ntotaluguel - nimoboliaria;
            nrepasse = nliquido / nqt;
            return nrepasse;
        }
        struct locacao
        {
            public int modalidadelocacao;
            public double valoraluguel;
            public int numeromeses;
            public double valorentrada;
            public double valorcondominio;
            public double comissaoimobiliaria;
        }
        struct endereco
        {
            public string rua;
            public int numero;
            public string bairro;
            public string cidade;
            public string estado;
            public string cep;
            public int apto;
        }
        struct contatos
        {
            public int ddd;
            public string telefone;
        }
        struct proprietario
        {
            public string nome;
            public string rg;
            public string cpf;
            public contatos contproprietario;
        }
        struct inquilino
        {
            public string nome;
            public string rg;
            public string cpf;
            public contatos continquilino;
        }
        struct imovel
        {
            public string tipoimovel;
            public int terreno;
            public int areaconstruida;
            public int garagem;
            public int numeroquartos;
            public int numerobanheiro;
            public endereco imoendereco;
        }
        static void Main(string[] args)
        {
            string NovoContrato;
            int qt, i;

            Console.WriteLine("EMISSAO DE CONTRATO DE LOCAÇÃO");
            Console.WriteLine("Deseja Criar novo CONTRATO DE LOCACAO S-SIM ou N-NÃO");
            NovoContrato = Console.ReadLine().ToUpper();
            if (NovoContrato != "S")
            {
                Console.WriteLine("Cancelada a locação");
            }
            else
            {
                inquilino inq = new inquilino();

                Console.WriteLine("Escreva o Nome do Inquilino:");
                inq.nome = Console.ReadLine().ToUpper();
                Console.WriteLine("Digite o numero do R.G.:");
                inq.rg = Console.ReadLine().ToUpper();
                Console.WriteLine("Escreva o CPF:");
                inq.cpf = Console.ReadLine().ToUpper();
                Console.WriteLine("Informe o Numero do DDD do Telefone:");
                inq.continquilino.ddd = short.TryParse(Console.ReadLine(), out short ddd) ? ddd : (short)0;
                Console.WriteLine("Informe o Numero do Telefone:");
                inq.continquilino.telefone = Console.ReadLine().ToUpper();
                Console.WriteLine("\n" + "Inquilino Cadastrado com Sucesso *_______________________________________________________________________________*" + "\n" +
                                  "Nome Inquilino: " + inq.nome + " RG: " + inq.rg + " CPF: " + inq.cpf + "\n" +
                                  "Telefone: " + fone(inq.continquilino.ddd, inq.continquilino.telefone) + "\n");

                imovel imo = new imovel();

                Console.WriteLine("Tipo do Imovel Digite Casa |Apartamento ");
                imo.tipoimovel = Console.ReadLine().ToUpper();
                Console.WriteLine("Escreva a Rua do Imóvel:");
                imo.imoendereco.rua = Console.ReadLine().ToUpper();
                Console.WriteLine("Escreva o numero do Imóvel:");
                imo.imoendereco.numero = short.TryParse(Console.ReadLine(), out short numero) ? numero : (short)0;
                Console.WriteLine("Escreva o Bairro:");
                imo.imoendereco.bairro = Console.ReadLine().ToUpper();
                Console.WriteLine("Escreva a Cidade:");
                imo.imoendereco.cidade = Console.ReadLine().ToUpper();
                Console.WriteLine("Escreva o Estado:");
                imo.imoendereco.estado = Console.ReadLine().ToUpper();
                Console.WriteLine("Escreva o numero do CEP:");
                imo.imoendereco.cep = Console.ReadLine().ToUpper();
                Console.WriteLine("Escreva a area do Terreno em m2:");
                imo.terreno = short.TryParse(Console.ReadLine(), out short terreno) ? terreno : (short)0;
                Console.WriteLine("Escreva a area construida em m2:");
                imo.areaconstruida = short.TryParse(Console.ReadLine(), out short areaconstruida) ? areaconstruida : (short)0;
                Console.WriteLine("Escreva qual o numero de quartos:");
                imo.numeroquartos = short.TryParse(Console.ReadLine(), out short numeroquartos) ? numeroquartos : (short)0;
                Console.WriteLine("Escreva qual o numero de banheiros:");
                imo.numerobanheiro = short.TryParse(Console.ReadLine(), out short numerobanheiro) ? numerobanheiro : (short)0;
                Console.WriteLine("Escreva o numero de vagas na garagem:");
                imo.garagem = short.TryParse(Console.ReadLine(), out short garagem) ? garagem : (short)0;
                if (imo.tipoimovel == "Apartamento" || imo.tipoimovel == "apartamento")
                {
                    Console.WriteLine("Escreva o numero do Apto:");
                    imo.imoendereco.apto = short.TryParse(Console.ReadLine(), out short apto) ? apto : (short)0;
                }
                Console.WriteLine("\n" + "Imovel Cadastrado com Sucesso *_______________________________________________________________________________*" + "\n" +
                                  "Tipo do Imovel: " + imo.tipoimovel + " Terreno em m2: " + imo.terreno + " Area construida em m2: " + imo.areaconstruida + "\n" +
                                  "Rua: " + imo.imoendereco.rua + " Numero: " + imo.imoendereco.numero + " Bairro: " + imo.imoendereco.numero + " Cidade: " + imo.imoendereco.cidade + " Estado: " + imo.imoendereco.estado + " CEP: " + imo.imoendereco.cep + "\n" +
                                  "Numero de quartos: " + imo.numeroquartos + " Numero de banheiros: " + imo.numerobanheiro + " Quantidade de vagas na garagem: " + imo.garagem + (imo.imoendereco.apto != 0 ? " Apto: " + imo.imoendereco.apto:"") + "\n");

                Console.WriteLine("Digite o numero de proprietários no máximo 3 :");

                qt = int.TryParse(Console.ReadLine(), out int resultado) ? resultado : 1;
                proprietario[] pro = new proprietario[qt];
                if (qt > 3)
                {
                    Console.WriteLine("Cancelada a locação");
                }
                else
                {
                    for (i = 0; i < qt; i++)
                    {
                        Console.WriteLine("Escreva o Nome do Proprietário:");
                        pro[i].nome = Console.ReadLine().ToUpper();
                        Console.WriteLine("Digite o numero do R.G.:");
                        pro[i].rg = Console.ReadLine().ToUpper();
                        Console.WriteLine("Escreva o CPF:");
                        pro[i].cpf = Console.ReadLine().ToUpper();
                        Console.WriteLine("Informe o Numero do DDD do Telefone:");
                        pro[i].contproprietario.ddd = short.TryParse(Console.ReadLine(), out short inputDdd) ? inputDdd : (short)0;
                        Console.WriteLine("Informe o Numero do Telefone:");
                        pro[i].contproprietario.telefone = Console.ReadLine().ToUpper();
                    }
                    for (i = 0; i < qt; i++)
                    {
                        props(pro[i]);
                    }

                    locacao loc = new locacao();
                    int nParcela;

                    Console.WriteLine("Digite o código da modalidade: 1 - FIADOR | 2 - CAUÇÃO");
                    loc.modalidadelocacao = (int.TryParse(Console.ReadLine(), out int valor) && (valor == 1 || valor == 2)) ? valor : 0;
                    Console.WriteLine("Digite o valor do Aluguel:");
                    string dvaloraluguel = Console.ReadLine();
                    if (double.TryParse(dvaloraluguel, NumberStyles.Any, CultureInfo.CurrentCulture, out double dvaloraluguelConvertido))
                    {
                        loc.valoraluguel = dvaloraluguelConvertido;
                    }
                    else
                    {
                        loc.valoraluguel = 0;
                    }

                    Console.WriteLine("Numero de meses do contrato:");
                    loc.numeromeses = short.TryParse(Console.ReadLine(), out short numeromeses) ? numeromeses : (short)0;
                    if (loc.modalidadelocacao == 2)
                    {
                        Console.WriteLine("Valor Entrada Caução:");
                        loc.valorentrada = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine("Digite o valor do Condominio:");
                    string dvalorcondominio = Console.ReadLine();
                    if (double.TryParse(dvalorcondominio, NumberStyles.Any, CultureInfo.CurrentCulture, out double dvalorcondominioConvertido))
                    {
                        loc.valorcondominio = dvalorcondominioConvertido;
                    }
                    else
                    {
                        loc.valorcondominio = 0;
                    }

                    Console.WriteLine("Digite o numero Percentual de Comissão da Imobiliária:");
                    string dcomissaoimobiliaria = Console.ReadLine();
                    if (double.TryParse(dcomissaoimobiliaria, NumberStyles.Any, CultureInfo.CurrentCulture, out double dcomissaoimobiliariaConvertido))
                    {
                        loc.comissaoimobiliaria = dcomissaoimobiliariaConvertido;
                    }
                    else
                    {
                        loc.comissaoimobiliaria = 0;
                    }

                    Console.WriteLine("\n" + "Contrato de Locação *_______________________________________________________________________________*" + "\n");

                    string[] vetprop = new string[loc.numeromeses];
                    string[] vetprop1 = new string[loc.numeromeses];
                    string[] vetprop2 = new string[loc.numeromeses];
                    string[] vetprop3 = new string[loc.numeromeses];

                    for (i = 0; i < loc.numeromeses; i++)
                    {
                        nParcela = i + 1;
                        double ntotaluguel;
                        ntotaluguel = loc.valoraluguel + loc.valorcondominio;
                        Console.WriteLine("[Parcela]: " + nParcela + " [Aluguel Valor] R$: " + ntotaluguel);
                        vetprop[i] = "[Parcela] : " + nParcela + " [Repasse Valor] R$: " + calcularepasse(loc.valoraluguel, loc.valorcondominio, loc.comissaoimobiliaria, qt);
                    }
                    if (loc.modalidadelocacao == 3)
                    {
                        Console.WriteLine("Valor Entrada com Caução: " + loc.valorentrada);
                    }
                    Console.WriteLine("\n" + "Repasse Liquido aos Proprietários *_______________________________________________________________________________*" + "\n");
                    if (qt >= 1 )
                    {
                        for (i = 0; i < loc.numeromeses; i++)
                        {
                            vetprop1[i] = vetprop[i];
                            Console.WriteLine("[Proprietário] " + pro[0].nome + " [Valor] R$: " + vetprop1[i]);
                        }
                    }
                    if (qt >= 2)
                    {
                        for (i = 0; i < loc.numeromeses; i++)
                        {
                            vetprop2[i] = vetprop[i];
                            Console.WriteLine("[Proprietário] " + pro[1].nome + " [Valor] R$: " + vetprop2[i]);
                        }
                    }
                    if (qt == 3)
                    {
                        for (i = 0; i < loc.numeromeses; i++)
                        {
                            vetprop3[i] = vetprop[i];
                            Console.WriteLine("[Proprietário]" + pro[2].nome + " R$: " + vetprop3[i]);
                        }
                    }

                    Console.WriteLine("\n" + "Comissão Imobiliaria a Receber *_______________________________________________________________________________*" + "\n");
                    for (i = 0; i < loc.numeromeses; i++)
                    {
                        nParcela = i + 1;
                        Console.WriteLine("[Comissão Parcela]: " + nParcela + " [Valor] R$: " + (loc.valoraluguel + loc.valorcondominio) * loc.comissaoimobiliaria / 100);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
