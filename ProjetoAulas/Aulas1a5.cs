/*
Console.WriteLine("Primeiro Programa");

int idade = 33;
Console.WriteLine(idade);
string nomePessoa = "Orlando"; // string aspa dupla
Console.WriteLine(nomePessoa);
decimal valor = 299.99m;
double valorDouble = 299.99;
float valorFloat = 299.99f;
Console.WriteLine(valor);
Console.WriteLine(valorDouble);
Console.WriteLine(valorFloat);

var idadeNova = 34f;


char flag = 'Y'; // char aspa simples
Console.WriteLine(flag);

bool ativo = true;
Console.WriteLine(ativo);

const string descricao = "Curso CSharp";
Console.WriteLine(descricao);


var n1 = 1;
var n2 = 2;

var soma = n1 + n2;
Console.WriteLine(soma);

var subtracao = n1 - n2;
Console.WriteLine(subtracao);

var mutiplicacao = n1 * n2;
Console.WriteLine(mutiplicacao);

var divisao = n2 / n1;
Console.WriteLine(divisao);



var n1 = 1;
var n2 = 2;

bool igual = n1 == n2;
Console.WriteLine(igual);

bool maior = n1 > n2;
Console.WriteLine(igual);

bool menor = n1 < n2;
Console.WriteLine(menor);

bool maiorOuIgual = n1 >= n2;
Console.WriteLine(maiorOuIgual);

bool menorOuIgual = n1 <= n2;
Console.WriteLine(menorOuIgual);

bool diferente = n1 != n2;
Console.WriteLine(diferente);



var n1 = 1;
var n2 = 2;

// && e
bool valido = n1 > n2 && 8 > 9;
Console.WriteLine(valido);

// || ou
bool valido2 = n1 > n2 || 8 > 9;
Console.WriteLine(valido2);

// ! não
bool valido3 = !(n2 > 10);
Console.WriteLine(valido3);
*/
/*
bool ativo = true;
string status = ativo == true ? "Cadastro Ativo": "Cadastro inativo";
Console.WriteLine(status);

string status2 = ativo != true ? "Cadastro Ativo": "Cadastro inativo";
Console.WriteLine(status2);
*/
/*
string NomeCompleto()
{
    string Nome1 = "Orlando";

    string Nome2 = "Oliveira";

    return Nome1 + " " + Nome2;
}

var Nome = NomeCompleto();

Console.WriteLine(Nome);
*/
/*
int SomaValores()
{
    int Valor1 = 1;
    int Valor2 = 6;    

    return Valor1 + Valor2;
}

var Soma = SomaValores();
Console.WriteLine(Soma);
*/

/*
int SomaValores (int a, int b)
{
    return a + b;
}

var Soma =  SomaValores(10,5);
Console.WriteLine(Soma);
*/

/*
string NomeIdade(string nome, int idade)
{
    return "Meu nome é " + nome + " e minha idade é " + idade;
}

var NM = NomeIdade("Orlando Santos de Oliveira",39);
Console.WriteLine(NM);
*/
/*
using System.Collections;

var arrayList = new ArrayList();
arrayList.Add(2);
arrayList.Add("Orlando");
arrayList.Add(true);

Console.WriteLine(arrayList[2]); // Acesso por indice
Console.WriteLine(arrayList[1]); // Acesso por indice
Console.WriteLine(arrayList[0]); // Acesso por indice

foreach(var item in arrayList) // Acessando toda a listas
{
    Console.WriteLine(item); 
}

arrayList.RemoveAt(1); // Remover item da lista

foreach(var item in arrayList) // Acessando toda a listas sem o indice 1
{
    Console.WriteLine(item); 
}

arrayList.Clear(); // Limpar a lista

foreach(var item in arrayList) // Acessando a lista limpa
{
    Console.WriteLine(item); 
}
*/

/*
var arrayTipadoNumero = new int [5] {2,8,16,20,30}; // Array tipado numero
var arrayTipadoNumero = new int [5];

arrayTipadoNumero[0] = 1;
arrayTipadoNumero[1] = 4;
arrayTipadoNumero[2] = 8;
arrayTipadoNumero[3] = 10;
arrayTipadoNumero[4] = 15;

foreach(var item in arrayTipadoNumero) // Acessando a lista
{
    Console.WriteLine(item); 
}


var arrayTipadoString = new string [3] {"oi", "tudo", "bem"}; // Array tipado string

foreach(var item in arrayTipadoString) // Acessando a lista
{
    Console.WriteLine(item); 
}
*/


/*
var lista = new List<string>(10)
{
    "Orlando","Oliveira"
};

var lista = new List<string>(10);
lista.Add("Orlando");
lista.Add("Oliveira");

var nome = lista[0];

Console.WriteLine(nome);

foreach(var item in lista)
{
    Console.WriteLine(item);
}
*/

/*
var dicionario = new Dictionary<int,string>(); // Intanciando o Dicionario

var dicionario = new Dictionary<int,string>() // Intanciando o Dicionario com valor
{
    {0, "Inicio"}
};

dicionario[1] = "Orlando"; // Add forma 1
dicionario.Add(2,"oliveira"); // Add Forma 2

foreach(var item in dicionario)
{
    Console.WriteLine(item);
}
*/
/*
var dicionario = new Dictionary<string,string>() // Intanciando o Dicionario com valor
{
    {"a", "Inicio"}
};

dicionario["b"] = "Orlando"; // Add forma 1
dicionario.Add("c","oliveira"); // Add Forma 2

foreach(var item in dicionario)
{
    Console.WriteLine(item);
}
*/

/*
var fila = new Queue<string>();

fila.Enqueue("Orlando"); // Add na fila
fila.Enqueue("Oliveira");

var nome = fila.Peek(); //Peek acessa sempre o primeiro da fila
var nome1 = fila.Peek();

Console.WriteLine(nome); 
Console.WriteLine(nome1);

var nome0 = fila.Dequeue(); //Dequeue remove o primeiro da fila
var nome2 = fila.Dequeue(); // nese caso como removeu já o primeiro ele irar remover o segundo

Console.WriteLine(nome0); 
Console.WriteLine(nome2);

*/

/*
var stack =  new Stack<string>();
stack.Push("Orlando");
stack.Push("Oliveira");

foreach(var item in stack)
{
    Console.WriteLine(item);
}

var nome = stack.Pop(); 
var nome1 = stack.Pop();

Console.WriteLine(nome); 
Console.WriteLine(nome1);
*/

/*
var notaProva =  10;
var Falta = 6;

if(notaProva >= 7 && Falta < 5)
{
    Console.WriteLine("Aprovado");
}
else if((notaProva >=5  && notaProva < 7)  && Falta < 5)
{
    Console.WriteLine("Em Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}
*/

/*

var dia = 9;

switch(dia)
{
    case 0:
    Console.WriteLine("Domigo");
    break;

    case 1:
    Console.WriteLine("Segunda");
    break;

    case 2:
    Console.WriteLine("Terça");
    break;

    case 3:
    Console.WriteLine("Quarta");
    break;

    case 4:
    Console.WriteLine("Quinta");
    break;

    case 5:
    Console.WriteLine("Sexta");
    break;

    case 6:
    Console.WriteLine("Sabado");
    break;

    default:
    Console.WriteLine("Codigo da Semana Invalido");
    break;
}
*/

/*
var lista = new List<string>() {"Orlando", "Santos", "Oliveira"};

for (var i=0; i< lista.Count; i++)
{
    var nome = lista[i];
    Console.WriteLine(nome);
}
*/

/*
var lista = new List<string>() {"Orlando", "Santos", "Oliveira"};

foreach (var item in lista)
{
    Console.WriteLine(item);
}
*/
/*
foreach (var letra in "lista")
{
    Console.WriteLine(letra);
}
*/

/*
var i = 3;

while(i < 2) //Validação, depois execução
{
    Console.WriteLine(i);
    i+=1;
}

var j = 3;

do //Execução, depois validação
{
    Console.WriteLine(j);
    j+=1;
}while(j < 2);
*/
/*
var i =0;
while(i<5)
{
    if(i<2)
    {
        Console.WriteLine("Continuando...");
        i++;
        continue;
    }

    Console.WriteLine("var i = " + i);
    i++;

    if(i ==2)
    {
        Console.WriteLine("Valor de i é igual a 2 (dois)");
        break;
    }
}
*/