# Princípio do aberto/fechado

> Entidades de software devem ser abertas para extensão, mas fechadas para modificação.

Se você precisa adicionar uma nova funcionalidade, então é melhor extender do que modificar.

**Por exemplo:**

Temos uma classe _**Veiculo**_ que recebe no seu construtor um tipo de veículo e dentro dela o método _**Ligar()**_ que tem uma sequência de condicionais que verifica o tipo do veículo e realiza a operação adaptada a ele. Sendo assim, toda vez que for adicionado um novo veiculo, nós precisaríamos adicionar uma nova condição ao nosso método. Logo, nossa classe/método está aberta para modificação e estamos quebrando o princípio do aberto/fechado.

```c#
    public class Veiculo
    {
        private readonly TipoVeiculoEnum _tipoVeiculo;

        public Veiculo(TipoVeiculoEnum tipoVeiculo)
        {
            _tipoVeiculo = tipoVeiculo;
        }

        public string Nome { get; set; }

        public void Ligar()                             
        {
            if (_tipoVeiculo == TipoVeiculoEnum.Carro)
            {
                Console.WriteLine("Carro pronto para ser dirigido");
            }
            if (_tipoVeiculo == TipoVeiculoEnum.Moto)
            {
                Console.WriteLine("Moto pronta para ser pilotada");
            }
        }
    }
```

Para um exemplo de um método que utilize a _**Veiculo**_, criei uma classe _**LavaRapido**_ com um método _**Lavar()**_ que recebe um tipo de _**Veiculo**_

```c#
    public class LavaRapido
    {
        public void Lavar(Veiculo veiculo)
        {
            Console.WriteLine($"Lavando o veiculo {veiculo.Nome}");
        }
    }
```
```c#
var moto = new Veiculo(TipoVeiculoEnum.Moto);
moto.Ligar();

var lavaRapido = new LavaRapido();
lavaRapido.Lavar(moto);
```

**Solução:**

Podemos criar a classe abstrata _**Veiculo**_ com seu método abstrato _**Ligar()**_ e para cada novo veiculo que formos adicionando ao nosso projeto, criamos uma classe para ele, herdamos a classe _**Veiculo**_ e sobrescrevemos o método _**Ligar()**_ de acordo com as necessidades do veículo.

```c#
    public abstract class Veiculo
    {
        public string Nome { get; set; }
        public abstract void Ligar();
    }
```

```c#
    public class Moto : Veiculo
    {
        public override void Ligar()
        {
            Console.WriteLine("Moto pronta para ser pilotada");
        }
    }

    public class Carro : Veiculo
    {
        public override void Ligar()
        {
            Console.WriteLine("Carro pronto para ser dirigido");
        }
    }
```
O método _**Lavar()**_ da classe _**LavaRapido**_ não deixa de funcionar, pois tanto a classe _**Moto**_ quanto a classe _**Carro**_ são subtipos de Veiculo.

```c#
var moto = new Moto();
var carro = new Carro();
moto.Ligar();
carro.Ligar();

var lavaRapido = new LavaRapido();
lavaRapido.Lavar(moto);
lavaRapido.Lavar(carro);
```
