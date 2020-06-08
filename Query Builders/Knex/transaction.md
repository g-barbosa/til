# Usando transaction no knex

Transação é uma forma segura de garantir que se algo der errado no meio do processo de alteração do banco de dados, essas alterações não serão salvas.
Por exemplo, quando estamos fazendo alterações que mexem em duas tabelas. Se a alteração da segunda tabela der errado, a da primeira também não será salva.

Para usar transaction no knex, é muito simples:

Primeiro, crie uma variável e inicie a transação:
~~~js
    const trx = await knex.transaction();
~~~

Depois faça as tratativas do seu banco de dados normalmente, com uma diferença: Ao invés de usar 'knex' para fazer suas alterações, use a variável de transação criada:
~~~js
await trx('tabela').insert(dados)
~~~

E ao final de tudo é só commitar:
~~~js
trx.commit()
~~~