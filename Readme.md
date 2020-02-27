
Guid Generator é um microserviço RESTful Web Api criado em .NET Core 3.1 que tem o intuito de servir como base para testes de CI e CD com Wercker.

Esse microserviço gera de forma aleatório Guids de acordo com o parâmetro solicitado:

/guidgenerator/generate/100 => Gera 100 Guids.

/guidgenerator/generate/5   => Gera 5 Guid.

/guidgenerator/generate/1   => Gera 1 Guid.

/guidgenerator/generate     => Gera 1 Guid.
