NhaNhaNha
=====

[![Build status](https://ci.appveyor.com/api/projects/status/e0y68wryloh0vg0k?svg=true)](https://ci.appveyor.com/project/AlbertoMonteiro/nhanhanha)
[![Nuget count](http://img.shields.io/nuget/v/NhaNhaNha.svg)](http://www.nuget.org/packages/NhaNhaNha/)
[![Nuget downloads](http://img.shields.io/nuget/dt/NhaNhaNha.svg)](http://www.nuget.org/packages/NhaNhaNha/)


O Que é?
--------

NhaNhaNha é uma biblioteca para geração de dados fictícios, porém verossímeis, para aplicações em português do Brasil.
Essa é uma versão .NET da versão orginalmente escrita em ruby: https://github.com/alcidesqueiroz/BlaBla

###A versão inicial(0.0.1) já conta com:

*	Gerador de Nomes Próprios de Pessoas

###Na versão 0.0.2 foi incluído:
*	Gerador de CPF
*	Gerador de CNPJ
*	Gerador de Cartão de Crédito
*	Gerador de Bacon Ipsum
*	Gerador de Lorem Ipsum

###Para as próximas versões devem vir:

*	Gerador de CEP	
*	Gerador de Endereços
*	Gerador de URLs
*	Gerador de Email
*	Gerador de Telefones
*	Gerador de Senhas
*	Entre outras coisas ... =)


Instalando
----------
```bash
PM> Install-Package NhaNhaNha
```

Uso
-----
```csharp
var homen = NhaNhaNha.Homen;
homen.PrimeiroNome  => "Eric"
homen.SobreNome  => "Macedo Soares"

var mulher = NhaNhaNha.Mulher;
mulher.PrimeiroNome  => "Marilia"
mulher.SobreNome  => "Monteiro Brasil"
```

Contribuindo
------------
Se você deseja contribuir, faça um Fork do [repo](https://github.com/AlbertoMonteiro/NhaNhaNha) no Github, faça as suas alterações e mande um pull request.


Contato
-------
Estou aberto a sugestões, elogios, críticas ou qualquer outro tipo de comentário. 

*	Twitter: [@aibertomonteiro](http://www.twitter.com/aibertomonteiro)

Licença
-------
Esse código é livre para ser usado dentro dos termos da licença MIT license
