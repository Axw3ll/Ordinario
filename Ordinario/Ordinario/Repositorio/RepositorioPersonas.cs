using Microsoft.EntityFrameworkCore;
using Ordinario.Modelos;

namespace Ordinario.Repositorio
{
    public class RepositorioPersonas : IRepositorioPersonas
    {
        private readonly CatalogoDBContext _context;

        public RepositorioPersonas(CatalogoDBContext context)
        {
            _context = context;
        }

        public async Task<Persona> Add(Persona persona)
        {
            await _context.Personas.AddAsync(persona);
            await _context.SaveChangesAsync();
            return persona;
        }

        public async Task Delete(int id)
        {
            var persona = await _context.Personas.FindAsync(id);
            if (persona != null)
            {
                _context.Personas.Remove(persona);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteClasificacion(int id)
        {
            var clasificacion = await _context.Clasificaciones.FindAsync(id);
            if(clasificacion != null)
            {
                _context.Clasificaciones.Remove(clasificacion);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Persona?> Get(int id)
        {
            return await _context.Personas.FindAsync(id);
        }

        public async Task<List<Persona>> GetAll()
        {
            return await _context.Personas.ToListAsync();
        }
        //public async Task<List<Persona>> GetAll()
        //{
        //   return await _context.Personas.Include(c => c.Clasificacion).ToListAsync();
        //}

        public async Task<List<Clasificacion>> GetClasificaciones()
        {
            return await _context.Clasificaciones.ToListAsync();
        }

        public async Task Update(int id, Persona persona)
        {
            var personaactual = await _context.Personas.FindAsync(id);
            if (personaactual != null)
            {
                personaactual.Nombre = persona.Nombre;
                personaactual.Correo = persona.Correo;
                personaactual.Telefono = persona.Telefono;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateClasificacion(int id, Clasificacion clasificacion)
        {
            var clasificacionActual = await _context.Clasificaciones.FindAsync(id);
            if(clasificacionActual != null)
            {
                clasificacionActual.Nombre = clasificacion.Nombre;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Clasificacion> AddClasificacion(Clasificacion clasificacion)
        {
            await _context.Clasificaciones.AddRangeAsync(clasificacion);
            await _context.SaveChangesAsync();
            return clasificacion;
        }
    }
}

