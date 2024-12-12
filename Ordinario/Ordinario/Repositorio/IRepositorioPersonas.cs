using Ordinario.Modelos;

namespace Ordinario.Repositorio
{
    public interface IRepositorioPersonas
    {
        Task<List<Persona>> GetAll();
        Task<Persona?> Get(int id);
        Task<Persona> Add(Persona persona);
        Task Update(int id, Persona persona);
        Task Delete(int id);
        //Interfaz Clasificaciones
        Task<List<Clasificacion>> GetClasificaciones();
        Task DeleteClasificacion(int id);
        Task UpdateClasificacion(int id, Clasificacion clasificacion);
        Task<Clasificacion> AddClasificacion(Clasificacion clasificacion);
    }
}
