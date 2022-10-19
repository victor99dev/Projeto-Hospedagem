# 💻 | Projeto: Sistema de Hospedagem - Desafio DIO.

### Projeto integrador feito para por em prática as de C#:

Seja bem vindo ao meu projeto chamado "Sistema de Hospedagem", feito totalmente para meus estudos e aperfeiçoamento como profissional. ❤️

- Colocando em prática conceitos obtidos durante a aula.

- Utilizando a linguagem: C#.


### 🎬 | Preview: 
Aqui inserimos os dados Iniciais que é pedido:
No caso estamos inserindo 4 hóspede na reserva. 

```cs
Pessoa p1 = new Pessoa(nome: "Hóspede 1", sobrenome: "");
Pessoa p2 = new Pessoa(nome: "Hóspede 2", sobrenome: "");
Pessoa p3 = new Pessoa(nome: "Hóspede 3", sobrenome: "");
Pessoa p4 = new Pessoa(nome: "Hóspede 4", sobrenome: "");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);
```
Temos o total de 4 hóspede, podemos inserir nome e sobrenome.

<br>
Aqui inserimos os dados necessario para calcular o valor da nossa reserva:

```cs
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 20);

Reserva reserva = new Reserva(diasReservados: 02);
```
Dando no console ```dotnet run``` podemos ter a resposta:

```
Hóspedes: 4
Valor diária: R$ 40
```
Existem algumas validações que foram criadas a pedido do desafio como:
- Verificar a capacidade com total de de hóspede.
- Da um desconto de 10% se caso a hospedagem for igual ou maior que 10 dias.

<b>Segue a lista de commits para verificar o que foi alterado!</b>

<b>[Certificado do Projeto]()</b>


## 👩‍💻 Meus Links:

- Github: [Victor Hugo.](https://github.com/torugo99)
- LinkedIn: [Victor Hugo.](https://www.linkedin.com/in/victor-hugo99/)
- Meu Site: [Victor99dev.](http://victor99dev.site/)

### 😀 | Créditos e Agradecimentos:

- Obrigado a DIO a essa oportunidade de UP na minha carreira! ❤️