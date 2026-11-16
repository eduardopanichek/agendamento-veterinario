public class Program
{
    public static void Main(string[] args)
    {
        int validador = -1;
        int validador2 = -1;

        // chamada do menu para escolher qual tipo de acesso está ocorrendo
        switch (OpcaoCargo())
        {
            case 0:
                Console.WriteLine("Aplicativo finalizado!");
                break;
            case 1:
                do
                {
                    switch (MenuRecepcionista())
                    {
                        case 0:
                            validador = 0;
                            Console.WriteLine("Aplicativo finalizado!");
                            break;
                        case 1:
                            // criar método de cadastro de tutores
                            break;
                        case 2:
                            // criar método de cadastro de animais
                            break;
                        case 3:
                            // criar método de cadastro de veterinário
                            break;
                        case 4:
                            do
                            {
                                switch (MenuAgendamentosRecepcionista())
                                {
                                    case 0:
                                        validador2 = 0;
                                        Console.WriteLine("Retornando para o menu principal!");
                                        break;
                                    case 1:
                                        // criar método de agendamento de consultas
                                        break;
                                    case 2:
                                        // criar método de cancelamento de consultas
                                        break;
                                    case 3:
                                        // criar método de consulta das agendas do dia
                                        break;
                                }

                            } while (validador2 != 0);
                            break;
                    }
                } while (validador != 0);

                break;

            case 2:

                do
                {
                    switch (MenuVeterinario())
                    {
                        case 0:
                            validador = 0;
                            Console.WriteLine("Aplicativo finalizado!");
                            break;
                        case 1:
                            // criar método para mostrar a agenda do dia
                            break;
                        case 2:
                            // criar método para acessar a consulta atual e menu para fazer a observação
                            // e mudar a situação da consulta para realizada
                            break;
                    }
                } while (validador != 0);
                break;
        }
    }

    static int OpcaoCargo()
    {
        int opcao;

        do
        {
            Console.WriteLine("==== MENU DE AGENDAMENTOS ====");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("1 = Recepcionista");
            Console.WriteLine("2 = Veterinário");
            Console.WriteLine("Digite uma opção: ");

            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcao))
            {
                Console.WriteLine("Entrada inválida! Digite um número.");
                opcao = -1;
            }
            else if (opcao < 0 || opcao > 2)
            {
                Console.WriteLine("Opção inexistente! Tente novamente.");
            }

        } while (opcao < 0 || opcao > 2);

        return opcao;
    }
    static int MenuRecepcionista()
    {
        int opcao;

        do
        {
            Console.WriteLine("==== MENU RECEPCIONISTA ====");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("1 = Cadastrar Tutor");
            Console.WriteLine("2 = Cadastrar Animal");
            Console.WriteLine("3 = Cadastrar Veterinário");
            Console.WriteLine("4 = Menu de Agendamentos");
            Console.Write("Escolha uma opção: ");

            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcao))
            {
                Console.WriteLine("Entrada inválida! Digite um número.");
                opcao = -1;
            }
            else if (opcao < 0 || opcao > 4)
            {
                Console.WriteLine("Opção inexistente! Tente novamente.");
            }

        } while (opcao < 0 || opcao > 4);

        return opcao;
    }
    static int MenuAgendamentosRecepcionista()
    {
        int opcao;
        do
    {
        {
            Console.WriteLine("==== MENU DE AGENDAMENTOS ====");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("1 = Agendar consulta");
            Console.WriteLine("2 = Cancelar consulta");
            Console.WriteLine("3 = Consultar agendas");
            Console.WriteLine("Digite uma opção: ");

        string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcao))
            {
                Console.WriteLine("Entrada inválida! Digite um número.");
                opcao = -1;
            }
            else if (opcao < 0 || opcao > 3)

            Console.WriteLine("Opção inexistente! Tente novamente.");
        }
    } while (opcao < 0 || opcao > 3);
        
        return opcao;
    }

    static int MenuVeterinario()
    {
        int opcao;
        do
        {
            Console.WriteLine("==== MENU VETERINÁRIO ====");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("1 = Consultar agenda do dia");
            Console.WriteLine("2 = Acessar consulta atual");
            Console.WriteLine("Digite uma opção: ");

            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcao))
            {
                Console.WriteLine("Entrada inválida! Digite um número.");
                opcao = -1;
            }
            else if (opcao < 0 || opcao > 2)

                Console.WriteLine("Opção inexistente! Tente novamente.");
        } while (opcao < 0 || opcao > 2);

        return opcao;
    }
}
