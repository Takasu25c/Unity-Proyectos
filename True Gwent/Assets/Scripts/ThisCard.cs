using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using Unity.VisualScripting;
public class ThisCard : MonoBehaviour
{
    public List<Card> thisCard = new List<Card>(); 
    public int thisId;
   public int id;
   public string cardName;
   public int power;
   public string cardDescription;
   public string faction;
   public string cardType;
   public TMP_Text idText;
   public TMP_Text nameText;
   public TMP_Text powerText;
   public TMP_Text descriptionText;
   public TMP_Text factionText;
   public TMP_Text typeText;
   public Sprite thisSprite;
   public Image thatimage;
    void Start()
    {
        thisCard [0] = CardDatabase.cardList[thisId];
    }
    void Update()
    {
        id = thisCard[0].id;
        cardName = thisCard[0].cardName;
        power = thisCard[0].power;
        cardDescription = thisCard[0].cardDescription;
        faction = thisCard[0].faction;
        cardType = thisCard[0].cardType;
        thisSprite = thisCard[0].thisImage;

        idText.text = ""+ id;
        nameText.text = ""+ cardName;
        powerText.text = ""+ power;
        descriptionText.text = ""+cardDescription;
        factionText.text = ""+ faction;
        typeText.text = ""+ cardType;
        thatimage.sprite = thisSprite;
    }
}
