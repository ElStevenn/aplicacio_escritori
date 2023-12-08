using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AppEscritori.GestionarParteMuseo;

namespace AppEscritori
{
    public partial class CampsFinal : Form
    {
        public GestionarParteMuseo.Gestor_museo gestionadorMuseo;
        public string rutaArchivoJson_cat = @"..\..\..\JSON\elements_cat.json";


        public CampsFinal()
        {
            InitializeComponent();
        }
        public CampsFinal(Gestor_museo gestor_Museo)
        {
            InitializeComponent();
            this.gestionadorMuseo = gestor_Museo;
            cargar_campos();
        }

        public void cargar_campos()
        {
            if (gestionadorMuseo != null)
            {
                // Cargo la imagen y hago para que se muestren en las dimensiones correctas
                string ruta_imagen = gestionadorMuseo.ruta_imagen;
                imagen_elemento.Image = Image.FromFile(ruta_imagen);

                imagen_elemento.SizeMode = PictureBoxSizeMode.StretchImage;
            }
;
        }

        private void button_generar_Click(object sender, EventArgs e)
        {

            // PARTE CARGAR EL JSON Y IMAGEN
            // Leer json
            string json = File.ReadAllText(rutaArchivoJson_cat);

            // Deserializar el JSON a una lista de objetos
            List<ElementoInventario> inventario = JsonConvert.DeserializeObject<List<ElementoInventario>>(json);


            // CARGAR JSON EN CATALÁN
            // Crear un nuevo elemento y configurar las propiedades
            ElementoInventario nuevoElemento = new ElementoInventario
            {
                numInventory = int.TryParse(gestionadorMuseo.numeroInventario, out int numInventoryResult) ? numInventoryResult : -1,
                field = int.TryParse(gestionadorMuseo.ambito, out int fieldResult) ? fieldResult : -1,
                nameElement = gestionadorMuseo.nombreElemento ?? "",
                image = gestionadorMuseo.ruta_imagen ?? "",
                description = gestionadorMuseo.descripcion_elemento ?? "",
                autonomy = int.TryParse(gestionadorMuseo.autonomia, out int autonomyResult) ? autonomyResult : -1,
                disposalCapacity = int.TryParse(gestionadorMuseo.capacitat_diposit, out int disposalCapacityResult) ? disposalCapacityResult : -1,
                cicle = gestionadorMuseo.cicle ?? "",
                cilindrada = int.TryParse(gestionadorMuseo.cilidrada, out int cilindradaResult) ? cilindradaResult : -1,
                wingspan = int.TryParse(gestionadorMuseo.envergadura, out int wingspanResult) ? wingspanResult : -1,
                energyfont = gestionadorMuseo.fuente_energia ?? "",
                sourceIncome = gestionadorMuseo.fuente_ingreso ?? "",
                fromIncome = gestionadorMuseo.forma_ingreso ?? "",
                manufacturingPlace = gestionadorMuseo.lugar_fabricacion ?? "",
                lenght = int.TryParse(gestionadorMuseo.longitud, out int lenghtResult) ? lenghtResult : -1,
                weight = int.TryParse(gestionadorMuseo.peso, out int weightResult) ? weightResult : -1,
                potency = int.TryParse(gestionadorMuseo.potencia, out int potencyResult) ? potencyResult : -1,
                kmsDone = int.TryParse(gestionadorMuseo.quilometros_h, out int kmsDoneResult) ? kmsDoneResult : -1,
                sostreMaximDeVol = int.TryParse(gestionadorMuseo.techoMaximo, out int sostreMaximDeVolResult) ? sostreMaximDeVolResult : -1,
                speed = int.TryParse(gestionadorMuseo.velocidad, out int speedResult) ? speedResult : -1,
                maxSpeed = int.TryParse(gestionadorMuseo.velocidad_maxima, out int maxSpeedResult) ? maxSpeedResult : -1,
                inicialElement = gestionadorMuseo.elemento_incial // Esto es un bool y no requiere coalescencia nula
            };


            // Agregar el elemento a la lista
            inventario.Add(nuevoElemento);

            // Serializar la lista modificada a JSON
            string jsonModificado = JsonConvert.SerializeObject(inventario, Formatting.Indented);


            // Guardar el JSON modificado en el archivo
            File.WriteAllText(rutaArchivoJson_cat, jsonModificado);



            MessageBox.Show("Elemento guardado con éxito.");
            Menu menu = new Menu();
            menu.Show();
            this.Hide();

        }

        private void button_atras_Click(object sender, EventArgs e)
        {
            // Para volver atrás
            Camps camp = new Camps(gestionadorMuseo);
            camp.Show();
            this.Hide();

        }

    }
}
