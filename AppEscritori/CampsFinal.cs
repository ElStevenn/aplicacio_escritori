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
        public string rutaArchivoJson_esp = @"..\..\..\JSON\elements_esp.json";
        public string rutaArchivoJson_eng = @"..\..\..\JSON\elements_eng.json";

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

                // Cargar textos
                nombr_elem.Text = gestionadorMuseo.nombreElemento;
                numero_inventario.Text = gestionadorMuseo.numeroInventario.ToString();
                ano_creacion.Text = gestionadorMuseo.anoCreacion.ToString();
                description.Text = gestionadorMuseo.descripcion_elemento;
            }
;
        }

        private void button_generar_Click(object sender, EventArgs e)
        {

            string filename = Path.GetFileName(gestionadorMuseo.ruta_imagen);
            string destinationFolderPath = @"..\..\..\JSON\museu_images\";

            string destinationFilePath = Path.Combine(destinationFolderPath, filename);

            try
            {
                File.Copy(gestionadorMuseo.ruta_imagen, destinationFilePath, true);
            }
            catch (IOException iox)
            {
                MessageBox.Show("Error al copiar el archivo: " + iox.Message);
                return;
            }


            // PARTE CARGAR EL JSON Y IMAGEN
            // Leer json
            string json_cat = File.ReadAllText(rutaArchivoJson_cat);
            string json_esp = File.ReadAllText(rutaArchivoJson_esp);
            string json_eng = File.ReadAllText(rutaArchivoJson_eng);

            // Deserializar el JSON a una lista de objetos
            List<ElementoInventario> inventario_cat = JsonConvert.DeserializeObject<List<ElementoInventario>>(json_cat);
            List<ElementoInventario> inventario_esp = JsonConvert.DeserializeObject<List<ElementoInventario>>(json_esp);
            List<ElementoInventario> inventario_eng = JsonConvert.DeserializeObject<List<ElementoInventario>>(json_eng);

            // CARGAR JSON EN CATALÁN
            // Crear un nuevo elemento y configurar las propiedades
            ElementoInventario nuevoElemento_cat = new ElementoInventario
            {
                numInventory = int.TryParse(gestionadorMuseo.numeroInventario, out int numInventoryResult) ? numInventoryResult : -1,
                field = int.TryParse(gestionadorMuseo.ambito, out int fieldResult) ? fieldResult : -1,
                nameElement = gestionadorMuseo.nombreElemento ?? "",
                image = filename ?? "",
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


            // Cargar JSON EN ESPAÑOL
            ElementoInventario nuevoElemento_esp = new ElementoInventario
            {
                numInventory = int.TryParse(gestionadorMuseo.numeroInventario, out int numInventoryResultEsp) ? numInventoryResultEsp : -1,
                field = int.TryParse(gestionadorMuseo.ambito, out int fieldResultEsp) ? fieldResultEsp : -1,
                nameElement = gestionadorMuseo.es_nombreElemento ?? "",
                image = filename ?? "",
                description = gestionadorMuseo.es_descripcionElemento ?? "",
                autonomy = int.TryParse(gestionadorMuseo.autonomia, out int autonomyResultEsp) ? autonomyResultEsp : -1,
                disposalCapacity = int.TryParse(gestionadorMuseo.capacitat_diposit, out int disposalCapacityResultEsp) ? disposalCapacityResultEsp : -1,
                cicle = gestionadorMuseo.cicle ?? "",
                cilindrada = int.TryParse(gestionadorMuseo.cilidrada, out int cilindradaResultEsp) ? cilindradaResultEsp : -1,
                wingspan = int.TryParse(gestionadorMuseo.envergadura, out int wingspanResultEsp) ? wingspanResultEsp : -1,
                energyfont = gestionadorMuseo.fuente_energia ?? "",
                sourceIncome = gestionadorMuseo.fuente_ingreso ?? "",
                fromIncome = gestionadorMuseo.forma_ingreso ?? "",
                manufacturingPlace = gestionadorMuseo.lugar_fabricacion ?? "",
                lenght = int.TryParse(gestionadorMuseo.longitud, out int lenghtResultEsp) ? lenghtResultEsp : -1,
                weight = int.TryParse(gestionadorMuseo.peso, out int weightResultEsp) ? weightResultEsp : -1,
                potency = int.TryParse(gestionadorMuseo.potencia, out int potencyResultEsp) ? potencyResultEsp : -1,
                kmsDone = int.TryParse(gestionadorMuseo.quilometros_h, out int kmsDoneResultEsp) ? kmsDoneResultEsp : -1,
                sostreMaximDeVol = int.TryParse(gestionadorMuseo.techoMaximo, out int sostreMaximDeVolResultEsp) ? sostreMaximDeVolResultEsp : -1,
                speed = int.TryParse(gestionadorMuseo.velocidad, out int speedResultEsp) ? speedResultEsp : -1,
                maxSpeed = int.TryParse(gestionadorMuseo.velocidad_maxima, out int maxSpeedResultEsp) ? maxSpeedResultEsp : -1,
                inicialElement = gestionadorMuseo.elemento_incial // Esto es un bool y no requiere coalescencia nula
            };


            // Cargar JSON EN INGLÉS
            ElementoInventario nuevoElemento_eng = new ElementoInventario
            {
                numInventory = int.TryParse(gestionadorMuseo.numeroInventario, out int numInventoryResultEng) ? numInventoryResultEng : -1,
                field = int.TryParse(gestionadorMuseo.ambito, out int fieldResultEng) ? fieldResultEng : -1,
                nameElement = gestionadorMuseo.eng_nombreElemento ?? "",
                image = filename ?? "",
                description = gestionadorMuseo.eng_descripcionEelemento ?? "",
                autonomy = int.TryParse(gestionadorMuseo.autonomia, out int autonomyResultEng) ? autonomyResultEng : -1,
                disposalCapacity = int.TryParse(gestionadorMuseo.capacitat_diposit, out int disposalCapacityResultEng) ? disposalCapacityResultEng : -1,
                cicle = gestionadorMuseo.cicle ?? "",
                cilindrada = int.TryParse(gestionadorMuseo.cilidrada, out int cilindradaResultEng) ? cilindradaResultEng : -1,
                wingspan = int.TryParse(gestionadorMuseo.envergadura, out int wingspanResultEng) ? wingspanResultEng : -1,
                energyfont = gestionadorMuseo.fuente_energia ?? "",
                sourceIncome = gestionadorMuseo.fuente_ingreso ?? "",
                fromIncome = gestionadorMuseo.forma_ingreso ?? "",
                manufacturingPlace = gestionadorMuseo.lugar_fabricacion ?? "",
                lenght = int.TryParse(gestionadorMuseo.longitud, out int lenghtResultEng) ? lenghtResultEng : -1,
                weight = int.TryParse(gestionadorMuseo.peso, out int weightResultEng) ? weightResultEng : -1,
                potency = int.TryParse(gestionadorMuseo.potencia, out int potencyResultEng) ? potencyResultEng : -1,
                kmsDone = int.TryParse(gestionadorMuseo.quilometros_h, out int kmsDoneResultEng) ? kmsDoneResultEng : -1,
                sostreMaximDeVol = int.TryParse(gestionadorMuseo.techoMaximo, out int sostreMaximDeVolResultEng) ? sostreMaximDeVolResultEng : -1,
                speed = int.TryParse(gestionadorMuseo.velocidad, out int speedResultEng) ? speedResultEng : -1,
                maxSpeed = int.TryParse(gestionadorMuseo.velocidad_maxima, out int maxSpeedResultEng) ? maxSpeedResultEng : -1,
                inicialElement = gestionadorMuseo.elemento_incial // Esto es un bool y no requiere coalescencia nula
            };



            // Agregar el elemento a la lista del json
            inventario_cat.Add(nuevoElemento_cat);
            inventario_esp.Add(nuevoElemento_esp);
            inventario_eng.Add(nuevoElemento_eng);

            // Serializar la lista modificada a JSON
            string jsonModificado_ca = JsonConvert.SerializeObject(inventario_cat, Formatting.Indented);
            string jsonModificado_es = JsonConvert.SerializeObject(inventario_esp, Formatting.Indented);
            string jsonModificado_en = JsonConvert.SerializeObject(inventario_eng, Formatting.Indented);

            // Guardar el JSON modificado en el archivo
            File.WriteAllText(rutaArchivoJson_cat, jsonModificado_ca);
            File.WriteAllText(rutaArchivoJson_esp, jsonModificado_es);
            File.WriteAllText(rutaArchivoJson_eng, jsonModificado_en);


            MessageBox.Show("Elemento " + gestionadorMuseo.nombreElemento + " guardado con éxito.");
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
