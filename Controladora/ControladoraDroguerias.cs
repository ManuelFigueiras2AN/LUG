using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraDroguerias
    {
        private Context _context;

        public ControladoraDroguerias() 
        {
            _context = new Context();
        }



        //---------------------------------- //------------ -*ABM*- -*DROGUERIA*- -------------// ------------------------------//



        public bool AgregarDrogueria(Drogueria drogueria)
        {
            try
            {
                var drogueriaExiste = _context.Droguerias.FirstOrDefault(d => d.Cuit == drogueria.Cuit);
                if (drogueriaExiste == null)
                {
                    _context.Droguerias.Add(drogueria);
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


        public bool EliminarDrogueria(Drogueria drogueria)
        {
            try
            {
                var drogueriaExiste = _context.Droguerias.FirstOrDefault(d => d.Cuit == drogueria.Cuit);
                if (drogueriaExiste != null)
                {
                    _context.Droguerias.Remove(drogueria);
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


        public bool ModificarDrogueria(Drogueria drogueria)
        {
            try
            {

                var drogueriaExiste = _context.Droguerias.FirstOrDefault(d => d.Cuit == drogueria.Cuit);
                if (drogueriaExiste != null)
                {
                    _context.Droguerias.Update(drogueria);
                    _context.SaveChanges();

                    return true;
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


        //---------------------------------- //------------ -*MÉTODOS*- -*DROGUERIA*- -------------// ------------------------------//

        public List<Drogueria> ListarDroguerias()
        {
            return _context.Droguerias.ToList();
        }


    }
}
