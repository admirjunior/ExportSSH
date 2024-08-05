using System;
using System.IO;
using Renci.SshNet;

namespace ExportSSH
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário o IP do servidor e armazena na variável 'serverIp'
            Console.WriteLine("Informe o IP do servidor: ");
            var serverIp = Console.ReadLine();

            // Solicita ao usuário a porta do servidor e converte para um inteiro
            Console.WriteLine("Informe a porta do servidor: ");
            var serverPort = Convert.ToInt32(Console.ReadLine());

            // Solicita ao usuário o nome de usuário para autenticação SSH
            Console.WriteLine("Informe o nome de usuário: ");
            var username = Console.ReadLine();

            // Solicita ao usuário a senha para autenticação SSH
            Console.WriteLine("Informe a senha: ");
            var password = Console.ReadLine();

            // Cria um cliente SSH usando as credenciais fornecidas
            using (var client = new SshClient(serverIp, serverPort, username, password))
            {
                // Conecta ao servidor remoto via SSH
                client.Connect();

                // Executa o comando no servidor para obter o conteúdo do arquivo database_config.xml
                var databaseConfig = client.RunCommand("cat /usr/local/se/conf/database_config.xml");
                // Exibe o conteúdo do arquivo database_config.xml no console
                Console.WriteLine("Conteúdo do arquivo database_config.xml: " + databaseConfig.Result);
                // Salva o conteúdo do arquivo database_config.xml em um arquivo local no diretório de downloads do usuário
                File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "database_config.txt"), databaseConfig.Result);

                // Executa o comando no servidor para obter o conteúdo do arquivo tnsnames.ora
                var tnsOra = client.RunCommand("cat /usr/local/se/conf/tnsnames.ora");
                // Exibe o conteúdo do arquivo tnsnames.ora no console
                Console.WriteLine("Conteúdo do arquivo tnsnames.ora: " + tnsOra.Result);
                // Salva o conteúdo do arquivo tnsnames.ora em um arquivo local no diretório de downloads do usuário
                File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "tnsnames.txt"), tnsOra.Result);

                // Desconecta do servidor SSH após completar as operações
                client.Disconnect();
            }

            // Informa ao usuário que o download dos arquivos foi concluído
            Console.WriteLine("Download concluído.");
        }
    }
}
