using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class Card
{
   public int id;
   public string cardName;
   public int power;
   public string cardDescription;
   public string faction;
   public string cardType;
   public Sprite thisImage;
   public Card(){

   }
  public Card(int Id, string CardName, int Power, string CardDescription, string Faction, string CardType, Sprite ThisImage){
    id= Id;
    cardName = CardName;
    power = Power;
    cardDescription = CardDescription;
    faction = Faction;
    cardType = CardType;
    thisImage = ThisImage;
  }
}
