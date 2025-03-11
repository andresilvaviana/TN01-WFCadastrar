using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN01_WFCadastrar
{
    public class Pessoas
    {
        public Pessoas(
            string? nomecompleto,
            string? dddtelefone,
            DateTime? datanascimento,
            string? escolaridade,
            char sexo,
            double rendamensal,
            bool possuifilhos)
        {
            this.nomecompleto = nomecompleto;
            this.dddtelefone = dddtelefone;
            this.datanascimento = datanascimento;
            this.escolaridade = escolaridade;
            this.sexo = sexo;
            this.rendamensal = rendamensal;
            this.possuifilhos = possuifilhos;
        }

        public Pessoas()
        {
        }

        public static List<Pessoas> listaPessoas = new List<Pessoas>();

        public string? nomecompleto { get; set; }
        public string? dddtelefone { get; set; }
        public DateTime? datanascimento { get; set; }
        public string? escolaridade { get; set; }
        public char sexo { get; set; }
        public double rendamensal { get; set; }
        public bool possuifilhos { get; set; }

    }
}
