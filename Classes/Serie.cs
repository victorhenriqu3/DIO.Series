using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        public override string ToString()
        {
            return $"Gênero: {this.Genero}{Environment.NewLine}Titulo: {this.Titulo}{Environment.NewLine}Descrição: {this.Descricao}{Environment.NewLine}Ano: {this.Ano}";
        }
    }
}
