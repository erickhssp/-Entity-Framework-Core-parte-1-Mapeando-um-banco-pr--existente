﻿namespace Alura.Filmes.App.Dados
{
    public class Idioma
    {
        public byte Id { get; set; }
        public string Nome { get; set; }


        public override string ToString()
        {
            return $"({Id}): {Nome}";
        }
    }
}