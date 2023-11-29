using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AppEscritori
{
    internal class GestionarParteMuseo
    {
        public class gestor_museo
        {
            // Campos main
            string nombreElemento { get; set; }
            string numeroInventario {  get; set; }  
            string anoCreacion  { get; set; }
            string descripcion_elemento { get; set; }

            // Campos Principales
            string autonomia { get; set; }
            string capacitat_diposit { get; set; }
            string clicle { get; set; }
            string cilidrada { get; set; }
            string elemento { get; set; }
            string potencia { get; set; }
            string quilometros_h { get; set; }
            string peso { get; set; }
            string velocidad { get; set; }
            string velocidad_maxima { get; set; }
            string fuente_energia { get; set; }
            string fuente_ingreso { get; set; }
            string forma_ingreso { get; set; }
            string lugar_fabricacion { get; set; }
            string longitud { get; set; }

            public void introducir_campos_main(string nombreElemento, string numeroInventario, string anoCreacion, string descripcion_elemento)
            {
                this.nombreElemento = nombreElemento;
                this.numeroInventario = numeroInventario;
                this.anoCreacion = anoCreacion;
                this.descripcion_elemento = descripcion_elemento;
            }

            public void introducir_caracteristicas(string autonomia, string capacitat_diposit, string clicle, string cilidrada,
                                           string elemento, string potencia, string quilometros_h, string peso,
                                           string velocidad, string velocidad_maxima, string fuente_energia,
                                           string fuente_ingreso, string forma_ingreso, string lugar_fabricacion,
                                           string longitud)
            {
                this.autonomia = autonomia;
                this.capacitat_diposit = capacitat_diposit;
                this.clicle = clicle;
                this.cilidrada = cilidrada;
                this.elemento = elemento;
                this.potencia = potencia;
                this.quilometros_h = quilometros_h;
                this.peso = peso;
                this.velocidad = velocidad;
                this.velocidad_maxima = velocidad_maxima;
                this.fuente_energia = fuente_energia;
                this.fuente_ingreso = fuente_ingreso;
                this.forma_ingreso = forma_ingreso;
                this.lugar_fabricacion = lugar_fabricacion;
                this.longitud = longitud;
            }


        }
    }

}
