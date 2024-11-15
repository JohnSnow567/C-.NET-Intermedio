using BusManagement__Refactoring_Generics_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagement__Refactoring_Generics_.Interfaces
{
    public interface IAsientoRepository<T> where T : class
    {
        void Agregar(T entity);
        void Actualizar(T entity);
        void Remover(T entity);
        List<T> TraerTodos();
        T ObtenerPorId(int id);
    }
}
