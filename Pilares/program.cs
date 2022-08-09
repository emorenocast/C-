using System;

namespace animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro p = new Perro();
            Console.WriteLine("***Perro***");
            p.Nombre = "Firulais";
            p.Patas = 4;
            p.EsDomestico = true;
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();

            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);

            Console.WriteLine();

            Gato g = new Gato();
            Console.WriteLine("***Gato***");
            g.Nombre = "Loki";
            g.Patas = 4;
            g.Pelaje = "Peludo";
            g.Raza = "Persa";
            g.Comer();
            g.Caminar();
            g.Maullar();
            g.EsAmargado = true;

            Console.WriteLine(g.Nombre);
            Console.WriteLine(g.Patas);
            Console.WriteLine(g.Pelaje);
            Console.WriteLine(g.Raza);         

            Console.WriteLine();

            Mono m = new Mono();
            Console.WriteLine("***Mono***");
            m.Nombre = "Monkey";
            m.Patas = 4;
            m.Orden = "Primates";
            m.Reproduccion = "Viviparo";
            m.Comer();
            m.SonSalvajes = true;
            m.Caminar();
            m.Aullar();

            Console.WriteLine(m.Nombre);
            Console.WriteLine(m.Patas);
            Console.WriteLine(m.Orden);
            Console.WriteLine(m.Reproduccion);

            Console.WriteLine();

            Aguila a = new Aguila();
            Console.WriteLine("***Aguila***");
            a.Nombre = "Spencer";
            a.Patas = 2;
            a.PIncubacion = 20;
            a.ColorPlumaje = "Cafe";
            a.Volar();
            a.Comer();
            a.Carnivora();

            Console.WriteLine(a.Nombre);
            Console.WriteLine(a.PIncubacion);
            Console.WriteLine(a.Patas);
            Console.WriteLine(a.ColorPlumaje);

            Console.WriteLine();

            Loro l = new Loro();
            Console.WriteLine("***Loro***");
            l.Nombre = "Paco";
            l.Patas = 2;
            l.ColorPlumaje = "Verde";
            l.Comer();
            l.Volar();
            l.Hablan();
            l.Pico();

            Console.WriteLine(l.Nombre);
            Console.WriteLine(l.Patas);
            Console.WriteLine(l.ColorPlumaje);

            Console.WriteLine();

            PezGlobo x = new PezGlobo();
            Console.WriteLine("***Pez Globo***");
            x.Nombre = "Lupe";
            x.Piel = "Aspera";
            x.NumeroAletas = 2;
            x.Comer();
            x.Nadar();
            x.Color = "Amarillo Verdoso";
            x.Venenosa();
            x.Inflarse();

            Console.WriteLine(x.Nombre);
            Console.WriteLine(x.NumeroAletas);
            Console.WriteLine(x.Piel);
            Console.WriteLine(x.Color);
            }
        }
}
