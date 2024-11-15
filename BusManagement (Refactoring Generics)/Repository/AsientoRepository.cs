using BusManagement__Refactoring_Generics_.Entities;
using BusManagement__Refactoring_Generics_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagement__Refactoring_Generics_.Repository
{
    public class AsientoRepository<T> : IAsientoRepository<T> where T : class
    {
        private List<T> _entities = new List<T>();

        public void Agregar(T entity)
        {
            _entities.Add(entity);
        }

        public void Actualizar(T entity)
        {
            //
        }

        public void Remover(T entity)
        {
            _entities.Remove(entity);
        }

        public List<T> TraerTodos()
        {
            return _entities;
        }

        public T ObtenerPorId(int id)
        {
            return _entities.FirstOrDefault(e => ((dynamic)e).AsientoId == id);
        }
    }
}
