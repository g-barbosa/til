# Princípio da responsabilidade única

> Uma classe deve ter apenas uma razão para mudar.

Cada classe deve ter uma única responsabilidade dentro do projeto.

**Por exemplo:**

Vamos supor que no nosso projeto exista a seguinte classe:

```c#
    public class PetShop
    {
        public decimal CalculaReceita(){}
        public void PagarFuncionarios(){ }
        public void AdicionarPet(Pet pet) { }
        public Pet BuscarPet(int id) { }
    }
```
Ela é responsável por uma série de tarefas, como calculo de finanças, pagamento de funcionários e cadastro de Pets... Muita coisa, né!?
Neste caso, nós teríamos cinco razões completamente diferentes para alterar uma classe, já quebrando o principio da responsabilidade única. Sem falar no alto acoplamento e na dificuldade de manutenção.

O ideal seria criar uma classe para cada responsabilidade diferente: 

```c#
    public class Receita
    {
        public decimal CalcularReceita() { }
    }

    public class Pagamentos
    {
        public void PagarFuncionarios() { }
    }

    public class PetRepositorio
    {
        public void AdicionarPet(Pet pet) { }
        public Pet BuscarPet(int id) { }
    }
```
Muito mais fácil de entender e bonito de se ver, não é mesmo?
