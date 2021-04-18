# Strategy

[![Strategy](https://www.devmedia.com.br/imagens/articles/169202/estrutura_strategy.png)](https://www.devmedia.com.br/strategy-design-patterns/18839)

A ideia do Strategy é você criar uma classe que implemente uma interface que é sua strategy e uma classe context que recebe por injeção de dependencia uma classe do tipo strategy que você criou. Desta forma o nosso context pode nos retornar o mesmo modelo de resultado usando diferentes estratégias variadas de acordo com a necessidade do cliente.