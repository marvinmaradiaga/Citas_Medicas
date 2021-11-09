using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;

namespace BL.Citas
{
    public class FacturaBL
    {
        Contexto _contexto;

        public BindingList<Factura> ListaFacturas { get; set; }

        public FacturaBL()
        {
            _contexto = new Contexto();
        }

        public BindingList<Factura> ObtenerFacturas()
        {
            _contexto.Facturas.Include("FacturaDetalle").Load();
            ListaFacturas = _contexto.Facturas.Local.ToBindingList();

            return ListaFacturas;
        }

        public void AgregarFactura()
        {
            var nuevaFactura = new Factura();
            _contexto.Facturas.Add(nuevaFactura);
        }


        public void AgregarFacturaDetalle(Factura factura) // avance 6 agregando la funcion agregar filas a facturadetalle 
        {
            if (factura != null)
            {
                var nuevoDetalle = new FacturaDetalle();
                factura.FacturaDetalle.Add(nuevoDetalle);
            }
        }

        public void RemoverFacturaDetalle(Factura factura,FacturaDetalle facturaDetalle) // avance 6 agregando la funcion eliminar filas a facturadetalle
        {
            if (factura != null && facturaDetalle != null)
            {
                
                factura.FacturaDetalle.Remove(facturaDetalle);
            }
        }


        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }

        }

        public Resultado GuardarFactura(Factura factura)
        {
            var resultado = Validar(factura);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            CalcularExistencia(factura);

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        private void CalcularExistencia(Factura factura)
        {
            foreach (var detalle in factura.FacturaDetalle)//Aumentando y disminuyendo la existencia de medicamentos al realizar ventas//
            {
                var medicamento = _contexto.Medicamentos.Find(detalle.MedicamentoId);
                if (medicamento != null)
                {
                    if (factura.Activo == true)
                    {
                        medicamento.Existencia = medicamento.Existencia - detalle.Cantidad;

                    }
                    else
                    {
                        medicamento.Existencia = medicamento.Existencia + detalle.Cantidad;

                    }
                }
            }
        }

        private Resultado Validar(Factura factura)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            //Agregando validaciones a la factura
            if (factura == null)
            {
                resultado.Mensaje = ("Agrege una factura para guardarla.");
                resultado.Exitoso = false;

                return resultado;
            }

            if (factura.Id !=0 && factura.Activo == true) // Agregando validadcion en factura para menejar existencia en medicamentos
            {
                resultado.Mensaje = ("La factura ya fue emitida y no se pueden realizar cambios en ella.");
                resultado.Exitoso = false;

            }

            if (factura.Activo == false)
            {
                resultado.Mensaje = ("La factura esta anulada y no se puede realizar cambios en ella.");
                resultado.Exitoso = false;

            }

            if (factura.ClienteId == 0)
            {
                resultado.Mensaje = ("Seleccione un cliente.");
                resultado.Exitoso = false;

            }

            if (factura.FacturaDetalle.Count == 0)
            {
                resultado.Mensaje = ("Agrege medicamentos a la factura.");
                resultado.Exitoso = false;

            }

            foreach (var detalle in factura.FacturaDetalle)
            {
                if (detalle.MedicamentoId == 0)
                {
                    resultado.Mensaje = " Seleccione medicamentos validos";
                    resultado.Exitoso = false;
                    
                }
            }

            return resultado;
        }

        //Agregando funcionalidad Calculando la factura
        public void CalcularFactura(Factura factura)
        {
            if (factura != null)
            {
                double subtotal = 0;

                foreach (var detalle in factura.FacturaDetalle)
                {
                    var medicamento = _contexto.Medicamentos.Find(detalle.MedicamentoId);
                    if (medicamento != null)
                    {
                        detalle.Precio = medicamento.Precio;
                        detalle.Total = detalle.Cantidad * medicamento.Precio;

                        subtotal += detalle.Total;
                    }
                }

                factura.Subtotal = subtotal;
                factura.Impuesto = subtotal * 0.15;
                factura.Total = subtotal + factura.Impuesto;
            }
        }

        // Creando metodo de anular factura
        public bool AnularFactura(int id)
        {
            foreach (var factura in ListaFacturas)
            {
                if (factura.Id == id)
                {
                    factura.Activo = false;
                    CalcularExistencia(factura);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

    }

    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha{ get; set; }
        public int ClienteId { get; set; }
        public Cliente cliente { get; set; }
        public BindingList<FacturaDetalle> FacturaDetalle { get; set; }
        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        public Factura()
        {
            Fecha = DateTime.Now;
            FacturaDetalle = new BindingList<FacturaDetalle>();
            Activo = true;
        }
    }

    public class FacturaDetalle
    {
        public int Id { get; set; }
        public int MedicamentoId  { get; set; }
        public Medicamento Medicamento { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        public FacturaDetalle()
        {
            Cantidad = 1;
        }
    }



}
