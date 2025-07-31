using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservas.Api.Models;

namespace Reservas.Testes.MockData
{
    public class ReservasMockData
    {
        public static List<Reserva> GetReservas()
        {
            return new List<Reserva>()
            {
                new Reserva { ReservaId = 1, Nome = "Matheus", InicioLocacao = "São Paulo", FimLocacao="Boituva" },
                new Reserva { ReservaId = 2, Nome = "Higor", InicioLocacao = "São Paulo", FimLocacao="Estados Unidos" },
                new Reserva { ReservaId = 3, Nome = "Bryan", InicioLocacao = "São Paulo", FimLocacao="Espanha" },
            };
        }
    }
}
