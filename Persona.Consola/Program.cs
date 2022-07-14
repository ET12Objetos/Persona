using Persona.Biblioteca;

Console.Write("Ingrese Nombre: ");
string nombre = Console.ReadLine();
Console.Write("Ingrese Edad: ");
int edad = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese Peso: ");
float peso = float.Parse(Console.ReadLine());
Console.Write("Ingrese Altura: ");
float altura = float.Parse(Console.ReadLine());

//caso 1
//Persona1 persona = new Persona1(nombre, edad, peso, altura);

//caso 2
//var persona = new Persona1(nombre, edad, peso, altura);

//caso 3
Persona1 persona = new(nombre, edad, peso, altura);

Console.WriteLine($"El estado de peso de {persona.Nombre} es {persona.CualEsTuIMC()}");
string estado = persona.EsMayorDeEdad() ? "Si" : "No";
Console.WriteLine($"Es mayor de edad: {estado}");
Console.WriteLine(persona.ToString());
