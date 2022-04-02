# Princípio da segregação de interfaces

> Nenhum cliente deve ser forçado a depender de métodos que não utiliza.

Onde podemos dizer que clientes são nossas classes e essas não devem depender de métodos que nunca vão utilizar

**Por exemplo:**

Suponhamos que temos uma interface _**IBanhoPet**_ com os métodos **_LimparPatas()_**, **_LimparAsas()_** e **_Secar()_** e criamos uma classe **_BanhoPardal_** e outra **_BanhoGato_** que implementam essa interface. 

```c#
public interface IBanhoPet
{
    void LimparAsas();
    void LimparPatas();
    void Secar();
}
```

A classe **_BanhoPardal_** utiliza todos os métodos que a interface nos diz para implementar. Já a classe **_BanhoGato_** não precisa utilizar o método **_LimparAsas_()**, afinal, gatos não possuem asas. Porém também não podemos deixar de implementá-lo, pois uma interface é como um contrato que nos obriga a utilizar todos os seus métodos. Logo, estamos ferindo o princípio da segregação de interfaces.

**Solução:**

Criamos uma interface **_IBanhoGato_** que possui os métodos **_LimparPatas_**() e **_Secar_**() e outra **_IBanhoAve_** que possui os mesmos métodos da **_IBanhoGato_** com a adição do método **_LimparAsas_**() e as nossas classes implementam as suas respectivas interfaces.

```c#
public interface IBanhoGato
{
    void LimparPatas();
    void Secar();
}
```

```c#
public interface IBanhoAve
{
    void LimparAsas();
    void LimparPatas();
    void Secar();
}
```
