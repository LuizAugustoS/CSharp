// Aula Diego 04/07/24
/*List<string> nomes = new List<string> { "Antonio", "Highor", "Cleber", "Natalia", "Gabriel", "Michele", "Luiz", "PH", "Guilherme" };

Console.WriteLine($"Lista de nomes: {String.Join(',', nomes.Where(no => no.StartsWith('G')).OrderByDescending(no => no))}");
*/
// Lista de Exercicios - C#
/* 1: Estoque Medio
Console.Write("Insira o nome da peça: ");
string peca = Console.ReadLine();
Console.WriteLine("Insira a quantidade MINIMA: ");
double quantidadeMinima = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a quantidade MAXIMA: ");
double quantidadeMaxima = double.Parse(Console.ReadLine());
double estoqueMedio = ((quantidadeMinima + quantidadeMaxima) / 2);
Console.WriteLine($"O estoque médio da peça {peca} é: {estoqueMedio}");
*/
/* 2: Cotação do dolar
Console.WriteLine("Informe a cotação do dolar: ");
double cotacao = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor em dólares: ");
double valorDolar = double.Parse(Console.ReadLine());
double valorReal = cotacao * valorDolar;
Console.WriteLine($"O valor {valorDolar} em real é: {valorReal}");
*/

/* 3: Comissao do vendedor
 Console.Write("Informe o nome do vendedor: ");
string nomeVendedor = Console.ReadLine();
Console.Write("Informe o código da peça: ");
int codigoPeca = int.Parse(Console.ReadLine());
Console.Write("Informe o valor unitario da peça: ");
double valorUnitario = double.Parse(Console.ReadLine());
Console.Write("Informe a quantidade vendida: ");
double quantidade = double.Parse(Console.ReadLine());
double comissao = 0.05;
double valorTotal = quantidade * valorUnitario;
double comissaoTotal = comissao * valorTotal;
comissaoTotal = Math.Round(comissaoTotal, 3);
Console.WriteLine($"O valor da comissão de venda o item {codigoPeca}, para o vendedor {nomeVendedor} é: {comissaoTotal}", 3);
*/

/*4: Soma e multiplicação de numeros inteiros
    Console.Write("Informe o primeiro valor:");
int valor1 = int.Parse(Console.ReadLine());
Console.Write("Informe o segundo valor:");
int valor2 = int.Parse(Console.ReadLine());
Console.Write("Informe o terceiro valor:");
int valor3 = int.Parse(Console.ReadLine());
Console.Write("Informe o quarto valor:");
int valor4 = int.Parse(Console.ReadLine());
int soma1 = valor1 + valor2;
int soma2 = valor1 + valor3;
int soma3 = valor1 + valor4;
int soma4 = valor2 + valor3;
int soma5 = valor2 + valor4;
    int soma6 = valor3 + valor4;

int mult1 = valor1 * valor2;
int mult2 = valor1 * valor3;
int mult3 = valor1 * valor4;
int mult4 = valor2 * valor3;
int mult5 = valor2 * valor4;
int mult6 = valor3 * valor4;
Console.WriteLine($"A soma de A com B = {soma1} e A com C = {soma2}");
Console.WriteLine($"A soma de A com D = {soma3} e B com C = {soma4}");
Console.WriteLine($"A soma de B com D = {soma5} e C com D = {soma6}");

Console.WriteLine($"A multiplicação de A com B = {mult1} e A com C = {mult2}");
Console.WriteLine($"A multiplicação de A com D = {mult3} e B com C = {mult4}");
Console.WriteLine($"A multiplicação de B com D = {mult5} e C com D = {mult6}");
*/

/* 5: Calculo de litros consumidos
 float tempoGasto = float.Parse(Console.ReadLine());
Console.WriteLine("Informe a velocidade Média:");
float velocidadeMedia = float.Parse(Console.ReadLine());
float distancia = tempoGasto * velocidadeMedia;
float litrosUsados = distancia / 12;
Console.WriteLine($"Sua velocidade média foi: {velocidadeMedia}, tempo gasto: {tempoGasto}, distância percorrida: {distancia} e consumo: {litrosUsados}");
*/


/* 6: Celsius para Fahrenheit 
Console.WriteLine("Insira uma temperatura em graus Celsius:");
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = (9 * celsius + 160) / 5;
Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}");
*/

/* 7: Fahrenheit para Celsius
Console.WriteLine("Insira uma temperatura em Fahrenheit:");
double fahrenheit = double.Parse(Console.ReadLine());
double celsius = (fahrenheit - 32) * 5 / 9;
Console.WriteLine($"A temperatura em graus Celsius é: {celsius}");
*/

/* 8: Volume da lata
Console.WriteLine("Insira o raio da lata:");
double raio = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a altura da lata:");
double altura = double.Parse(Console.ReadLine());
double volume = 3.14159 * raio * raio * altura;
volume = Math.Round(volume, 4);
Console.WriteLine($"O volume da lata é: {volume}");
*/

/* 9: Idade em dias
Console.Write("Insira os ANOS de sua idade:");
int anos = int.Parse(Console.ReadLine());
Console.Write("Insira os MESES de sua idade");
int meses = int.Parse(Console.ReadLine());
Console.Write("Insira os DIAS de sua idade:");
int dias = int.Parse(Console.ReadLine());
int diasTotais = (anos * 365) + (meses * 30) + dias;
Console.WriteLine($"A sua idade, em dias, é: {diasTotais}");
*/

/* 10: Relacionamento de ordem
Console.Write("Insira um numero inteiro:");
int numero1 = int.Parse(Console.ReadLine());
Console.Write("Insira outro numero inteiro:");
int numero2 = int.Parse(Console.ReadLine());
if (numero1 == numero2)
{
    Console.WriteLine("Os numeros são iguais");
} else if (numero1 != numero2)
{
    Console.WriteLine("Os numeros não são iguais");
}
if (numero1 > numero2)
{
    Console.WriteLine($"O numero {numero1} é MAIOR que o numero {numero2}");
} else if (numero1 < numero2)
{
    Console.WriteLine($"O numero {numero1} é MENOR que o numero {numero2}");

}
if (numero1 >= numero2)
{
    Console.WriteLine($"O numero {numero1} é MAIOR OU IGUAL ao numero {numero2}");
} else if (numero1 <= numero2)
{
    Console.WriteLine($"O numero {numero1} é MENOR OU IGUAL ao numero {numero2}");
}
*/