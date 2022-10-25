List<string> nome = new List<string>();

nome.Add("José");
nome.Add("Maria");
nome.Add("João");
nome.Add("Ruth");

foreach (var item in nome)
{
    WriteLine(item);
}

WriteLine();

WriteLine(nome[2]);

WriteLine();

WriteLine("Quantidade de registros " + nome.Count);
WriteLine("Capacidade da minha lista " + nome.Capacity);

nome.Insert(2, "nicolau");
string[] novosNomes = { "novoNome1", "novoNome2", "novoNome3" };
nome.InsertRange(3,novosNomes);
foreach (var item2 in nome)
{
    WriteLine(item2);
}
WriteLine();

nome.Remove("novoNome1");
nome.RemoveAt(4);
nome.RemoveRange(3, 2);
//nome.Clear();
foreach (var item in nome)
{
    WriteLine(item);
}

WriteLine();

int idx = nome.IndexOf("Ruth");

if (idx >= 0)
{
    WriteLine($"Item da lista n°:{idx}");
}
else
{
    WriteLine("Item não encontrado!");
}
nome.Add("Brian");
nome.Sort();

foreach (var item in nome)
{
    WriteLine(item);
}
WriteLine();
nome.Reverse();

foreach(var item in nome)
{
    WriteLine(item);
}

WriteLine();
nome[3] = "Josefa";

foreach (var item in nome)
{
    WriteLine(item);
}


//2

List<string> nomes = new List<string>();

for (int i = 1; i <=10;i++)
{
    WriteLine("digite nome");
    nomes.Add(ReadLine());
}
Clear();

foreach (var item in nomes)
{
    WriteLine(item);
}

WriteLine("Primeiro posição "+ nomes[0]);
WriteLine("Ultima posição " + nomes[9]);


//3

using static System.Console;

List<double> notas = new List<double>();
List<string> nomes = new List<string>();

for (int i = 1; i <= 10; i++)
{
    WriteLine($"Digite {i}º nome");
    nomes.Add(ReadLine());
    WriteLine($"Digite {i}° nota");
    notas.Add(Convert.ToDouble(ReadLine()));
    
}

double soma = 0;
double media = 0;
foreach (var item in notas)
{
    soma += item;
}

media = soma / 10;
WriteLine("a média dos alunos foi: "+media);
WriteLine();
int posicao = 0;
foreach (string aluno in nomes)
{
    WriteLine($"Aluno{aluno} - Nota: {notas[posicao]}");
    posicao++;
}

ReadKey();
