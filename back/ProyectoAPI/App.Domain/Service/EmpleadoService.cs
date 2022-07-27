using App.Common.DTO;
using App.Infrastructure.Database.Entities;
using App.Infrastructure.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service
{
    public interface IEmpleadoService
    {
        List<EmpleadoDTO> Listar();
        EmpleadoDTO Buscar(EmpleadoDTO dto);
        EmpleadoDTO Crear(EmpleadoDTO dto);
        EmpleadoDTO Actualizar(EmpleadoDTO dto);
    }
    public class EmpleadoService : IEmpleadoService
    {
        private IEmpleadoRepository _repository;
        private IMapper _mapper;
        public EmpleadoService(IEmpleadoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region Listar
        public List<EmpleadoDTO> Listar()
        {
            return _mapper.Map<List<EmpleadoDTO>>(_repository.Listar());
        }
        #endregion

        #region Buscar
        public EmpleadoDTO Buscar(EmpleadoDTO dto)
        {
            Empleado empleado = _mapper.Map<Empleado>(dto);
            empleado = _repository.Buscar(empleado);
            return _mapper.Map<EmpleadoDTO>(empleado);
        }
        //public EmpleadoDTO Buscar(int dto)
        //{
        //    Empleado empleado = _repository.Buscar(dto);
        //    return _mapper.Map<EmpleadoDTO>(empleado);
        //}
        #endregion

        #region Crear
        public EmpleadoDTO Crear(EmpleadoDTO dto)
        {
            Empleado empleado = _mapper.Map<Empleado>(dto);
            empleado = _repository.Crear(empleado);
            return _mapper.Map<EmpleadoDTO>(empleado);
        }
        #endregion

        #region Actualizar
        public EmpleadoDTO Actualizar(EmpleadoDTO dto)
        {
            Empleado empleado = _mapper.Map<Empleado>(dto);
            empleado = _repository.Actualizar(empleado);
            return _mapper.Map<EmpleadoDTO>(empleado); 
        }
        #endregion

    }
}
