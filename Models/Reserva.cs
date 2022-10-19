namespace ProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
                       
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {            
                    Console.WriteLine("Número de hóspedes é maior que a capacidade");
            } 
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {

            int numeroH = Hospedes.Count;
                return numeroH;
        }

        public decimal CalcularValorDiaria()
        {

            decimal valor = DiasReservados * (Suite.ValorDiaria);

            if (DiasReservados >= 10)
            {
                return valor = (valor - valor/10);
            }

            return valor;
        }
    }
}