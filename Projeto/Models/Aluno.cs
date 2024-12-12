namespace Projeto.Models;
using System.Collections.Generic;

public class Aluno
{
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public int ImcId { get; set; }  

        public List<Imc> Imcs { get; set; }

}

