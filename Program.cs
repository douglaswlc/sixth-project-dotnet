
// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 79;
// arrayInteiros[1] = 44;
// arrayInteiros[2] = 42;


// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// // Percorrendo o array com o FOR
// Console.WriteLine("Percorrendo o array com o FOR");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//   Console.WriteLine($"Posição nº {contador} - {arrayInteiros[contador]}");
// }

// // Percorrendo o array com o FOREACH 
// Console.WriteLine("Percorrendo o array com o FOREACH");
// foreach(int valor in arrayInteiros)
// {
//   Console.WriteLine(valor);
// };


List<string> listaString = ["SP", "BA", "MG", "RJ", "ES"];

Console.WriteLine("Percorrendo a lista com o FOR");
for (int contador = 0; contador < listaString.Count; contador++)
{
  Console.WriteLine($"Posição nº {contador} - {listaString[contador]}");
}

Console.WriteLine("Percorrendo a lista com o FOREACH");
int contadorForeach = 0;
foreach(string item in listaString)
{
  Console.WriteLine($"Posição nº {contadorForeach} - {item}");
  contadorForeach++;
}