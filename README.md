<h1 align="center">ExportSSH</h1>

<p align="center">🚀 <strong>ExportSSH</strong> é uma ferramenta de linha de comando em C# que facilita a extração e download de arquivos de configuração de banco de dados <code>database_config.xml</code> e <code>tnsnames.ora</code> de servidores remotos utilizando o protocolo SSH. Ideal para ambientes dinâmicos, onde diferentes servidores podem ter configurações distintas, permitindo que administradores de sistemas e desenvolvedores obtenham essas configurações de maneira eficiente e segura.</p>

---

## 🔧 Funcionalidades

- **Conexão SSH:** Conecta-se a servidores remotos utilizando as credenciais fornecidas pelo usuário.
- **Extração de Arquivos:** Obtém os arquivos de configuração `database_config.xml` e `tnsnames.ora` do servidor remoto.
- **Download Automático:** Salva os arquivos extraídos localmente no diretório `Downloads` do usuário.
- **Interface Simples:** Interface de linha de comando intuitiva e fácil de usar.

---

## 🛠️ Requisitos

- .NET Framework 4.7.2 ou superior
- Biblioteca [SSH.NET](https://github.com/sshnet/SSH.NET) instalada via NuGet

---

## 🚀 Instalação

1. Clone este repositório em sua máquina local:
    ```bash
    git clone https://github.com/seu-usuario/ExportSSH.git
    ```

2. Navegue até o diretório do projeto:
    ```bash
    cd ExportSSH
    ```

3. Restaure os pacotes NuGet necessários:
    ```bash
    dotnet restore
    ```

4. Compile o projeto:
    ```bash
    dotnet build
    ```

---

## 🚦 Uso

1. Execute o software:
    ```bash
    dotnet run
    ```

2. Insira as informações solicitadas:
    - **IP do servidor**
    - **Porta do servidor**
    - **Nome de usuário**
    - **Senha**

3. O software se conectará ao servidor remoto, extrairá os arquivos de configuração e os salvará no diretório `Downloads` do usuário.

4. Após a conclusão, você verá uma mensagem indicando que o download foi concluído.

---

## 💻 Exemplo

```bash
Informe o IP do servidor: 192.168.1.10
Informe a porta do servidor: 22
Informe o nome de usuário: admin
Informe a senha: ********
Conteúdo do arquivo database_config.xml: [conteúdo do arquivo]
Conteúdo do arquivo tnsnames.ora: [conteúdo do arquivo]
Download concluído.
