using System.Text;
using _02_SuperHeroesApp.Models;

// Creación de instancias de superpoder

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire.";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Descripcion = "Fuerza sobrehumana.";
superFuerza.Nivel = NivelPoder.NivelTres;

var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneración";
regeneracion.Descripcion = "Capacidad de regenerar heridas rápidamente.";
regeneracion.Nivel = NivelPoder.NivelTres;

var superman = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "   Superman   ";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

var superman2 = new SuperHeroe();

superman2.Id = 1;
superman2.Nombre = "Superman";
superman2.IdentidadSecreta = "Clark Kent";
superman2.Ciudad = "Metropolis";
superman2.PuedeVolar = true;

Console.WriteLine(superman == superman2);

SuperHeroeRecord supermanRecord = new SuperHeroeRecord(1, "Superman", "Clark Kent");
SuperHeroeRecord supermanRecord2 = new SuperHeroeRecord(1, "Superman", "Clark Kent");

Console.WriteLine(supermanRecord == supermanRecord2);

// Asignación de superpoderes a un listado
List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);

// Asignando la lista al superhéroe
superman.SuperPoderes = poderesSuperman;

string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);
string resultdoSalvarMundo = superman.SalvarElMundo();
Console.WriteLine(resultdoSalvarMundo);

string resultSalvarTierra = superman.SalvarLaTierra();
Console.WriteLine(resultSalvarTierra);

var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;

// Asignación de superpoderes a un listado
List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superFuerza);

// Asignando la lista al superhéroe
wolverine.SuperPoderes = poderesWolverine;

string resultWolverinePoderes = wolverine.UsarSuperPoderes();
Console.WriteLine(resultWolverinePoderes);

string accionAntiHeroe = wolverine.RealizarAccionDeAntiHeroe("Atacar la policia");
Console.WriteLine(accionAntiHeroe);
string resultdoSalvarMundo2 = wolverine.SalvarElMundo();
Console.WriteLine(resultdoSalvarMundo2);

enum NivelPoder
{ 
    NivelUno,
    NivelDos,
    NivelTres
}

public record SuperHeroeRecord(int Id, string Nombre, string IdentidadSecreta);