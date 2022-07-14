namespace Persona.Biblioteca;
public class Persona1
{
    public string Nombre { get; private set; }
    public int Edad { get; private set; }
    public float Peso { get; private set; }
    public float Altura { get; private set; }
    public Persona1(string nombre, int edad, float peso, float Altura)
    {
        this.Nombre = nombre;
        this.Edad = edad;
        this.Peso = peso;
        this.Altura = Altura;
    }

    public string CualEsTuIMC()
    {
        float imc = IMC();

        if (imc < 18.5)
            return "Bajo peso";
        else
            if (imc >= 18.5 && imc < 25)
            return "Peso ideal";
        else
            return "Sobrepeso";
    }

    private float IMC() => this.Peso / (this.Altura * this.Altura);

    public bool EsMayorDeEdad()
    {
        // if (this.Edad >= 18)
        //     return true;
        // else
        //     return false;

        // if (this.Edad >= 18)
        //     return true;

        // return false;

        return this.Edad >= 18 ? true : false;
    }

    [Obsolete("Método no respeta la responsabilidad de la clase")]
    public void Informar()
    {
        Console.WriteLine($"Nombre: {this.Nombre}");
        Console.WriteLine($"Edad: {this.Edad}");
        Console.WriteLine($"Peso: {this.Peso}, Altura: {this.Altura}");
    }

    public override string ToString()
    {
        return $"Nombre: {this.Nombre}, Edad: {this.Edad}, Peso: {this.Peso}, Altura: {this.Altura}";
    }
}
