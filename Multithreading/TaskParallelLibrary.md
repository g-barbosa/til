# Métodos importantes da biblioteca Task Parallel do C#

**Parallel.Invoke(() => task1(), () => task2())**: Executa as tarefas passadas nos callbacks do método em paralelo

**Parallel.for(0, 100, (i) => task(i))**: Executa todas as tarefas até o laço finalizar o range definido em paralelo

**Parallel.forEach(itens, (item) => task(item))**: Executa todas as tarefas passadas na coleção do item em paralelo

**Parallel.for(0, 100, (int i, ParallelLoopState state) ⇒ { state.Break(); })**: Interrompe a execução no estado atual