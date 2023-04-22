# GMP - SISTEMA DE GERENCIAMENTO DE MEMBROS E PATRIMÔNIOS

## Contexto do problema:
* Cotijuba é apenas um dos diversos lugares que possuem instituições que buscam fazer a diferença na vida das pessoas de dentro e de fora de suas comunidades. No caso da 3° maior ilha do arquipélago belenense, essa instituição se chama MMIB (Movimento de Mulheres das Ilhas de Belém), que é uma associação composta majoritariamente por mulheres, onde o principal objetivo é afirmar a autonomia, a autoestima e desenvolver o conhecimento do cidadão. Considerando que o MMIB é uma associação sem fins lucrativos, é evidente que para continuar em atividade faz-se necessário o suporte contínuo de seus membros e associados. 
* Para a criação do projeto, foi importante levar em consideração a situação atual da organização: pouquíssima conexão com a internet e computadores que mal funcionam.

## O objetivo do projeto:
* Esse projeto visa o desenvolvimento de um sistema de gerenciamento de membros e patrimônios e tem como intuito principal ser utilizado como uma solução para as dificuldades que a instituição, conhecida como MMIB, sofre.
* Criação de um sistema híbrido, capaz de ser utilizado mesmo com baixa ou nenhuma conexão com a internet, salvando os dados cadastrados localmente em um arquivo json, para depois, com uma conexão estabelecida, envia-los para a nuvem.


## Tecnologias utilizadas:

* Esse sistema está sendo desenvolvido em _C#_ buscando uma melhor performance para máquinas com menor poder de processamento e possuirá uma verificação de conexão com a Internet para a transferência de dados, garantindo seu funcionamento mesmo em lugares com acesso debilitado à Internet.
* _Visual Studio_ será utilizado, junto com a linguagem _C#_, para a criação do sistema, utilizando uma aplicação _Windows Forms (.NET Framework)_.
* A _conexão com a nuvem_ será feita por meio da comunicação com a _API do Google Planilhas_, para garantir o envio, leitura e edição de dados.

## Funcionalidades
###  1. EXTERNAS

* Cadastro de Membros e Patrimônios
* Visualização de dados de Membros e Patrimônios
* Edição de dados cadastrados de Membros e Patrimônios
### 2. INTERNAS

* Conexão com o serviço de nuvem do Google Planilhas
* Checagem da conexão com a internet
* Criação de um arquivo json para armazenar os dados localmente
* Envio dos dados do arquivo json para a nuvem
* Leitura e edição de dados salvos 

## DEMO
![232625750-d0f194fc-970b-413f-aa00-386f49303d02](https://user-images.githubusercontent.com/80503035/233559599-f8bd8a40-4382-408b-af19-ed26da8b1b4a.png)

##  Integrantes do projeto:
* Felipe Machado Dias Ramos - [felipemdramos@gmail.com](mailto:felipemdramos@gmail.com);
* Leticia Keuffer Cavalleiro de Macedo - [lekeuffer@gmail.com](mailto:lekeuffer@gmail.com);
* Pedro Benitah Vieira Sanchez de Melo - [pedrobenitah@gmail.com](mailto:pedrobenitah@gmail.com);
* Vitor Gurjão Sampaio Pombo - [vitor.pombo.2003@gmail.com](mailto:vitor.pombo.2003@gmail.com);
* Vitor Longhi Ramôa - [vitorlr03@gmail.com](mailto:vitorlr03@gmail.com).

> Link do código: [SISTEMA DE GERENCIAMENTO DE MEMBROS E PATRIMÔNIOS](https://github.com/LeKeu/P.I._2023)
