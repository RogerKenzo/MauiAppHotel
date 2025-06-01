using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; }

        public int qntAdultos { get; set; }
        public int qntCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }

        public int Estadia
        {
            get => DataCheckOut.Subtract(DataCheckIn).Days;
        }

        public double ValorTotal
        {
            get
            {
                double valor_adultos = qntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valor_criancas = qntCriancas * QuartoSelecionado.ValorDiariaCrianca;

                double total = (valor_criancas + valor_adultos) * Estadia;

                return total;
            }
        }
    }
}