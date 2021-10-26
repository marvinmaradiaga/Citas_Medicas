using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Citas
{
    public class MedicamentosBL
    {
        Contexto _contexto;
        public BindingList<Medicamento> ListaMedicamentos { get; set; }
        /*Añadiendo la Lista de Medicamentos*/
        public MedicamentosBL()
        {
            _contexto = new Contexto();
            ListaMedicamentos = new BindingList<Medicamento>();

        }

        public BindingList<Medicamento> ObtenerMedicamentos()
        {
            _contexto.Medicamentos.Load();
            ListaMedicamentos = _contexto.Medicamentos.Local.ToBindingList();
            return ListaMedicamentos;
        }

         // Creando la Funcion Guardar medicamentos.

        public Resultado GardarMedicamentos(Medicamento medicamento)
        {
            var resultado = Validar(medicamento);
            if(resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }
        // Creando la funcion agregar
        public void AgregarMedicamento()
        {
            var nuevoMedicamento = new Medicamento();
            ListaMedicamentos.Add(nuevoMedicamento);
        }

        // Creando la funcion Eliminar.
        public bool EliminarMedicamento(int id)
        {
            foreach (var medicamento in ListaMedicamentos)
            {
                if (medicamento.Id == id)
                {
                    ListaMedicamentos.Remove(medicamento);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }
        // Validando
        private Resultado Validar (Medicamento medicamento)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if(string.IsNullOrEmpty(medicamento.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;
            }

            if (medicamento.Existencia <= 0 )
            {
                resultado.Mensaje = "La existencia debe ser mayor que 0";
                resultado.Exitoso = false;
            }
            if (medicamento.Precio <= 0)
            {
                resultado.Mensaje = "El precio debe ser mayor que 0";
                resultado.Exitoso = false;
            }
            return resultado;
        }
    }

    public  class Medicamento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }  

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
