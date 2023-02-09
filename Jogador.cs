using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA_Modulo_3___Exercicios
{
  internal class Jogador
  {
    public string Nome { get; set; }
    public Tipo Posicao { get; set; }

    public Jogador(string nome, Tipo posicao)
    {
      Nome = nome;
      Posicao = posicao;
    }

    public override string ToString()
    {
      return $"{Nome} ({Posicao})";
    }
  }
}
