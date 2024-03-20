using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
   public static List<Card> cardList = new List<Card> ();
   void Awake( ){
    cardList.Add (new Card (0, "Super Pablo", 6, "Gains 1 Power for each Pablo on the Table", "BY", "[M,R]", Resources.Load <Sprite>("Super Pablo")));
    cardList.Add (new Card (0, "Super Austin", 4, "Gains 1 Power for each Austin on the Table", "BY", "[S,R]", Resources.Load <Sprite>("SuperAustin")));
   }
}
