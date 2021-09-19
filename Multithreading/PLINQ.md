# Métodos importantes de consultas paralelas com LINQ

**colecao.AsParallel()**: Gera consulta em paralelo quando necessário

**colecao.AsParallel().WithExecutionMode(ParallelExecutionMode.default)**: A biblioteca decide se vai ser usado o paralelismo

**colecao.AsParallel().WithExecutionMode(ParallelExecutionMode.ForceParallelism)**: Força o uso do paralelismo

**colecao.AsParallel().WithExecutionMode(ParallelExecutionMode.ForceParallelism).WithDegreeOfParallelism(4)**: Faz no máximo 4 tarefas concorrentes