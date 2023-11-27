Console.WriteLine("---Entrada Valida---");

int numero = -1;

while (numero < 0 || numero > 9)
{
    Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar)...: ");
    numero = Convert.ToInt32(Console.ReadLine());
}
 
Console.WriteLine();
 
if (numero == 0)
{
    Console.WriteLine("Operação cancelada.\n");
}
 
else {
    Console.WriteLine($"Número selecionado = {numero}.");
}
 
Console.WriteLine("Volte sempre!\n");
