Console.Clear();

Console.WriteLine("Informe o nome do aluno: ");
string nomeAluno = Console.ReadLine();

Console.WriteLine("Informe as  3 notas de {0}", nomeAluno);
double[] notas = new double[3];

notas[0] = double.Parse(Console.ReadLine());
notas[1] = double.Parse(Console.ReadLine());
notas[2] = double.Parse(Console.ReadLine());

double adicaoNotas = 0;

Console.WriteLine("As notas foram:");

foreach (double n in notas)
{
    Console.WriteLine(n);
    adicaoNotas += n;
}

double mediaAluno = adicaoNotas / 3;
Console.WriteLine("A média do aluno {0} foi: {1}.", nomeAluno, mediaAluno.ToString("F2"));
