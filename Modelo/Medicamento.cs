using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Medicamento:Entity
    {
        public string NombreComercial { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public bool EsVentaLibre { get; set; }

        private List<Drogueria> droguerias;  // *Relación a muchas droguerias* //
        public Monodroga Monodroga { get; set; } // *Relación a una monodroga* //


        public Medicamento()
        {
            droguerias = new List<Drogueria>();
        }

        public IReadOnlyCollection<Drogueria> Droguerias
        {
            get => droguerias.AsReadOnly();
        }

        public bool AgregarDrogueria(Drogueria drogueria) // método para agregar una Droguería al Medicamento
        {
            try
            {
                var drogueriaExistente = droguerias.FirstOrDefault(d => d.Cuit == drogueria.Cuit); // sólo se agrega si la Droguería que quiero agregar no existe
                if (drogueriaExistente == null)
                {
                    droguerias.Add(drogueria);
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }
        public bool EliminarDrogueria(Drogueria drogueria)
        {
            try
            {
                var drogueriaExistente = droguerias.FirstOrDefault(d => d.Cuit == drogueria.Cuit);
                if (drogueriaExistente != null)
                {
                    droguerias.Remove(drogueria);
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
