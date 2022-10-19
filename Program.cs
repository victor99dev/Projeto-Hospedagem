using System.Text;
using ProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1", sobrenome: "");
Pessoa p2 = new Pessoa(nome: "Hóspede 2", sobrenome: "");
Pessoa p3 = new Pessoa(nome: "Hóspede 3", sobrenome: "");
Pessoa p4 = new Pessoa(nome: "Hóspede 4", sobrenome: "");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 20);

Reserva reserva = new Reserva(diasReservados: 02);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: R$ {reserva.CalcularValorDiaria()}");