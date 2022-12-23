using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaApp
{
     static class Nturma
    {
        // private Turma[] turmas = new Turma[10];
        private static List<Turma> turmas = new List<Turma>();
        private  static void Inserir(Turma t)
        {
            turmas.Add(t);
        }
        private static List<Turma > Listar()
        {
            return turmas;
        }
    }
}
