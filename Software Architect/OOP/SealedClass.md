# Classe selada

Sealed class são usadas quando não queremos que nossa classe seja derivada.

Por exemplo:

Eu criei a classe **Gato** e não quero que alguma outra classe seja filha dela, então eu uso o modificador de acesso **sealed**.

```c#
sealed class Gato 
{
  public virtual void Som()
  {
    Console.WriteLine("miau!");
  }
}
```

Ao tentar fazer como o exemplo abaixo e tentar compilar o código, uma exceção será lançada dizendo que não é possível derivar do tipo **sealed**.

```c#
class Gatinho : Gato 
{
  override public void Som()
  {
    Console.WriteLine("miauzinho!");
  }
}
```