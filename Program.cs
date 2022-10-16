using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "André Márcio", sobrenome: "Gonçalves de Oliveira");

Pessoa p2 = new Pessoa(nome: "Felipe", sobrenome: "Matthews");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();




















// p1.Idade = 31;
// p1.Apresentar();