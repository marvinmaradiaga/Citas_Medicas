using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Citas
{
    public class MedicamentosBL
    {
        public BindingList<Medicamento> ListaMedicamentos { get; set; }
        /*Añadiendo la Lista de Medicamentos*/
        public MedicamentosBL()
        {
            ListaMedicamentos = new BindingList<Medicamento>();

            var medicamento1 = new Medicamento();
            medicamento1.Id = 1;
            medicamento1.Descripcion = "Panadol Ultra";
            medicamento1.Precio = 15;
            medicamento1.Existencia = 100;
            medicamento1.Activo = true;

            ListaMedicamentos.Add(medicamento1);


            var medicamento2 = new Medicamento();
            medicamento2.Id = 2;
            medicamento2.Descripcion = "Aspirinas";
            medicamento2.Precio = 20;
            medicamento2.Existencia = 33;
            medicamento2.Activo = true;

            ListaMedicamentos.Add(medicamento2);

            var medicamento3 = new Medicamento();
            medicamento3.Id = 3;
            medicamento3.Descripcion = "IMMUVIT vitaminas";
            medicamento3.Precio = 350;
            medicamento3.Existencia = 65;
            medicamento3.Activo = true;

            ListaMedicamentos.Add(medicamento3);

            var medicamento4 = new Medicamento();
            medicamento4.Id = 4;
            medicamento4.Descripcion = "Ibuprofeno";
            medicamento4.Precio = 5;
            medicamento4.Existencia = 100;
            medicamento4.Activo = true;

            ListaMedicamentos.Add(medicamento4);
        }

        public BindingList<Medicamento> ObtenerMedicamentos()
        {
            return ListaMedicamentos;
        }

         // Creando la clase Guardar medicamentos.

        public Resultado GardarMedicamentos(Medicamento medicamento)
        {
            var resultado = Validar(medicamento);
            if(resultado.Exitoso == false)
            {
                return resultado;
            }

            if (medicamento.Id == 0 )
            {
                medicamento.Id = ListaMedicamentos.Max(item => item.Id) + 1;
            }
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarMedicamento()
        {
            var nuevoMedicamento = new Medicamento();
            ListaMedicamentos.Add(nuevoMedicamento);
        }

        // Creando la clase Eliminar.
        public bool EliminarMedicamento(int id)
        {
            foreach (var medicamento in ListaMedicamentos)
            {
                if (medicamento.Id == id)
                {
                    ListaMedicamentos.Remove(medicamento);
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

            if (medicamento.Existencia < 0 )
            {
                resultado.Mensaje = "La exixtencia debe ser mayor que 0";
                resultado.Exitoso = false;
            }
            if (medicamento.Precio < 0)
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
