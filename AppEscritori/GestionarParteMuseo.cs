using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace AppEscritori
{
    public class GestionarParteMuseo
    {
        public class Gestor_museo
        {
            // Campos main
            public string nombreElemento { get; set; } = string.Empty;
            public string numeroInventario {  get; set; } = string.Empty;
            public string anoCreacion  { get; set; } = string.Empty;
            public string descripcion_elemento { get; set; } = string.Empty;

            // Campos Principales
            string autonomia { get; set; } = string.Empty;
            string capacitat_diposit { get; set; } = string.Empty;
            string clicle { get; set; } = string.Empty;
            string cilidrada { get; set; } = string.Empty;
            string elemento { get; set; } = string.Empty;
            string potencia { get; set; } = string.Empty;
            string quilometros_h { get; set; } = string.Empty;
            string peso { get; set; } = string.Empty;
            string velocidad { get; set; } = string.Empty;
            string velocidad_maxima { get; set; } = string.Empty;
            string fuente_energia { get; set; } = string.Empty;
            string fuente_ingreso { get; set; } = string.Empty;
            string forma_ingreso { get; set; } = string.Empty;
            string lugar_fabricacion { get; set; } = string.Empty;
            string longitud { get; set; } = string.Empty;

            // Pongo aquí la intancia para poder moverlo entre archivos
            private static Gestor_museo instance = null;
            private Gestor_museo() { }

            public static Gestor_museo Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Gestor_museo();
                    }
                    return instance;
                }
            }


            public void actualizar_campos_main(string nombreElemento, string numeroInventario, string anoCreacion, string descripcion_elemento)
            {
                this.nombreElemento = nombreElemento;
                this.numeroInventario = numeroInventario;
                this.anoCreacion = anoCreacion;
                this.descripcion_elemento = descripcion_elemento;
            }

            public void actualizar_caracteristicas(string autonomia, string capacitat_diposit, string clicle, string cilidrada,
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
