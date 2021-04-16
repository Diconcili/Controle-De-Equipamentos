using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Equipamentos___Procedural
{
    class Program
    {
        static void Main(string[] args)
        {
            int limiteRegistros = 100;
            int numeroCódigo = 0;
            int contadorEquipamentos = 0;

            int limiteChamados = 100;
            int contadorChamados = 0;            

            int[] códigoEquipamento = new int[limiteRegistros];
            string[] nomeEquipamento = new string[limiteRegistros];
            double[] preçoAquisiçãoEquipamento = new double[limiteRegistros];
            string[] numeroDeSérie = new string[limiteRegistros];
            DateTime[] dataFabricação = new DateTime[limiteRegistros];
            string[] fabricanteEquipamento = new string[limiteRegistros];

            string[] tituloChamado = new string[limiteChamados];
            string[] descriçãoChamado = new string[limiteChamados];
            string[] equipamentoDoChamado = new string[limiteChamados];
            DateTime[] dataAberturaChamado = new DateTime[limiteChamados];
            


            while (true)
            {
                Console.WriteLine("Controle de Equipamentos");
                Console.WriteLine("------------------------");
                Console.WriteLine("Opção 1 - Menu de equipamentos");
                Console.WriteLine("Opção 2 - Menu de chamados");
                Console.WriteLine("Opção 3 - Sair do aplicativo");
                int opçãoMenu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                

                if (opçãoMenu == 3)
                {
                    break;
                }

                switch (opçãoMenu)
                {
                    case 1:
                        Console.WriteLine("Menu de equipamentos");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Opção 1 - Adicionar equipamento");
                        Console.WriteLine("Opção 2 - Editar equipamento");
                        Console.WriteLine("Opção 3 - Apagar equipamento");
                        Console.WriteLine("Opção 4 - Visualizar equipamentos registrados");
                        int opçãoEquipamentos = Convert.ToInt32(Console.ReadLine());
                        switch (opçãoEquipamentos)
                        {
                            case 1:
                                RegistroEquipamento(contadorEquipamentos, códigoEquipamento, numeroCódigo, nomeEquipamento, preçoAquisiçãoEquipamento, numeroDeSérie, dataFabricação, fabricanteEquipamento);
                                contadorEquipamentos++;
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 2:
                                EditarEquipamentos(contadorEquipamentos, códigoEquipamento, nomeEquipamento, preçoAquisiçãoEquipamento, numeroDeSérie, dataFabricação, fabricanteEquipamento);
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 3:
                                ExcluirEquipamentos(limiteRegistros, contadorEquipamentos, códigoEquipamento, nomeEquipamento, preçoAquisiçãoEquipamento, numeroDeSérie, dataFabricação, fabricanteEquipamento);
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 4:
                                VisualizaçãoDeEquipamentos(limiteRegistros, códigoEquipamento, nomeEquipamento, preçoAquisiçãoEquipamento, numeroDeSérie, dataFabricação, fabricanteEquipamento);
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            default:
                                Console.WriteLine("Comando inválido");
                                continue;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Menu de chamados");
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("Opção 1 - Adicionar chamado");
                        Console.WriteLine("Opção 2 - Editar chamado");
                        Console.WriteLine("Opção 3 - Excluir chamado");
                        Console.WriteLine("Opção 4 - Visualizar chamados registrados");
                        int opçãoChamados = Convert.ToInt32(Console.ReadLine());
                        switch (opçãoChamados)
                        {
                            case 1:
                                RegistroChamado(contadorChamados, tituloChamado, descriçãoChamado, equipamentoDoChamado, dataAberturaChamado);
                                contadorChamados++;
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 2:
                                EditarChamado(contadorChamados, tituloChamado, descriçãoChamado, equipamentoDoChamado, dataAberturaChamado);
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 3:
                                ExcluirChamado(limiteChamados,contadorChamados, tituloChamado, descriçãoChamado, equipamentoDoChamado, dataAberturaChamado);
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 4:
                                VisualizaçãoDeChamados(limiteChamados, contadorChamados, tituloChamado, equipamentoDoChamado, dataAberturaChamado);                                
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            default:
                                Console.WriteLine("Comando inválido");
                                Console.Clear();
                                continue;
                        }
                        break;



                    default:
                        Console.WriteLine("Comando inválido");
                        continue;
                }
            }
        }




        public static void RegistroEquipamento(int contadorEquipamentos, int[] códigoEquipamento, int numeroCódigo, string[] nomeEquipamento, double[] preçoAquisiçãoEquipamento,
            string[] numeroDeSérie, DateTime[] dataFabricação, string[] fabricanteEquipamento)
        {
            string nomeRegistrado; bool validaNome = false;

            do
            {
                Console.WriteLine("Digite o nome do equipamento: ");
                nomeRegistrado = Console.ReadLine();
                if (nomeRegistrado.Length < 6)
                {
                    validaNome = true;
                    Console.WriteLine("Nome inválido, deve ter pelo menos 6 caracteres");
                    Console.ReadLine();
                    continue;
                }
            } while (validaNome);

            Console.WriteLine("Digite o preço de aquisição: ");
            double preçoAquisição = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o número de série do equipamento: ");
            string numeroSérie = Console.ReadLine();

            Console.WriteLine("Digite a data de fabricação do equipamento: ");
            DateTime dataDeFabricação = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Digite o fabricante do equipamento: ");
            string fabricante = Console.ReadLine();


            códigoEquipamento[contadorEquipamentos] = numeroCódigo++;

            nomeEquipamento[contadorEquipamentos] = nomeRegistrado;
            preçoAquisiçãoEquipamento[contadorEquipamentos] = preçoAquisição;
            numeroDeSérie[contadorEquipamentos] = numeroSérie;
            dataFabricação[contadorEquipamentos] = dataDeFabricação;
            fabricanteEquipamento[contadorEquipamentos] = fabricante;            
            
        }

        public static void VisualizaçãoDeEquipamentos(int contadorEquipamentos, int[] códigoEquipamento, string[] nomeEquipamento, double[] preçoAquisiçãoEquipamento,
           string[] numeroDeSérie, DateTime[] dataFabricação, string[] fabricanteEquipamento)
        {

            Console.WriteLine(contadorEquipamentos);
            for (int i = 0; i < contadorEquipamentos; i++)
            {
                if (nomeEquipamento[i] == null && códigoEquipamento[i] == 0)
                {
                    Console.WriteLine("Nenhum equipamento registrado ainda");
                    break;
                }

                Console.WriteLine($"Código do equipamento: {códigoEquipamento[i]}, Equipamento: {nomeEquipamento[i]}, Preço: {preçoAquisiçãoEquipamento[i]}, " +
                    $"Fabricante: {fabricanteEquipamento[i]}, Número de série: {numeroDeSérie[i]} , data de fabricação: {dataFabricação[i]}");
            }

        }

        public static void EditarEquipamentos(int contadorEquipamentos, int[] códigoEquipamento, string[] nomeEquipamento, double[] preçoAquisiçãoEquipamento,
            string[] numeroDeSérie, DateTime[] dataFabricação, string[] fabricanteEquipamento)
        {

            for (int i = 0; i < contadorEquipamentos; i++)
            {
                if (nomeEquipamento[i] != null)
                {
                    Console.WriteLine("Código do equipamento: " + códigoEquipamento[i]);
                    Console.WriteLine("Nome do equipamento: " + nomeEquipamento[i]);
                    Console.WriteLine("Preço do equipamento: " + preçoAquisiçãoEquipamento[i]);
                    Console.WriteLine("Número de série: " + numeroDeSérie[i]);
                    Console.WriteLine("Fabricante: " + fabricanteEquipamento[i]);
                    Console.WriteLine("Data de fabricação: " + dataFabricação[i]);
                    Console.WriteLine(" ");
                }
            }

            Console.WriteLine("Digite o código do equipamento a ser editado: ");
            int verificaCódigo = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("EDIÇÃO DE EQUIPAMENTO");
            Console.WriteLine("---------------------");
            Console.WriteLine("Insira o nome do equipamento: ");
            string nomeParaEditar = Console.ReadLine();

            Console.WriteLine("Insira o preço do equipamento: ");
            double preçoParaEditar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o número de série do equipamento: ");
            string numeroParaEditar = Console.ReadLine();

            Console.WriteLine("Insira a data de fabricação do equipamento: ");
            string dataParaEditar = Console.ReadLine();

            Console.WriteLine("Insira o fabricante do equipamento: ");
            string fabricanteParaEditar = Console.ReadLine();

            for (int i = 0; i < contadorEquipamentos; i++)
            {
                if (nomeEquipamento[i] != null)
                {
                    if (códigoEquipamento[i] == verificaCódigo)
                    {
                        nomeEquipamento.SetValue(nomeParaEditar, i);
                        preçoAquisiçãoEquipamento.SetValue(preçoParaEditar, i);
                        numeroDeSérie.SetValue(numeroParaEditar, i);
                        dataFabricação.SetValue(dataParaEditar, i);
                        fabricanteEquipamento.SetValue(fabricanteParaEditar, i);

                    }
                }
            }

            Console.ReadLine();
        }

        public static void ExcluirEquipamentos(int limiteRegistros, int contadorEquipamentos, int[] códigoEquipamento, string[] nomeEquipamento, double[] preçoAquisiçãoEquipamento,
            string[] numeroDeSérie, DateTime[] dataFabricação, string[] fabricanteEquipamento)
        {

            VisualizaçãoDeEquipamentos(limiteRegistros, códigoEquipamento, nomeEquipamento, preçoAquisiçãoEquipamento, numeroDeSérie, dataFabricação, fabricanteEquipamento);

            Console.WriteLine("Digite o código do equipamento a ser excluído: ");
            int verificaCódigo = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < contadorEquipamentos; i++)
            {
                if (nomeEquipamento[i] != null && códigoEquipamento[i] == verificaCódigo)
                {
                    códigoEquipamento[i] = 0;
                    nomeEquipamento[i] = null;
                    preçoAquisiçãoEquipamento[i] = 0;
                    numeroDeSérie[i] = null;
                    dataFabricação[i] = DateTime.MinValue;
                    fabricanteEquipamento[i] = null;
                }
            }


        }

        public static void RegistroChamado(int contadorChamados, string[] tituloChamado, string[] descriçãoChamado, string[] equipamentoDoChamado,
            DateTime[] dataAberturaChamado)
        {
            Console.WriteLine("Digite o título do chamado");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite a descrição do chamado");
            string descrição = Console.ReadLine();

            Console.WriteLine("Digite o equipamento em manutenção");
            string equipamento = Console.ReadLine();

            Console.WriteLine("Digite a data de abertura do chamado");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            tituloChamado[contadorChamados] = titulo;
            descriçãoChamado[contadorChamados] = descrição;
            equipamentoDoChamado[contadorChamados] = equipamento;
            dataAberturaChamado[contadorChamados] = data;            
        }

        public static void EditarChamado(int contadorChamados, string[] tituloChamado, string[] descriçãoChamado, string[] equipamentoDoChamado,
            DateTime[] dataAberturaChamado)
        {
            DateTime hoje = DateTime.Now;

            for (int i = 0; i < contadorChamados; i++)
            {
                TimeSpan dias = hoje.Subtract(dataAberturaChamado[i]);
                int intDias = Convert.ToInt32(dias.TotalDays);

                if (tituloChamado[i] != null)
                {
                    Console.WriteLine("Titulo do chamado: " + tituloChamado[i]);
                    Console.WriteLine("Nome do equipamento: " + equipamentoDoChamado[i]);
                    Console.WriteLine("Data de abertura do chamado: " + dataAberturaChamado[i]);
                    Console.WriteLine("Número de dias que o chamdo está aberto: " + intDias); 
                    Console.WriteLine(" ");
                }
            }

            Console.WriteLine("Digite o título do equipamento a ser editado: ");
            string verificaTitulo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("EDIÇÃO DE CHAMADO");
            Console.WriteLine("---------------------");
            Console.WriteLine("Insira o nome do equipamento: ");
            string tituloParaEditar = Console.ReadLine();

            Console.WriteLine("Insira o nome do equipamento: ");
            string equipamentoParaEditar = Console.ReadLine();

            Console.WriteLine("Insira a data de abertura do chamado: ");
            DateTime dataAberturaParaEditar = Convert.ToDateTime(Console.ReadLine());



            for (int i = 0; i < contadorChamados; i++)
            {
                if (tituloChamado[i] != null)
                {
                    if (tituloChamado[i] == verificaTitulo)
                    {
                        tituloChamado[i] = tituloParaEditar;
                        equipamentoDoChamado[i] = equipamentoParaEditar;
                        dataAberturaChamado[i] = dataAberturaParaEditar;
                        //novo número de dias que está aberto
                    }
                }
            }

            Console.ReadLine();
        }

        public static void ExcluirChamado(int limiteChamados,int contadorChamados, string[] tituloChamado, string[] descriçãoChamado, string[] equipamentoDoChamado,
            DateTime[] dataAberturaChamado)
        {

            VisualizaçãoDeChamados(limiteChamados, contadorChamados, tituloChamado, equipamentoDoChamado, dataAberturaChamado);

            Console.WriteLine("Digite o título do chamado a ser excluído: ");
            string verificaTitulo = Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < contadorChamados; i++)
            {
                if (tituloChamado[i] != null && tituloChamado[i] == verificaTitulo)
                {
                    tituloChamado[i] = null;
                    equipamentoDoChamado[i] = null;
                    dataAberturaChamado[i] = DateTime.MinValue;
                }

            }

        }

        public static void VisualizaçãoDeChamados( int limiteChamados,int contadorChamados, string[] tituloChamado, string[] equipamentoDoChamado,
            DateTime[] dataAberturaChamado){

            DateTime hoje = DateTime.Now;

            for (int i = 0; i < limiteChamados; i++)
            {
                if(tituloChamado[i] != null && equipamentoDoChamado[i] != null && dataAberturaChamado != null)
                {
                    TimeSpan dias = hoje.Subtract(dataAberturaChamado[i]);
                    int intDias = Convert.ToInt32(dias.TotalDays);

                    if (contadorChamados == 0)
                    {
                        Console.WriteLine("Nenhum chamado registrado ainda");
                        Console.ReadLine();
                    }

                    Console.WriteLine($"Título do chamado: {tituloChamado[i]}, equipamento: {equipamentoDoChamado[i]}, data de abertura: {dataAberturaChamado[i]}" +
                        $"dias que o chamado está aberto: {intDias - 1}");
                }
                
            } 
        }
    }
} 