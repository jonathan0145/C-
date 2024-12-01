using WebAppApi.Model;

namespace WebAppApi.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly List<Empleado> _empleadosList; 
        public EmpleadoService()
        {
            _empleadosList = new List<Empleado>
            {
                new Empleado
                {
                        Id = 1,
                        Identificacion = "12345", 
                        Nombre = "Juan Rubio", 
                        HorasTrabajadas = 10,
                        SueldoPorHora = 100, 
                        IsActive = true
                }
            };
        }

        public Empleado AddEmpleado(AddUpdateEmpleado obj)
        {
            var newEmpleado = new Empleado
            {
                Id = _empleadosList.Any() ? _empleadosList.Max(emp => emp.Id) + 1 : 1,
                Identificacion = obj.Identificacion,
                Nombre = obj.Nombre,
                HorasTrabajadas = obj.HorasTrabajadas,
                SueldoPorHora = obj.SueldoPorHora,
                IsActive = obj.IsActive,
            };

            _empleadosList.Add(newEmpleado); 
            return newEmpleado;
        }

        public bool DeleteEmpleadoByID(int id)
        {
            var empleadoIndex = _empleadosList.FindIndex(emp => emp.Id == id);
            if (empleadoIndex >= 0)
            {
                _empleadosList.RemoveAt(empleadoIndex); 
                return true;
            }
            return false;
        }

        public List<Empleado> GetAllEmpleados(bool? isActive)
        {
            return isActive == null ? _empleadosList :
            _empleadosList.Where(emp => emp.IsActive == isActive).ToList();
        }

        public Empleado? GetEmpleadoByID(int id)
        {           
            return _empleadosList.FirstOrDefault(emp => emp.Id == id);
        }
       
       public Empleado? UpdateEmpleado(int id, AddUpdateEmpleado obj)
        {
            var empleado = _empleadosList.FirstOrDefault(emp => emp.Id == id);
            if (empleado == null) return null;

            empleado.Identificacion = obj.Identificacion; 
            empleado.Nombre = obj.Nombre; 
            empleado.HorasTrabajadas = obj.HorasTrabajadas; 
            empleado.SueldoPorHora = obj.SueldoPorHora; 
            empleado.IsActive = obj.IsActive;

            return empleado;
        }

    }
}