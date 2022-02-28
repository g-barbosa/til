# Arquitetura Orientada a Eventos

**Primeiro entendendo o que é um evento:**
Um evento é toda alteração de estado em um sistema. Por exemplo quando finalizamos um compra em um e-commerce. Esta ação gera um evento.

**Como funciona o EDA:**
Em uma arquitetura orientada a eventos, nós temos os pubs e os subs. Os pubs são os que observam as mudanças (eventos) e os enviam para os subs. Já os subs são aqueles que recebem e que podem manipular esses eventos.
Todos os eventos são enviados por meio de canais e distribuidos em fila para seus respectivos consumidores. Tudo feito de forma assincrona.

**Ainda utilizando o exemplo de e-commerce:** 
Um cliente finalizou uma compra, logo um evento é disparado para o canal (broker de eventos) e todos os subs inscritos nesse canal recebem esse evento. Por exemplo, um serviço de estoque para diminuir a quantidade de produtos no banco e o serviço de notificações para avisar ao cliente que o produto foi comprado com sucesso.

