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
            public string modo_gestor {  get; set; }
            // PARTE EN ESPAÑOL
            // Campos main
            public string nombreElemento { get; set; } = string.Empty;
            public string numeroInventario {  get; set; } = string.Empty;
            public string anoCreacion  { get; set; } = string.Empty;
            public string descripcion_elemento { get; set; } = string.Empty;

            // Campos Principales
            public string autonomia { get; set; } = string.Empty;
            public string capacitat_diposit { get; set; } = string.Empty;
            public string cicle { get; set; } = string.Empty;
            public string cilidrada { get; set; } = string.Empty;
            public string elemento { get; set; } = string.Empty;
            public string envergadura {  get; set; } = string.Empty;
            public string potencia { get; set; } = string.Empty;
            public string quilometros_h { get; set; } = string.Empty;
            public string techoMaximo { get; set; } = string.Empty;
            public string peso { get; set; } = string.Empty;
            public string velocidad { get; set; } = string.Empty;
            public string velocidad_maxima { get; set; } = string.Empty;
            public string fuente_energia { get; set; } = string.Empty;
            public string fuente_ingreso { get; set; } = string.Empty;
            public string forma_ingreso { get; set; } = string.Empty;
            public string lugar_fabricacion { get; set; } = string.Empty;
            public string longitud { get; set; } = string.Empty;
            public string ambito { get; set; } = string.Empty;


            // PARTE EN ESPAÑOL Y INGLÉS
            // Campos main
            public string es_nombreElemento { get; set; } = string.Empty;
            public string es_descripcionElemento { get; set; } = string.Empty;


            public string eng_nombreElemento { get; set; } = string.Empty;
            public string eng_descripcionEelemento { get; set; } = string.Empty;

            // FOTO
            public string ruta_imagen {  get; set; }

            // Pongo aquí la intancia para poder moverlo entre archivos
            /*
            private static Gestor_museo instance = null;

            private Gestor_museo(string modo) {
                this.modo_gestor = modo;
            }

            public static Gestor_museo Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Gestor_museo("crear");
                    }
                    return instance;
                }
            }
            */
            // Elemento inicial | Se inicia en false pero el usuario lo puede cambiar a true
            public bool elemento_incial {  get; set; } = false;

            public void actualizar_campos_main(string nombreElemento, string numeroInventario, string anoCreacion, string descripcion_elemento)
            {
                this.nombreElemento = nombreElemento;
                this.numeroInventario = numeroInventario;
                this.anoCreacion = anoCreacion;
                this.descripcion_elemento = descripcion_elemento;
            }

       
            
            public void actualizar_campos_espeng(string es_nombreElemento, string es_descripcion, string eng_nombreElemento, string eng_descripcion)
            {
                this.es_nombreElemento = es_nombreElemento;
                this.es_descripcionElemento = es_descripcion;
                this.eng_nombreElemento = eng_nombreElemento;
                this.eng_descripcionEelemento = eng_descripcion;
            }
           

            public void actualizar_caracteristicas(string autonomia, string capacitat_diposit, string clicle, string cilidrada,
                                           string elemento,string envergadura ,string potencia, string quilometros_h,string techoMaximo, string peso,
                                           string velocidad, string velocidad_maxima, string fuente_energia,
                                           string fuente_ingreso, string forma_ingreso, string lugar_fabricacion,
                                           string longitud, string ambito)
            {
                this.autonomia = autonomia;
                this.capacitat_diposit = capacitat_diposit;
                this.cicle = cicle;
                this.cilidrada = cilidrada;
                this.elemento = elemento;
                this.envergadura = envergadura;
                this.potencia = potencia;
                this.quilometros_h = quilometros_h;
                this.techoMaximo = techoMaximo;
                this.peso = peso;
                this.velocidad = velocidad;
                this.velocidad_maxima = velocidad_maxima;
                this.fuente_energia = fuente_energia;
                this.fuente_ingreso = fuente_ingreso;
                this.forma_ingreso = forma_ingreso;
                this.lugar_fabricacion = lugar_fabricacion;
                this.longitud = longitud;
                this.ambito = ambito;
            }

            public void actualizar_ruta_imagen(string ruta_imagen)
            {
                this.ruta_imagen = ruta_imagen;
            }

            public void actualizar_elemento_inicial(bool status)
            {
                this.elemento_incial = status;
            }

        }
      
    }

}
