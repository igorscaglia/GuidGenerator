# Sobre

Guid Generator é um microserviço RESTful Web Api criado em .NET Core 3.1 que tem o intuito de servir como base para testes de CI e CD com Wercker.

# Exemplos

Esse microserviço gera de forma aleatório Guids de acordo com o parâmetro solicitado:

/guidgenerator/generate/100 => Gera 100 Guids.

/guidgenerator/generate/1   => Gera 1 Guid.

/guidgenerator/generate     => Gera 1 Guid.

# Informações sobre o Wercker

- O arquivo wercker.yml está dividido em 2 grandes pipelines para exemplificar de forma bem clara a integração contínua - CI e a entrega contínua - CD.

- É preciso criar uma nova aplicação no portal [Wercker](https://app.wercker.com/)

- É preciso criar e configurar a ordem dos pipelines pela aba 'Workflows' no portal [Wercker](https://app.wercker.com/) como: build > test > publish > deploy.

- É preciso criar as variáveis de ambiente USERNAME, PASSWORD, REPOSITORY e TAG pela aba 'Environment' no portal [Wercker](https://app.wercker.com/).
