
# Clean Architecture for .NET Applications

**Pontifícia Universidade Católica de Minas Gerais**  
**Especialização:** Arquitetura de Software Distribuído  
**Disciplina:** Análise, Projeto e Avaliação Arquitetural  
**Professor:** Marco Mendes  

**Guias inicial para compreensão de como estruturar um projeto com o padrão de arquiteturas limpas:**  
https://paulovich.net/clean-architecture-for-net-applications/   

**O código se refere à implementação abaixo, baseada no exemplo acima:**
- Domínio simples de uma empresa de varejo com os seguintes requisitos:
  - Cadastro de livros com informações tais como ISBN, título, preço e lista de autores.
  -	Manutenção de um carrinho de compras, onde livros podem ser adicionados ou remo-vidos.
  - Efetivação de um pedido a partir de um carrinho de compras. 

## Arquitetura

**Diagrama de Domínios**

![Diagrama de Domínios](Ativ5.WebApi/Assets/diagrama.jpg)  

**Business Entities**  

![Domínios e Entidades de Negócio](Ativ5.WebApi/Assets/domains_entities.jpg)

**Value Objects**  

![Objetos de Valor](Ativ5.WebApi/Assets/vos.jpg)

