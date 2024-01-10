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
        public string rutaArchivoJson_cat;
        public string rutaArchivoJson_esp;
        public string rutaArchivoJson_eng;
        public string rutaImagenes;

        public CampsFinal()
        {
            InitializeComponent();
        }
        public CampsFinal(Gestor_museo gestor_Museo)
        {
            InitializeComponent();
            this.gestionadorMuseo = gestor_Museo;
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            rutaArchivoJson_cat = Path.Combine(baseDirectory, "JSON", "elements_cat.json");
            rutaArchivoJson_esp = Path.Combine(baseDirectory, "JSON", "elements_esp.json");
            rutaArchivoJson_eng = Path.Combine(baseDirectory, "JSON", "elements_eng.json");
            rutaImagenes = Path.Combine(baseDirectory, "JSON", "imgelements");
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
                //description.Text = gestionadorMuseo.descripcion_elemento; // En caso de que le quiera también añadir descripción en el elemento final

                // Actualizar el boton del texto dependiendo si está creando o modificando un elemento
                if (gestionadorMuseo.modo_gestor == "crear")
                {
                    button_generar.Text = "Crear elemento";
                }
                else if (gestionadorMuseo.modo_gestor == "editar")
                {
                    button_generar.Text = "Modificar el elemento";
                }
                else
                {
                    button_generar.Text = "Confirmar";
                }
            }
;
        }



        private void button_generar_Click(object sender, EventArgs e)
        {

            string filename = Path.GetFileName(gestionadorMuseo.ruta_imagen);

            string destinationFilePath = Path.Combine(rutaImagenes, filename);

            try
            {
                File.Copy(gestionadorMuseo.ruta_imagen, destinationFilePath, true);
            }
            catch (IOException iox)
            {
                if (gestionadorMuseo.modo_gestor == "crear")
                {
                    MessageBox.Show("Error al copiar el archivo: " + iox.Message);
                    return;
                }

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

            if (gestionadorMuseo.modo_gestor == "crear")
            {



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


                MessageBox.Show("Elemento " + gestionadorMuseo.nombreElemento + " creado con éxito.");
            }
            else if (gestionadorMuseo.modo_gestor == "editar")
            {
                // Función para actualizar un elemento por numInventario
                void ActualizarElemento(List<ElementoInventario> lista, ElementoInventario elementoActualizado)
                {
                    var elementoAEditar = lista.FirstOrDefault(e => e.numInventory == elementoActualizado.numInventory);
                    if (elementoAEditar != null)
                    {
                        // Actualiza las propiedades del elemento encontrado
                        elementoAEditar.field = elementoActualizado.field;
                        elementoAEditar.nameElement = elementoActualizado.nameElement;
                        elementoAEditar.image = elementoActualizado.image;
                        elementoAEditar.description = elementoActualizado.description;
                        elementoAEditar.autonomy = elementoActualizado.autonomy;
                        elementoAEditar.disposalCapacity = elementoActualizado.disposalCapacity;
                        elementoAEditar.cicle = elementoActualizado.cicle;
                        elementoAEditar.cilindrada = elementoActualizado.cilindrada;
                        elementoAEditar.wingspan = elementoActualizado.wingspan;
                        elementoAEditar.energyfont = elementoActualizado.energyfont;
                        elementoAEditar.sourceIncome = elementoActualizado.sourceIncome;
                        elementoAEditar.fromIncome = elementoActualizado.fromIncome;
                        elementoAEditar.manufacturingPlace = elementoActualizado.manufacturingPlace;
                        elementoAEditar.lenght = elementoActualizado.lenght;
                        elementoAEditar.weight = elementoActualizado.weight;
                        elementoAEditar.potency = elementoActualizado.potency;
                        elementoAEditar.kmsDone = elementoActualizado.kmsDone;
                        elementoAEditar.sostreMaximDeVol = elementoActualizado.sostreMaximDeVol;
                        elementoAEditar.speed = elementoActualizado.speed;
                        elementoAEditar.maxSpeed = elementoActualizado.maxSpeed;
                        elementoAEditar.inicialElement = elementoActualizado.inicialElement;
                    }
                }

                // Actualizar el elemento en las listas
                ActualizarElemento(inventario_cat, nuevoElemento_cat);
                ActualizarElemento(inventario_esp, nuevoElemento_esp);
                ActualizarElemento(inventario_eng, nuevoElemento_eng);

                // Serializar la lista modificada a JSON y guardar en el archivo
                string jsonModificado_cat = JsonConvert.SerializeObject(inventario_cat, Formatting.Indented);
                string jsonModificado_esp = JsonConvert.SerializeObject(inventario_esp, Formatting.Indented);
                string jsonModificado_eng = JsonConvert.SerializeObject(inventario_eng, Formatting.Indented);

                File.WriteAllText(rutaArchivoJson_cat, jsonModificado_cat);
                File.WriteAllText(rutaArchivoJson_esp, jsonModificado_esp);
                File.WriteAllText(rutaArchivoJson_eng, jsonModificado_eng);

                MessageBox.Show("Elemento " + gestionadorMuseo.nombreElemento + " actualizado con éxito.");
            }
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
