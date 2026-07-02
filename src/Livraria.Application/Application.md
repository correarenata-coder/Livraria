# Projeto Application

## Objetivo
Contém a lógica e serviços da aplicação

## Descrição Application
Principalmente responsável por orquestrar as operações do sistema, coordenando a interação entre o domínio e a infraestrutura. Ele atua como uma camada intermediária, garantindo que as regras de negócio sejam aplicadas corretamente e que os dados sejam manipulados de forma consistente.


Nesta camada os casos de us são implementados como serviços da aplicação que orquestam a execução das regras de nefócio utilizando os conceitos definidos no dompinio (Domain)

Aqui são definidas as classes que implementam os casos de uso da aplicação que são responsáveis por chamar os métodos dos repositórios para acessar os dados, e também por chamar os métodos das classes de domínio para realizar a lógica de negócio.

Nesta camada, os DTOS são usados para representar dados que são transferidos entre os casos de uso e os repositórios.


### Observação
nessa aplicação não iremos usar a camada de Application, pois a aplicação é simples e não há necessidade de criar uma camada adicional para orquestrar as operações do sistema.