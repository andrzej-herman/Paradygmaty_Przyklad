using Paraadymaty;

var ludzie = new List<Czlowiek>();

var m1 = new Mezczyzna("Adam", "Nowak", new DateTime(1943, 12, 13));
var k1 = new Kobieta("Anna", "Kowalska", new DateTime(2015, 04, 01));
var k2 = new Kobieta("Jadwiga", "Lewandowska", new DateTime(2000, 03, 04));
var m2 = new Mezczyzna("Piotr", "Boruc", new DateTime(1973, 05, 15));
var m3 = new Mezczyzna("Roman", "Polański", new DateTime(1992, 09, 01));

ludzie.Add(k1);
ludzie.Add(k2);

ludzie.Add(m1);
ludzie.Add(m2);
ludzie.Add(m3);

foreach (var l in ludzie)
{
	l.GenerujPesel();
	Console.WriteLine($"{l.Imie} {l.Nazwisko} | {l.Pesel}");
}



Console.ReadLine();