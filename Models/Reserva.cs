namespace DesafioProjetoHospedagem.Models
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

        /// <summary>
        /// Verifica se a capacidade é maior ou igual ao número de hóspedes sendo recebido
        /// </summary>
        /// <param name="hospedes"></param>
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade < hospedes.Count)
                throw new ArgumentException("Número de hóspedes maior do que a capacidade suportada.");

            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        /// <summary>
        /// Retorna a quantidade de hóspedes (propriedade Hospedes)
        /// </summary>
        /// <returns></returns>
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        /// <summary>
        /// Retorna o valor da diária
        /// Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
        /// </summary>
        /// <returns></returns>
        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
                valor = (decimal)((long)valor * 0.9);

            return valor;
        }
    }
}