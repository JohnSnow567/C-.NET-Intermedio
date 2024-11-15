using BusManagement__Refactoring_Generics_.Entities;
using BusManagement__Refactoring_Generics_.Repository;

class Program
{
    static void Main(string[] args)
    {
        var asientoRepository = new AsientoRepository<Asiento>();

        // Creacion de nuevo objeto de la clase
        Asiento newAsiento = new Asiento { AsientoId = 1, BusId = 101, NumeroPiso = 1, NumeroAsiento = 20, FechaCreacion = DateTime.Now };

        //Añadir el objeto a la lista
        asientoRepository.Agregar(newAsiento);

        Console.ReadKey();

        //Trae a todos las clases registradas
        var asientotraer = asientoRepository.TraerTodos();
        Console.WriteLine(asientotraer);
        Console.ReadKey();

        //Obtiene a una clase registrada por id
        var asiento = asientoRepository.ObtenerPorId(1);
        Console.WriteLine(asiento);
        Console.ReadKey();

        //Remueve a la clase asignada
        asientoRepository.Remover(newAsiento);
        Console.ReadKey();
    }
}