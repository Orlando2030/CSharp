﻿/*
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


string NomeIdade(string nome, int idade)
{
    return "Meu nome é " + nome + " e minha idade é " + idade;
}

var NM = NomeIdade("Orlando Santos de Oliveira",39);
Console.WriteLine(NM);
