# Princípio da inversão de dependência

> Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações; Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações.

Dependa de uma abstração e não de uma implementação.

**Por exemplo:**

Temos uma classe _**Petshop**_ que recebe no seu construtor um _**PetRepositorioMySQL**_ e possui o método **_CadastrarOuAtualizarPet()_** que verifica se o Pet informado já existe e o atualiza e caso contrário, cria um novo cadastro. 

```c#
    public class Petshop
    {
        private readonly PetRepositorioMySQL _petRepositorioMySQL;
        public Petshop()
        {
            _petRepositorioMySQL = new PetRepositorioMySQL();
        }

        public void _CadastrarOuAtualizarPet(string nome)
        {
            var pet = _petRepositorioMySQL.Get(nome);

            if (pet == null)
                _petRepositorioMySQL.Insert(pet);
            else
                _petRepositorioMySQL.Update(pet);
        }
    }
```
O problema é que se um dia nós resolvêssemos usar uma _**PetRepositorioSQLServer**_ no lugar da _**PetRepositorioMySQL**_, mesmo as duas possuindo os mesmos metódos, precisaríamos mudar a nossa classe **_Petshop_**. Nossa classe não deveria ter que saber como se instancia este repositório ou como que ele se comporta internamente. Só precisamos saber o que ele recebe e o que retorna. 
Devido a isso, estamos quebrando o princípio da inversão de dependência.

**Solução:**

Criamos a interface _**IRepositorioGenerico**_ e fazemos com que nossa classe _**PetRepositorioMySQL**_ implementa-a. 

```c#
    public class PetRepositorioMySQL : IRepositorioGenerico
    {
        public Pet Get(string nome)
        {
            throw new NotImplementedException();
        }

        public void Insert(Pet pet)
        {
            throw new NotImplementedException();
        }

        public void Update(Pet pet)
        {
            throw new NotImplementedException();
        }
    }
```
Dentro da classe _**Petshop**_, nós injetamos nossa classe _**PetRepositorioMySQL**_ representada pela sua interface _**IRepositorioGenerico**_. 

```c#
    public class Petshop
    {
        private readonly IRepositorioGenerico _repositorio;
        public Petshop(IRepositorioGenerico repositorio)
        {
            _repositorio = repositorio;
        }

        public void _CadastrarOuAtualizarPet(string nome)
        {
            var pet = _repositorio.Get(nome);

            if (pet == null)
                _repositorio.Insert(pet);
            else
                _repositorio.Update(pet);
        }
    }
```

Assim a _**Petshop**_ não é obrigada a instanciar o repositório, pois quem consumir esta classe deve passar as instâncias já criadas no construtor dela. E se caso um dia precisemos mudar o repositório, não precisaremos alterar a classe _**PetShop**_, desde que o novo repositório implemente a mesma interface. Desta forma, invertemos o controle.
