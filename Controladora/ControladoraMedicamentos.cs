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
    public class ControladoraMedicamentos
    {
        private Context _context;

        public ControladoraMedicamentos() 
        {
            _context = new Context();
        }



        //---------------------------------- //------------ -*ABM*- -*MEDICAMENTOS*- -------------// ------------------------------//

        public bool AgregarMedicamento(Medicamento medicamento)
        {
            try
            {
                var medicamentoExiste = _context.Medicamentos.FirstOrDefault(m => m.NombreComercial == medicamento.NombreComercial);
                if (medicamentoExiste == null)
                {
                    _context.Medicamentos.Add(medicamento);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool EliminarMedicamento(Medicamento medicamento)
        {
            try
            {
                var medicamentoExiste = _context.Medicamentos.FirstOrDefault(m => m.NombreComercial == medicamento.NombreComercial);
                if (medicamentoExiste != null)
                {
                    _context.Medicamentos.Remove(medicamento);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ModificarMedicamento(Medicamento medicamento)
        {
            try
            {
                var medicamentoExiste = _context.Medicamentos.FirstOrDefault(m => m.NombreComercial == medicamento.NombreComercial);
               
                if (medicamentoExiste != null)
                {
                    // Actualizar la entidad `Monodroga` si es diferente
                    if (medicamentoExiste.Monodroga != medicamento.Monodroga)
                    {
                        _context.Entry(medicamentoExiste.Monodroga).State = EntityState.Detached;
                        _context.Attach(medicamento.Monodroga);
                        medicamentoExiste.Monodroga = medicamento.Monodroga;
                    }

                    _context.Entry(medicamentoExiste).CurrentValues.SetValues(medicamento);
                    _context.SaveChanges();
                    //_context.Medicamentos.Update(medicamentoExiste);
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //---------------------------------- //------------ -*MÉTODOS*- -*MEDICAMENTOS*- -------------// ------------------------------//

        public ReadOnlyCollection<Monodroga> ListarMonodrogas()
        {
            try
            {
                return _context.Monodrogas.ToList().AsReadOnly();
            }
            catch
            {
                return new ReadOnlyCollection<Monodroga>(new List<Monodroga>());
            }

        }

        public List<Medicamento> RecuperarMedicamentosDroguerias()
        {
            return _context.Medicamentos.Include(m => m.Droguerias).ToList();
        }

        public ReadOnlyCollection<Drogueria> ListarDroguerias()
        {
            try
            {
                return _context.Droguerias.ToList().AsReadOnly();
            }
            catch
            {
                return new ReadOnlyCollection<Drogueria>(new List<Drogueria>());
            }
        }

        public List<Medicamento> ListarMedicamentos()
        {
            try
            {
                return _context.Medicamentos.Include(m => m.Monodroga).ToList();
            }
            catch
            {
                return new List<Medicamento>();
            }
        }
    }
}
