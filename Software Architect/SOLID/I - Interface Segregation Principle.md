# Princípio da segregação de interfaces

> Nenhum cliente deve ser forçado a depender de métodos que não utiliza.

Onde podemos dizer que clientes são nossas classes e essas não devem depender de métodos que nunca vão utilizar

### Exemplo:

**Problema:**

Suponhamos que temos uma interface **IBanhoPet** com os métodos **LavarPatinha()**, **LavarAsas()** e **Secar()** e criamos uma classe **BanhoPardal** e outra **BanhoGato**. A classe **BanhoPardal** utiliza todos os métodos que a interface nos diz para implementar. Já a classe **BanhoGato** não precisa utilizar o método **LavarAsa()**, afinal, gatos não possuem asas. Porém também não podemos deixar de implementá-lo, pois uma interface é como um contrato que nos obriga a implementar todos os seus métodos. Logo, estamos ferindo o princípio da segregação de interfaces.

**Solução:**

Criamos uma interface **IBanhoGato** que possui os métodos **LavarPatinha()** e **Secar()** e outra **IBanhoPardal** que possui os mesmos métodos da **IBanhoGato** com a adição do método **LavarAsa()** e as nossas classes implementam as suas respectivas interfaces.
