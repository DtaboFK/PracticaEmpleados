using App.Infrastructure.Base;
using App.Infrastructure.Database;
using App.Infrastructure.Database.Entities;
using System.Linq;

namespace App.Infrastructure.Repositories
{
    public interface IEmpleadoRepository : IBaseRepository<Empleado>
    {
        IQueryable<Empleado> Listar();
        Empleado Buscar(Empleado id);
        Empleado Crear(Empleado empleado);
        Empleado Actualizar(Empleado empleado);
    }
    public class EmpleadoRepository : BaseRepository<Empleado>, IEmpleadoRepository
    {
        public EmpleadoRepository(DataContext database) : base(database)
        {
        }

        #region Listar
        public IQueryable<Empleado> Listar()
        {
            return _table;
        }
        #endregion

        #region Buscar
        public Empleado Buscar(Empleado id)
        {
            var userId = CastPrimaryKey(id);
            return _table.Find(userId);
        }
        //public Empleado Buscar(int id)
        //{
        //    Empleado empleado = _table.Where(item => item.IdEmpleado == id);
        //    return _table.Find(userId);
        //}
        #endregion

        #region Crear
        public Empleado Crear(Empleado empleado)
        {
            _table.Add(empleado);
            _database.SaveChanges();
            return empleado;
        }
        #endregion

        #region Actualizar
        public Empleado Actualizar(Empleado empleado)
        {
            if (empleado == null)
            {
                return null;
            }
            Empleado ObjEmpleado = _table.Find(GetValuePrimaryKey(empleado));
            if (ObjEmpleado != null)
            {
                _database.Entry(ObjEmpleado).CurrentValues.SetValues(empleado);
                _database.SaveChanges();
            }
            return ObjEmpleado;
        }
        #endregion

    }
}
