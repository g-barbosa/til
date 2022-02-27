# Arquitetura Orientada a Serviços

**Primeiro entendendo o que é um serviço:**
Um serviço é uma série de funcionalidades independentes e que podem receber diversas requisições e fornecer diversas respostas. Um Serviço recebe e envia dados, possuí suas regras de negócio e transforma dados em informações

**Como funciona o SOA**
Criamos um serviço único com sua determinada função e utilizamos algum protocolo de comunição para receber e enviar informações (atualizar dados, por exemplo). Desta forma, vários sistemas podem interagir com o serviço de forma independente e com baixo acoplamento, e se um dia precisemos alterar nosso serviço, ou até mesmo utilizar um outro completamente diferente, a transição se torna uma tarefa muito mais fácil, justamente por esse baixo acoplamento.

Uma das grandes vantagens do SOA é evitar a redunancia de código, já que ao invés de cada sistema possuir um código que executa determinada função, criamos um serviço central para isso, e fazemos com que nossos sistemas consumam este serviço.
