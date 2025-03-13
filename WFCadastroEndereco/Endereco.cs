using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroEndereco
{
    public class Endereco
    {
        public Endereco(
            string? nome,
            string? cep,
            string? logadouro,
            string? numero,
            string? complemento,
            string? bairro,
            string? cidade,
            string? uf,
            bool semnumero)
        {
            this.nome = nome;
            Cep = cep;
            this.logadouro = logadouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
            this.semnumero = semnumero;
        }

        public Endereco() { }

        public static List<Endereco> ListaEnderecos = new List<Endereco>();

        public string? nome { get; set; }
        public string? Cep { get; set; }
        public string? logadouro { get; set; }
        public string? numero { get; set; }
        public string? complemento { get; set; }
        public string? bairro { get; set; }
        public string? cidade { get; set; }
        public string? uf { get; set; }
        public bool semnumero { get; set; }


    }
}
