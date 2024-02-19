
// See https://aka.ms/new-console-template for more information
using Ejercicio_Amales_polimorfismo;
Console.WriteLine("Sonido de animales");
Console.WriteLine();


Animal animal;

Console.WriteLine("El perro puede emitir este sonido");

Console.WriteLine();

animal = new Perro();
animal.HacerSonido();

Console.WriteLine();

Console.WriteLine();

Console.WriteLine("El Gato puede emitir este somido");

Console.WriteLine();

animal = new Gato();
animal.HacerSonido(); 




