using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraMonodrogas
    {
        private Context _context;

        public ControladoraMonodrogas() 
        {
            _context = new Context();
        }


        //------------------------------ //------------ -*ABM*- -*MONODROGAS*- -------------// ------------------------------//


        public bool AgregarMonodroga(Monodroga monodroga)
        {
            try
            {
                var monodrogaExiste = (_context.Monodrogas.FirstOrDefault(m => m.Nombre == monodroga.Nombre));
                if (monodrogaExiste == null)
                {
                    _context.Monodrogas.Add(monodroga);
                    _context.SaveChanges();
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EliminarMonodroga(Monodroga monodroga)
        {
            try
            {
                var monodrogaExiste = _context.Monodrogas.FirstOrDefault(m => m.Nombre == monodroga.Nombre);
                if (monodrogaExiste != null)
                {
                    _context.Monodrogas.Remove(monodroga);
                    _context.SaveChanges();

                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool EditarMonodroga(Monodroga monodroga)
        {
            try
            {
                var monodrogaExiste = _context.Monodrogas.FirstOrDefault(m => m.Nombre == monodroga.Nombre);

                if (monodrogaExiste == null)
                {
                   _context.Monodrogas.Update(monodroga);
                   return _context.SaveChanges() > 0;
                }
                else
                {
                  return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        //------------------------------ //------------ -*MÉTODOS*- -*MONODROGAS*- -------------// ------------------------------//


        public List<Monodroga> ListarMonodrogas()
        {
            return _context.Monodrogas.ToList();
        }
    }
}
