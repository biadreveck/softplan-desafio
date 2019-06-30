# softplan-desafio

Este projeto é a implementação de duas API's REST para o desafio .NET da Softplan.

## Ferramentas

* Linguagem: C# / .NET Core
* Gerenciamento de dependências: NuGet
* Hospedagem: Azure
	* API 1: [Taxa de Juros](https://apitaxajuros20190629055121.azurewebsites.net/)
	* API 2: [Cálculo de Juros](https://calculajuros20190629060702.azurewebsites.net/)
* Outras: Docker e Swagger

## O desafio

Você deverá criar duas API's uma com dois endpoints e outra com um endpoint:

###  API 1

#### 1) Retorna taxa de juros
Responde pelo path relativo "/taxaJuros"

Retorna o juros de 1% ou 0,01 (fixo no código)

Exemplo: /taxaJuros
Resultado esperado: 0,01

###  API 2

####  1) Calcula Juros
Responde pelo path relativo "/calculajuros"

Ela faz um cálculo em memória, de juros compostos, conforme abaixo:
Valor Final = Valor Inicial * (1 + juros) ^ Tempo

Valor inicial é um decimal recebido como parâmetro.

Valor do Juros deve ser consultado na API 1.

Tempo é um inteiro, que representa meses, também recebido como parâmetro.

^ representa a operação de potência.

Resultado final deve ser truncado (sem arredondamento) em duas casas decimais.

Exemplo: /calculajuros?valorinicial=100&meses=5
Resultado esperado: 105,10

#### 2) Show me the code
Este responde pelo path relativo /showmethecode
Deverá retornar a url de onde encontra-se o fonte no github

Esperamos que a entrega tenha
1) Código fonte em asp.net core no github (Mostrar conhecimento básico de git)
2) Teste unitários (Mostrar conhecimento de testes unitários, se possível TDD)
3) Utilização de Docker

## Extras
1) O ideal é este código rodar em algum servidor seu, podemos combinar tempo que irá funcionar. Se não tiver avise o entrevistador.
2) Teste de integração da API em linguagem de sua preferência (Damos importância para pirâmide de testes)
3) Utilizar swagger