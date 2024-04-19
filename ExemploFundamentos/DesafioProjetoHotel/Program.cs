using DesafioProjetoHotel.Models;


// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = [];

Pessoa p1 = new(nome: "Rodrigo", sobrenome: "Camurça");
Pessoa p2 = new(nome: "Pâmela", sobrenome: "Talita");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():C}");