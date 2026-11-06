using ExerciciosPOO;

// 1

Pessoa pessoa1 = new()
{
    Nome = "Daniel",
    Idade = 19,
    Cidade = "São Paulo"
};

Pessoa pessoa2 = new()
{
    Nome = "Ronaldo",
    Idade = 33,
    Cidade = "Xique-Xique"
};

pessoa1.Apresentar();
pessoa2.Apresentar();

// 2

Calculadora calculo1 = new()
{
    a = 2,
    b = 5
};

calculo1.Somar();
calculo1.Subtrair();
calculo1.Multiplicar();

Calculadora.Dividir(8, 4);

// 3

Veiculo uno = new();

uno.setVelocidade(120);
uno.setVelocidade(350);

// 4

Funcionario funcionario1 = new();

funcionario1.Nome = "Daniel";
funcionario1.Cargo = "Engenheiro de Software";

funcionario1.AlterarSalario(4500);
funcionario1.AumentarSalario(5);
funcionario1.ConsultarSalario();
funcionario1.ConsultarFuncionario();

// funcionario1.Salario = 1000;
// The property or indexer 'Funcionario.Salario' cannot be used in this context because the set accessor is inaccessible
// ALterar salário é permitido apenas pelo método AumentarSalário() e AlterarSalario().

// 5

Livro livro1 = new();
Livro livro2 = new("1984");
Livro livro3 = new("Noites Brancas", "Dostoiévski");
Livro livro4 = new("A Metamorfose", "Franz Kafka", 232);

livro1.exibirLivro();
livro2.exibirLivro();
livro3.exibirLivro();
livro4.exibirLivro();