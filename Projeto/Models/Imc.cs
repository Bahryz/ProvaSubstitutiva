namespace Projeto.Models;


public class Imc
{
        public int ImcId { get; set; }  
        public Aluno Aluno { get; set; }  
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Resultado { get; set; }  
}