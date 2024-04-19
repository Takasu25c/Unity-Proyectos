using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
   public static List<Card> cardList = new List<Card> ();
   void Awake( ){
    cardList.Add (new Card (0, "Pablo", 8, "Gains 2 Power for each Pablo on the Table", "BY", "[M]", Resources.Load <Sprite>("Original Pablo")));
    cardList.Add (new Card (1, "Austin", 8, "Gains 2 Power for each Austin on the Table", "BY", "[R]", Resources.Load <Sprite>("Austin")));
    cardList.Add (new Card (2, "Tyrone", 8, "Gains 2 Power for each Tyrone on the Table", "BY", "[S]", Resources.Load <Sprite>("Tyrone")));
    cardList.Add (new Card (3, "Tasha", 8, "Gains 2 Power for each Tasha on the Table", "BY", "[S]", Resources.Load <Sprite>("Tasha")));
    cardList.Add (new Card (4, "Uniqua", 8, "Gains 2 Power for each Uniqua on the Table", "BY", "[M]", Resources.Load <Sprite>("Uniqua")));
    cardList.Add (new Card (5, "Patio Marihuano", 0, "Si tienes los 5 backyardigans en el campo aumenta el poder total en 10", "BY", "[L]", Resources.Load <Sprite>("Patio")));
    cardList.Add (new Card (6, "Oeste Marihuano", 0, "Aumenta en 2 el poder de los heroes de Rango", "BY", "[RA]", Resources.Load <Sprite>("Cowboy Backyardigans")));
    cardList.Add (new Card (7, "Jungla Marihuana", 0, "Aumenta en 2 el poder de los heroes de Melee", "BY", "[MA]", Resources.Load <Sprite>("JungleBackyardigans")));
    cardList.Add (new Card (8, "Caballeros Marihuanos", 0, "Aumenta en 2 el poder de los heroes de Asalto", "BY", "[SA]", Resources.Load <Sprite>("Mediaval Backyardigans")));
    cardList.Add (new Card (9, "Desierto Marihuano", 0, "Disminuye en 2 el poder de todas los heroes de asalto", "BY", "[CL]", Resources.Load <Sprite>("Desert")));
    cardList.Add (new Card (10, "Oceano Marihuano", 0, "Disminuye en 1 el poder de todos los heroes de rango", "BY", "[CL]", Resources.Load <Sprite>("Sea")));
    cardList.Add (new Card (11, "Nieve Esnifadora", 0, "Disminuye en 2 el poder de todos los heres de melee", "BY", "[CL]", Resources.Load <Sprite>("Snowing")));
    cardList.Add (new Card (12, "Austin Thief", 0, "Envia esta carta al cementerio para devolver un aumento a la mano", "BY", "[LU]", Resources.Load <Sprite>("Austin Thief")));
    cardList.Add (new Card (13, "Doctor Tyrone", 0, "Envia esta carta al cementerio para devolver un heroe a tu mano", "BY", "[LU]", Resources.Load <Sprite>("Doctor Tyrone")));
    cardList.Add (new Card (14, "Tyrone Cavernícola", 5, "Un cavernicola tarrú y ademas tactico dios mio", "BY", "[M]", Resources.Load <Sprite>("Cavern Tyrone")));
    cardList.Add (new Card (15, "Sherif Pablo", 6, "Disminuye en 1 el poder total de tu adversario", "BY", "[R]", Resources.Load <Sprite>("Cowboy Pablo")));
    cardList.Add (new Card (16, "Vaquero Tyrone", 5, "Gana 2 de poder si esta el clima Desierto Marihuano", "BY", "[R]", Resources.Load <Sprite>("Cowboy Tyrone")));
    cardList.Add (new Card (17, "Uniqua La Loca", 4, "Si Sherif Pablo está en el campo aumenta su poder en 3", "BY", "[S]", Resources.Load <Sprite>("Cowboy Uniqua")));
    cardList.Add (new Card (18, "Baterista Austin", 5, "Es un vaquero pero le encanta la musica", "BY", "[M]", Resources.Load <Sprite>("CowboyAustin")));
    cardList.Add (new Card (19, "Tasha Mesera", 3, "La que todos se quieren comer, #yatusabesquienes", "BY", "[S]", Resources.Load <Sprite>("Cowboy Tasha")));
    cardList.Add (new Card (20, "Pablo Cavernícola", 5, "Dios mio un pablo cavernicola, y ademas tactico", "BY", "[M]", Resources.Load <Sprite>("Cavern Pablo")));
    cardList.Add (new Card (21, "Pablo Buscador de Marihuana", 2, "Agrega un clima a tu mano", "BY", "[M]", Resources.Load <Sprite>("Explorer Pablo")));
    cardList.Add (new Card (22, "Tyrone Buscador de Marihuana", 2, "Agrega un clima a tu mano", "BY", "[M]", Resources.Load <Sprite>("Explorer Tyrone")));
    cardList.Add (new Card (23, "Austin Batman", 5, "Es Millonario y se compró una carta", "BY", "[S]", Resources.Load <Sprite>("FlowerPowerAustin")));
    cardList.Add (new Card (24, "Chocolate Austin", 6, "El verdadero rey del reparto", "BY", "[S]", Resources.Load <Sprite>("King_Austin")));
    cardList.Add (new Card (25, "Y eto q pinga eh", 3, "Te hace preguntarte y eto que pinga eh", "BY", "[S]", Resources.Load <Sprite>("LadyTasha")));
    cardList.Add (new Card (26, "Super Pablo", 6, "El verdadero Ragamorfa, aumenta el poder de todos los Pablos en 1", "BY", "[R]", Resources.Load <Sprite>("Super Pablo")));
    cardList.Add (new Card (27, "Super Austin", 4, "Se cree Batman pero es Spiderman, tira tanta paja como telarañas", "BY", "[S]", Resources.Load <Sprite>("SuperAustin")));
    cardList.Add (new Card (28, "Pablo ConFlow", 7, "Tremenda Pinta Tremendo Flow, A Ti Lo Que Te Gusta Es Mi Sazon", "BY", "[R]", Resources.Load <Sprite>("Scientis Pablo")));
    cardList.Add (new Card (29, "Super Austin", 4, "Gains 1 Power for each Austin on the Table", "BY", "[M]", Resources.Load <Sprite>("SuperAustin")));
    cardList.Add (new Card (30, "Yo en el TC de Logica", 2, "A ti lo que te mata es el tumbao del vecino", "BY", "[S]", Resources.Load <Sprite>("PierrotAustin")));
    cardList.Add (new Card (31, "La piba que se cree dura", 4, "Ah, sos machito, toma, toma, toma", "BY", "[M]", Resources.Load <Sprite>("Tasha Thug")));
    cardList.Add (new Card (32, "Pablo Heroína", 5, "El unico, el inigualable, Pablo con 8 dosis de heroina!!!", "BY", "[M]", Resources.Load <Sprite>("Viking Pablo")));
    cardList.Add (new Card (33, "Panadero Cubano", 3, "Dice que 62g y da 1g lo otro por la izquierda", "BY", "[R]", Resources.Load <Sprite>("PieMasterTyrone")));
    cardList.Add (new Card (34, "007 Pablo", 6, "Soy Pa, Pa Blo", "BY", "[M]", Resources.Load <Sprite>("Pablo Secret Agent")));
    cardList.Add (new Card (35, "Que pinga te pasa", 4, "Chico tu ere guapo? Dale vamo a fajarno a las 4 y 20", "BY", "[S]", Resources.Load <Sprite>("Uniqua Swimmer")));
    cardList.Add (new Card (36, "SherlockNiqua", 6, "Agrega una carta aumento a tu mano", "BY", "[R]", Resources.Load <Sprite>("UniquaLady")));
    cardList.Add (new Card (37, "Trabajador de la Guiteras", 4, "Ya sabes porque no tienes corriente", "BY", "[S]", Resources.Load <Sprite>("AssistanAustin")));
    cardList.Add (new Card (38, "Vendedor de Tamales", 6, "Tamaaaaaaal, tamalero llego, a no que era mani, tamaaaaaallllll", "BY", "[M]", Resources.Load <Sprite>("ArabianAustin")));
    cardList.Add (new Card (39, "La Gorda del Barrio", 4, "Tu sabes que yo conozco a 5 personas gordas? y 4 de ellas eres tu", "BY", "[S]", Resources.Load <Sprite>("Maharani_Tasha")));
   }
}
