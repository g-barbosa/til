# Modificadores de acesso

Modificadores de acesso são palavras reservadas para definir o grau de acesso quem uma classe, método ou tipo tem.

São eles:

**Public**: Podem ser acessados por qualquer um.

**protected**: Acesso somente permitido a classes que herdam ou derivam dela.

**Internal**: Acesso permitido somente ao assembly* que a contém.

**Protected Internal**: Acesso limitado somente ao assembly ou a classes que derivam ou herdam dela.

**Private**: Apenas métodos da própria classe podem acessá-lo.

**Private Protected**: Somente classes que herdam ou derivam dela dentro do assembly.

**Sealed**: Nenhuma classe pode herdar dela.


*: É o arquivo final gerado pelo compilador, um .exe ou dll