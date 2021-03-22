# Princípio do aberto/fechado

> Entidades de software devem ser abertas para extensão, mas fechadas para modificação.

Se você precisa adicionar uma nova funcionalidade, então é melhor extender do que modificar.

### Exemplo:

**Problema:**

Temos uma classe **Veiculo** que recebe no seu construtor um tipo de veículo e dentro dela o método **Dirigir** que tem uma sequência de condicionais que verifica o tipo do veículo e realiza a operação adaptada a ele.
Sendo assim, toda vez que for adicionado um novo veiculo, nós precisariamos adicionar uma nova condição ao nosso método. Logo, nossa classe/método está aberta para modificação e estamos quebrando o princípio do aberto/fechado.

**Solução:**

Podemos criar a classe abstrata **Veiculo** com seu método abstrato **Dirigir** e para cada novo veiculo que formos adicionando ao nosso projeto, criamos uma classe para ele, herdamos a classe **Veiculo** e sobreescrevemos o método **Dirigir** de acordo com as necessidades do veículo.
