<h1>Comandos básicos do Cli do .Net</h1>

Verificar qual a versão instalada:

~~~
dotnet --version
~~~

Informação detalhadas do SDK:

~~~
dotnet --info
~~~

Criação de um novo projeto:

~~~
dotnet new 
~~~

Criar um novo projeto listando todos os tipos de projetos Web que o .Net nos oferece:

~~~
dotnet new --list --tag web
~~~

Ajuda na criação de novos projetos:

~~~
dotnet new --help
~~~

Criar um novo projeto console:

~~~
dotnet new console -o myApp
~~~

Executar projeto:

~~~
dotnet run
~~~

Compilar projeto:

~~~
dotnet build
~~~

Restaurar pacotes e dependências:

~~~
dotnet restore
~~~