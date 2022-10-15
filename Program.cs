using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "André Márcio";
p1.Sobrenome = "Gonçalves de Oliveira";

Pessoa p2 = new Pessoa();
p2.Nome = "Felipe";
p2.Sobrenome = "Matthews";


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();




















// p1.Idade = 31;
// p1.Apresentar();