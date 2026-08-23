# Mini-Projeto-Vistoria-Veicular

Mini projeto avaliativo curso de BackEnd.NET SCTECH.

## O que o sistema faz

O AutoCheck.NET é uma aplicação feita em C#, que roda em .NET. Ela simula a vistoria técnica de veículos para uma conceissionaria.O sistema:
- Identifica qual o tipo de veículo, como carro, moto ou caminhão;
- Avalia os itens da vistoria como "Bom", "Regular" ou "Ruim";
- Cria uma pontuação do estado do carro;
- Identifica potênciais peças para uma revisão mais detalhada;
- Classifica o veículo em Aprovado com excelência, aprovado com apontamentos e reprovado na vistoria.

## Como executar

Precisa de uma máquina com .NET SDK instalada na versão 10.0.

```
> Primeiro clonar o repositório por algum terminal
git clone https://github.com/GabrielEstefano/Mini-Projeto-Vistoria-Veicular.git

> Após isso, entre na pasta do projeto
cd Mini-Projeto-Vistoria-Veicular/projeto

> E execute a aplicação escrevendo no terminal
dotnet run

```

Quando rodar aparecerá um menu com as opções:
1 - Realizar Vistoria.
2 - Exibir Vistorias Anteriores.
3 - Sair.

Após algumas perguntas sobre os dados do veículo virão outras perguntando sobre os status de determinados itens.
Com cada um valendo:
| Status | Pontos |
|---|---|
| Bom | 10 PONTOS |
| Regular | 5 PONTOS |
| Ruim | 0 PONTOS |

### Pontuação de classificação:
 A classificação fica desse jeito:
| Percentual |	Classificação|
|---|---|
|90% a 100% |	Aprovado com Excelência |
|60% a 89% |	Aprovado com Apontamentos |
|0% a 59% |	Reprovado na Vistoria |

O percentual de aprovação é feito a partir desse calculo:
```
Percentual (%) = (Pontuação Obtida / Pontuação Máxima Possível) × 100
```

### Link do vídeo explicação:
```
Google Drive:
https://drive.google.com/drive/folders/1fmCZ_PTBRPPXl9YnUvbEFZIbfKdeyENS?usp=drive_link
```

Codigo escrito por Gabriel Estefano