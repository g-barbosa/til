# Métodos Virtuais

O método virtual é um método que tem a opção de ser sobrescrito em uma classe que herda o mesmo de outra classe.

Por exemplo:

Temos a classe **Animal** com o método virtual **Som**

```c#
public class Animal
{
  public virtual void Som();
}
```

Ao criarmos uma classe **Gato** que herda a classe **Animal**, podemos sobrescrever o método Som() e mudá-la de acordo com a necessidade da classe **Gato**:

```c#
public class Gato : Animal
{
  override public void Som()
  {
    Console.WriteLine("miau!");
  }
}
````