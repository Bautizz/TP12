using System;

class Program
{
    static void Main()
    {
       
        Rectangulo r1 = new Rectangulo();
        Rectangulo r2 = new Rectangulo(5);
        Rectangulo r3 = new Rectangulo(4, 8);

      
        Persona p1 = new Persona { Nombre = "Ana" };
        Persona p2 = new Persona { Nombre = "Carlos" };
        Console.WriteLine($"{p1.Id} - {p1.Nombre}");
        Console.WriteLine($"{p2.Id} - {p2.Nombre}");

       
        Fraccion f1 = new Fraccion(3, 4);
        Fraccion f2 = new Fraccion(5);
        Console.WriteLine($"{f1.Numerador}/{f1.Denominador}");
        Console.WriteLine($"{f2.Numerador}/{f2.Denominador}");

        // 6. Demostración de constructor por defecto
        EjemploDefault ej = new EjemploDefault();

      
        Jugador j = new Jugador("Bauti");
        j.Mover(1, 0).Atacar();

        Singleton s = Singleton.Instancia;

        
        Config cfg = new Config();
        Console.WriteLine($"{cfg.ModoOscuro} - {cfg.Idioma}");
    }
}


public class Rectangulo
{
    public double Ancho { get; }
    public double Alto { get; }

    public Rectangulo() : this(1, 1) { }

    public Rectangulo(double lado) : this(lado, lado) { }

    public Rectangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }
}


public class Persona
{
    private static int _contadorId = 0;
    public int Id { get; }
    public string Nombre { get; set; }

    public Persona()
    {
        _contadorId++;
        Id = _contadorId;
    }
}


public class Fraccion
{
    public int Numerador { get; }
    public int Denominador { get; }

    public Fraccion(int num, int den)
    {
        if (den == 0)
        {
            throw new ArgumentException("El denominador no puede ser 0.");
        }
        Numerador = num;
        Denominador = den;
    }

    public Fraccion(int num) : this(num, 1) { }
}


public class EjemploDefault
{
    public int Valor { get; set; } = 10;
}


public class Jugador
{
    private string nombre;

    public Jugador(string nombre)
    {
        this.nombre = nombre;
    }

    public Jugador Mover(int x, int y)
    {
        return this;
    }

    public Jugador Atacar()
    {
        return this;
    }
}


public class Singleton
{
    private static Singleton _instancia;

    private Singleton() { }

    public static Singleton Instancia
    {
        get
        {
            if (_instancia == null)
            {
                _instancia = new Singleton();
            }
            return _instancia;
        }
    }
}


public class Config
{
    public bool ModoOscuro { get; set; }
    public string Idioma { get; set; }

    public Config()
    {
        ModoOscuro = true;
        Idioma = "Español";
    }
}