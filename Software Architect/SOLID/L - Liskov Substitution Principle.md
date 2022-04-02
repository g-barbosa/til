# Princípio da substituição de Liskov

> Se q(x) é uma propriedade demonstrável dos objetos x de tipo T. Então q(y) deve ser verdadeiro para objetos y de tipo S onde S é um subtipo de T.

Se a nossa classe não pode se comportar como a classe que ela está herdando, então temos um problema de abstração.

**Por exemplo:**

Temos uma classe **_Veículo_**, com um método _**voar()**_ e temos uma classe _**Helicóptero**_ que herda essa classe **_Veículo_**. 

```c#
    public class Veiculo
    {
        public string Nome { get; set; }
        public virtual void Voar()
        {
            Console.WriteLine($"O veículo {Nome} está voando");
        }
    }

    public class Helicoptero : Veiculo
    {

    }
```

Tudo certo, afinal um helicóptero é um subtipo de veículo e o helicóptero pode voar. Mas e se tivermos uma classe _**Moto**_ herdando a classe _**Veículo**_, desta forma? 

```c#
    public class Moto: Veiculo
    {

    }

...

Veiculo moto = new Moto();
moto.Voar() //>>>>>>>>>> WTF!?

```

Uma moto é um veículo, porém não pode voar. Logo, estamos quebrando o princípio da substituição de Liskov.

**Solução:**

Tiramos o método **_voar()_** da classe _**Veículo**_ e criamos uma classe _**VeículoAéreo**_ com o método _**voar()**_ e então fazemos com que nossa classe _**Helicóptero**_ herde a classe _**VeículoAéreo**_.

```c#
    public class Veiculo
    {
        public string Nome { get; set; }
    }

    public class VeiculoAereo : Veiculo
    {
        public virtual void Voar()
        {
            Console.WriteLine($"O veículo {Nome} está voando");
        }
    }

    public class Helicoptero : VeiculoAereo
    {

    }

    public class Moto: Veiculo
    {

    }
```

Desta forma nem a moto e nem o helicóptero deixam de ser um veiculo, porem não é mais possível voar com a moto (nunca foi).

Criei uma classe _**LavaRapido**_ com um método _**Lavar()**_ que recebe um tipo de _**Veiculo**_

```c#
    public class LavaRapido
    {
        public void Lavar(Veiculo veiculo)
        {
            Console.WriteLine($"Lavando o veiculo {veiculo.Nome}");
        }
    }
```
E assim consigo lavar meus dois veículos, mesmo que o helicóptero seja um veículo aéreo, pois a classe _**VeiculoAereo**_ ainda é um subtipo de _**Veiculo**_.
 
```c#
var lavaRapido = new LavaRapido();

Veiculo moto = new Moto();
VeiculoAereo helicoptero = new Helicoptero();

lavaRapido.Lavar(moto);
lavaRapido.Lavar(helicoptero);
```
