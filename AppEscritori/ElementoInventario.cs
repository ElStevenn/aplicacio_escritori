using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritori
{
    public class ElementoInventario
    {
        public int numInventory {  get; set; }
        public int field {  get; set; }
        public string nameElement {  get; set; }
        public string image {  get; set; }
        public string description { get; set; }
        public int autonomy { get; set; }
        public int disposalCapacity {  get; set; }
        public string cicle { get; set; }
        public int cilindrada {  get; set; }
        public int wingspan {  get; set; }
        public string energyfont {  get; set; }
        public string fromIncome { get; set; }
        public string manufacturingPlace {  get; set; }
        public int lenght { get; set; }
        public int weight { get; set; }
        public int potency {  get; set; }
        public int kmsDone {  get; set; }
        public int sostreMaximDeVol { get; set; }
        public string sourceIncome { get; set; }
        public int speed { get; set; }
        public int maxSpeed { get; set; }
        public bool inicialElement {  get; set; }
        public int year { get; set; }

        public ElementoInventario()
        {

        }

        public ElementoInventario(int numInventory, int field, string nameElement, string image, string description, int autonomy, int disposalCapacity, string cicle, int cilindrada, int wingspan, string energyfont, string fromIncome, string sourceIncome, string manufacturingPlace, int lenght, int weight, int potency, int kmsDone, int sostreMaximDeVol, int speed, int maxSpeed, bool inicialElement, int year)
        {
            this.numInventory = numInventory;
            this.field = field;
            this.nameElement = nameElement;
            this.image = image;
            this.description = description;
            this.autonomy = autonomy;
            this.disposalCapacity = disposalCapacity;
            this.cicle = cicle;
            this.cilindrada = cilindrada;
            this.wingspan = wingspan;
            this.energyfont = energyfont;
            this.fromIncome = fromIncome;
            this.sourceIncome = sourceIncome;
            this.manufacturingPlace = manufacturingPlace;
            this.lenght = lenght;
            this.weight = weight;
            this.potency = potency;
            this.kmsDone = kmsDone;
            this.sostreMaximDeVol = sostreMaximDeVol;
            this.speed = speed;
            this.maxSpeed = maxSpeed;
            this.inicialElement = inicialElement;
            this.year = year;
        }
    }
}
