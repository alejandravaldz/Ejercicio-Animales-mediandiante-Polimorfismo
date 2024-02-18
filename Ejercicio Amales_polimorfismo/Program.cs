
// See https://aka.ms/new-console-template for more information
using Ejercicio_Amales_polimorfismo;
Console.WriteLine("Sonido de animales");
Console.WriteLine();


Console.WriteLine("El perro puede emitir este sonido");
Console.WriteLine(); 
Animal animal = new Perro();
animal.HacerSonido();
Console.WriteLine();
Console.WriteLine();

animal = new Gato();
Console.WriteLine("El Gato puede emitir este sonido:");
Console.WriteLine();
animal.HacerSonido();




