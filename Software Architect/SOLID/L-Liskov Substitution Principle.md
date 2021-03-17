# Princípio da substituição de Liskov

> Se q(x) é uma propriedade demonstrável dos objetos x de tipo T. Então q(y) deve ser verdadeiro para objetos y de tipo S onde S é um subtipo de T.

Se a nossa classe não pode se comportar como a classe que ela está herdando, então temos um problema de abstração.

### Exemplo:

**Problema:**

Temos uma classe Veículo, com um método voar() e temos uma classe Helicóptero que herda essa classe Veículo. Tudo certo, afinal um Helicóptero é um subtipo de veículo e o Helicóptero pode voar.
Mas e se tivermos uma classe Moto herdando a classe veículo? 
Uma Moto é um Veículo, porém não pode voar. Então, estamos quebrando o princípio da substituição de Liskov.

**Solução:**

Tiramos o método voar() da classe Veículo e criamos uma Classe VéiculoAéreo com o método voar() e então fazemos com que nossa classe Helicóptero herde a classe VéiculoAéreo.
