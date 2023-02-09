using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADA_Modulo_3___Exercicios
{
  internal class Time
  {
    public string Nome { get; set; }
    public List<Jogador> Jogadores { get; set; }

    public Time(string nome, List<Jogador> jogadores)
    {
      Nome = nome;
      Jogadores = jogadores;
    }
  }
}
