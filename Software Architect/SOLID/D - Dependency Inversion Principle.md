# Princípio da inversão de dependência

> Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações; Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações.

Dependa de uma abstração e não de uma implementação.

### Exemplo:

**Problema:**

Temos uma classe **Pet** com o método **adicionarPet** e dentro deste metódo nós criamos uma nova instância de uma classe **PetRepositorio** para poder usar seu método de SalvarPet. O problema é que toda vez que nosso **PetRepositorio** for alterado, precisamos mudar a nossa classe **Pet**. Nossa classe não deveria precisar saber como se instancia este repository ou que tipo de parâmetros ele deveria receber. Devido a isso, estamos quebrando o princípio da inversão de dependência.

**Solução:**

Criamos a interface **IPetRepositorio** e fazemos com que nossa classe **PetRepositorio** implementa-a. Dentro da classe **Pet**, nós injetamos nossa classe **PetRepositorio** representada pela sua interface **IPetRepositorio**. Assim a **Pet** não é obrigada a saber como criar uma instância de **PetRepositorio** e quem for consumir esta classe deve passar as instâncias já criadas no construtor dela. Desta forma, invertemos o controle.
