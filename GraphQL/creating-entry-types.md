# Criando tipos de entradas

### É possível criar tipos pré-definidos de entradas para usar em suas querys ou mutations no GraphQL

Geralmente, quando criamos uma query ou mutation que precisa receber parâmetros de entrada, nós escrevemos cada uma das variáveis e os tipos que esperamos receber:

~~~graphql
type User {
    id: Int!
    username: String!
}

type Query {
    searchUser(username: String!): User!
}
~~~

O problema é que se nossa entrada for composta de vários parâmetros, fica extremamente maçante e estéticamente feio, ter que escrever tudo isso. Porém, é possível criar um tipo de entrada que já é composto por todos os atributos necessários para a query. Podemos também reutilizá-las, diminuindo ainda mais a quantidade de coisas repetidas que o dev teria que escrever:

~~~graphql
input SearchUserInput {
    username: String!
}

type Query {
    searchUser(data: SearchUserInput!): User!
}
~~~

E então, quando eu fosse executar a query, ficaria assim:

~~~graphql
Query{
    searchUser(data: {username: "test12345"}){
        id
        username
    }
}
~~~