# Princípio da responsabilidade única

> Uma classe deve ter apenas uma razão para mudar.

Cada classe de ter uma única responsabilidade dentro do projeto.

### Exemplo:

**Problema:**

Temos uma classe **Petshop** e dentro dela temos os métodos **CalcularReceita()** e **CalcularDespesa()** que pegam, respectivamente todos os lucros e despesas que tivemos no mês e retornam a soma desses valores, e **AdicionarPet()** e **BuscarPet()** que, respectivamente registra um novo Pet e procura um Pet especifico no banco e o retorna.
Não é correto uma classe ser responsável por tantas coisas diferentes... Logo, estamos quebrando o princípio da responsabilidade única.

**Solução:**

Criamos a classe **Financas**, que é responsável por cuidar de tudo que seja sobre o assunto financeiro e a classe **Pet** que é responsável apenas pelos pet's
