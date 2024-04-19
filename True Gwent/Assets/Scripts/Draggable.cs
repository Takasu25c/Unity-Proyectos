using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Unity.VisualScripting;
using System.Security.Cryptography;
public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
 public List<GameObject> AllZones = new List<GameObject>();
 public Transform parentToReturnTo = null;
 public GameObject P1Hand;
 public GameObject P2Hand;
 public GameObject P1Deck;
 public GameObject P2Deck;
 public GameObject P1Cementery;
 public GameObject P2Cementery;
 public GameObject PassButton;
public int promdiv =0;
public int fieldtotalpower =0;

 void Start(){
  P1Hand = GameObject.Find("P1 Hand");
  P2Hand = GameObject.Find("P2 Hand");
  P1Deck = GameObject.Find("P1 Deck");
  P2Deck = GameObject.Find("P2 Deck");
  P1Cementery = GameObject.Find("P1 Cementery");
  P2Cementery = GameObject.Find("P2 Cementery");
  PassButton = GameObject.Find("TurnButton");
  AllZones.Clear();
  AllZones.Add(GameObject.Find("P1 Melee Zone"));
  AllZones.Add(GameObject.Find("P1 Range Zone"));
  AllZones.Add(GameObject.Find("P1 Siege Zone"));
  AllZones.Add(GameObject.Find("P2 Melee Zone"));
  AllZones.Add(GameObject.Find("P2 Range Zone"));
  AllZones.Add(GameObject.Find("P2 Siege Zone"));
  AllZones.Add(GameObject.Find("P1 Melee Augment"));
  AllZones.Add(GameObject.Find("P1 Range Augment"));
  AllZones.Add(GameObject.Find("P1 Siege Augment"));
  AllZones.Add(GameObject.Find("P2 Melee Augment"));
  AllZones.Add(GameObject.Find("P2 Range Aument"));
  AllZones.Add(GameObject.Find("P2 Siege Augment"));
  AllZones.Add(GameObject.Find("Climate Zone"));
 }
void  Update(){
    P1Hand.GetComponent<CanvasGroup>().blocksRaycasts = true;
    P2Hand.GetComponent<CanvasGroup>().blocksRaycasts = true;
}
 public enum Slot {DEAD, MELEE, RANGED, SIEGE, MAUGMENT, RAUGMENT, SAUGMENT, LEADER, CLIMATE,HANDCARD}
 public Slot typeofItem;
 
 public void OnBeginDrag(PointerEventData eventData){
   Debug.Log ("OnBeginDrag");
   parentToReturnTo = this.transform.parent;
   this.transform.SetParent( this.transform.parent.parent);
   GetComponent<CanvasGroup>().blocksRaycasts = false;
 }
 public void OnDrag(PointerEventData eventData){
   Debug.Log ("OnDrag");
   this.transform.position=eventData.position;
    }
 public void OnEndDrag(PointerEventData eventData){
   Debug.Log("OnEndDrag");
   this.transform.SetParent(parentToReturnTo);
   GetComponent<CanvasGroup>().blocksRaycasts = true;
   if(this.transform.parent.parent == GameObject.Find("Gwent Board").transform && this.transform.parent != P1Hand.transform && this.transform.parent != P2Hand.transform){
     HeroEffectList();
      Debug.Log("Efecto Activado");
   }
 }
 public void HeroEffectList(){
        switch(this.GetComponent<ThisCard>().cardName){
            case "Pablo":
            if(this.transform.parent == AllZones[0].transform){
            for(int i = 0; i < 3;i++){
                    for(int j = 0; j<AllZones[i].transform.childCount;j++){
                    if(AllZones[i].transform.GetChild(j).GetComponent<ThisCard>().thisSprite.name.Contains("Pablo")){
                      this.GetComponent<ThisCard>().power +=2;
                    }
                }
            }
            }
            else if(this.transform.parent == AllZones[3].transform){
            for(int i = 3; i < 6;i++){
                    for(int j = 0; j<AllZones[i].transform.childCount;j++){
                    if(AllZones[i].transform.GetChild(j).GetComponent<ThisCard>().thisSprite.name.Contains("Pablo")){
                         this.GetComponent<ThisCard>().power +=2;
                    }
                }
            }
            }
            break;
            case "Tyrone":
             if(this.transform.parent == AllZones[1].transform){
            for(int i = 0; i < 3;i++){
                    for(int j = 0; j<AllZones[i].transform.childCount;j++){
                    if(AllZones[i].transform.GetChild(j).GetComponent<ThisCard>().thisSprite.name.Contains("Tyrone")){
                      this.GetComponent<ThisCard>().power +=2;
                    }
                }
            }
            }
            else if(this.transform.parent == AllZones[4].transform){
            for(int i = 3; i < 6;i++){
                    for(int j = 0; j<AllZones[i].transform.childCount;j++){
                    if(AllZones[i].transform.GetChild(j).GetComponent<ThisCard>().thisSprite.name.Contains("Tyrone")){
                      this.GetComponent<ThisCard>().power +=2;
                    }
                }
            }
            }
            break;
            case "Uniqua":
             if(this.transform.parent == AllZones[0].transform){
            for(int i = 0; i < 3;i++){
                    for(int j = 0; j<AllZones[i].transform.childCount;j++){
                    if(AllZones[i].transform.GetChild(j).GetComponent<ThisCard>().thisSprite.name.Contains("Uniqua")){
                      this.GetComponent<ThisCard>().power +=2;
                    }
                }
            }
            }
            else if(this.transform.parent == AllZones[3].transform){
            for(int i = 3; i < 6;i++){
                    for(int j = 0; j<AllZones[i].transform.childCount;j++){
                    if(AllZones[i].transform.GetChild(j).GetComponent<ThisCard>().thisSprite.name.Contains("Uniqua")){
                        this.GetComponent<ThisCard>().power +=2;
                    }
                }
            }
            }
            break;
            case "Tasha":
             if(this.transform.parent == AllZones[2].transform){
            for(int i = 0; i < 3;i++){
                    for(int j = 0; j<AllZones[i].transform.childCount;j++){
                    if(AllZones[i].transform.GetChild(j).GetComponent<ThisCard>().thisSprite.name.Contains("Tasha")){
                      this.GetComponent<ThisCard>().power +=2;
                    }
                }
            }
            }
            else if(this.transform.parent == AllZones[5].transform){
            for(int i = 3; i < 6;i++){
                    for(int j = 0; j<AllZones[i].transform.childCount;j++){
                    if(AllZones[i].transform.GetChild(j).GetComponent<ThisCard>().thisSprite.name.Contains("Tasha")){
                       this.GetComponent<ThisCard>().power +=2;
                    }
                }
            }
            }
            break;
            case "Austin":
             if(this.transform.parent == AllZones[1].transform){
            for(int i = 0; i < 3;i++){
                    for(int j = 0; j<AllZones[i].transform.childCount;j++){
                    if(AllZones[i].transform.GetChild(j).GetComponent<ThisCard>().thisSprite.name.Contains("Austin")){
                        this.GetComponent<ThisCard>().power +=2;
                    }
                }
            }
            }
            else if(this.transform.parent == AllZones[4].transform){
            for(int i = 3; i < 6;i++){
                    for(int j = 0; j<AllZones[i].transform.childCount;j++){
                    if(AllZones[i].transform.GetChild(j).GetComponent<ThisCard>().thisSprite.name.Contains("Austin")){
                        this.GetComponent<ThisCard>().power +=2;
                    }
                }
            }
            }
            break;
            case "Oeste Marihuano":
            if(this.transform.parent == AllZones[7].transform){
            for(int i = 0;i<AllZones[1].transform.childCount;i++){
                PassButton.GetComponent<VictorySystem>().P1TotalPower +=2;
            }
            }
            else if(this.transform.parent == AllZones[10].transform){
             for(int i = 0;i<AllZones[4].transform.childCount;i++){
                PassButton.GetComponent<VictorySystem>().P2TotalPower +=2;
            }
            }
            break;
            case "Jungla Marihuana":
            if(this.transform.parent == AllZones[6].transform){
             for(int i = 0;i<AllZones[0].transform.childCount;i++){
                PassButton.GetComponent<VictorySystem>().P1TotalPower +=2;
            }
            }
            else if(this.transform.parent == AllZones[9].transform){
             for(int i = 0;i<AllZones[3].transform.childCount;i++){
                PassButton.GetComponent<VictorySystem>().P2TotalPower +=2;
            }
            }
            break;
            case "Caballeros Marihuanos":
            if(this.transform.parent == AllZones[8].transform){
             for(int i = 0;i<AllZones[2].transform.childCount;i++){
                PassButton.GetComponent<VictorySystem>().P1TotalPower +=2;
            }
            }
            else if(this.transform.parent == AllZones[11].transform){
             for(int i = 0;i<AllZones[5].transform.childCount;i++){
               PassButton.GetComponent<VictorySystem>().P2TotalPower +=2;
            }
            }
            break;
            case "Desierto Marihuano":
             for(int i = 0;i<AllZones[2].transform.childCount;i++){
               PassButton.GetComponent<VictorySystem>().P1TotalPower -=2;
            }
             for(int i = 0;i<AllZones[5].transform.childCount;i++){
                PassButton.GetComponent<VictorySystem>().P2TotalPower -=2;
            }
            PassButton.GetComponent<VictorySystem>().P1Points.text = PassButton.GetComponent<VictorySystem>().P1TotalPower.ToString();
            PassButton.GetComponent<VictorySystem>().P2Points.text = PassButton.GetComponent<VictorySystem>().P2TotalPower.ToString();
            break;
            case "Oceano Marihuano":
             for(int i = 0;i<AllZones[1].transform.childCount;i++){
               PassButton.GetComponent<VictorySystem>().P1TotalPower -=2;
               
            }
             for(int i = 0;i<AllZones[4].transform.childCount;i++){
                PassButton.GetComponent<VictorySystem>().P2TotalPower -=2;
            }
            PassButton.GetComponent<VictorySystem>().P1Points.text = PassButton.GetComponent<VictorySystem>().P1TotalPower.ToString();
            PassButton.GetComponent<VictorySystem>().P2Points.text = PassButton.GetComponent<VictorySystem>().P2TotalPower.ToString();
            break;
            case "Nieve Esnifadora":
             for(int i = 0;i<AllZones[0].transform.childCount;i++){
                PassButton.GetComponent<VictorySystem>().P1TotalPower -=2;
            }
             for(int i = 0;i<AllZones[3].transform.childCount;i++){
               PassButton.GetComponent<VictorySystem>().P2TotalPower -=2;
            }
            PassButton.GetComponent<VictorySystem>().P1Points.text = PassButton.GetComponent<VictorySystem>().P1TotalPower.ToString();
            PassButton.GetComponent<VictorySystem>().P2Points.text = PassButton.GetComponent<VictorySystem>().P2TotalPower.ToString();
            break;
            case "Sherif Pablo":
            if(this.transform.parent == AllZones[1].transform){
            PassButton.GetComponent<VictorySystem>().P2TotalPower -=1;
            }
            else if(this.transform.parent == AllZones[4].transform){
            PassButton.GetComponent<VictorySystem>().P1TotalPower -=1;    
            }
            break;
            case "Vaquero Tyrone":
            if(this.transform.parent == AllZones[1].transform){
               for(int i = 0;i<AllZones[12].transform.childCount;i++){
                if(AllZones[12].transform.GetChild(i).GetComponent<ThisCard>().name == "Desierto Marihuano"){
                    this.GetComponent<ThisCard>().power +=2;
                }
               }
            }
            break;
            case "Uniqua La Loca":
            if(this.transform.parent == AllZones[2].transform){
               for(int i=0;i<AllZones[1].transform.childCount;i++){
                if(AllZones[1].transform.GetChild(i).GetComponent<ThisCard>().name == "Sherif Pablo"){
                    this.GetComponent<ThisCard>().power +=3;
                }
               }
            }
            else if(this.transform.parent == AllZones[5].transform){
               for(int i=0;i<AllZones[4].transform.childCount;i++){
                if(AllZones[4].transform.GetChild(i).GetComponent<ThisCard>().name == "Sherif Pablo"){
                    this.GetComponent<ThisCard>().power +=3;
                }
               }
            }
            break;
            case "Pablo Buscador de Marihuana":
            if(this.transform.parent == AllZones[0].transform){
                 for(int i=0; i<P1Deck.GetComponent<Draw>().CardsInDeck.Count;i++){
                    if(P1Deck.GetComponent<Draw>().CardsInDeck[i].GetComponent<ThisCard>().cardType == "[CL]"){
                        GameObject drawcard = Instantiate(P1Deck.GetComponent<Draw>().CardsInDeck[i]);
                        drawcard.transform.SetParent(P1Hand.transform);
                        P1Deck.GetComponent<Draw>().CardsInDeck.RemoveAt(i);
                        break;
                    }
                 }
            }
            else if(this.transform.parent == AllZones[3].transform){
                 for(int i=0; i<P2Deck.GetComponent<Draw>().CardsInDeck.Count;i++){
                    if(P2Deck.GetComponent<Draw>().CardsInDeck[i].GetComponent<ThisCard>().cardType == "[CL]"){
                         GameObject drawcard = Instantiate(P1Deck.GetComponent<Draw>().CardsInDeck[i]);
                        drawcard.transform.SetParent(P2Hand.transform);
                        P1Deck.GetComponent<Draw>().CardsInDeck.RemoveAt(i);
                        break;
                    }
                 }
            }
            break;
            case "Tyrone Buscador de Marihuana":
             if(this.transform.parent == AllZones[0].transform){
                 for(int i=0; i<P1Deck.GetComponent<Draw>().CardsInDeck.Count;i++){
                    if(P1Deck.GetComponent<Draw>().CardsInDeck[i].GetComponent<ThisCard>().cardType == "[CL]"){
                        GameObject drawcard = Instantiate(P1Deck.GetComponent<Draw>().CardsInDeck[i]);
                        drawcard.transform.SetParent(P1Hand.transform);
                        P1Deck.GetComponent<Draw>().CardsInDeck.RemoveAt(i);
                        break;
                    }
                 }
            }
            else if(this.transform.parent == AllZones[3].transform){
                 for(int i=0; i<P2Deck.GetComponent<Draw>().CardsInDeck.Count;i++){
                    if(P2Deck.GetComponent<Draw>().CardsInDeck[i].GetComponent<ThisCard>().cardType == "[CL]"){
                         GameObject drawcard = Instantiate(P2Deck.GetComponent<Draw>().CardsInDeck[i]);
                        drawcard.transform.SetParent(P2Hand.transform);
                        P1Deck.GetComponent<Draw>().CardsInDeck.RemoveAt(i);
                        break;
                    }
                 }
            } 
            break;
            case "Super Austin":
             if(this.transform.parent == AllZones[0].transform){
            for(int i = 0; i < 3;i++){
                    for(int j = 0; j<AllZones[i].transform.childCount;j++){
                    if(AllZones[i].transform.GetChild(j).GetComponent<ThisCard>().thisSprite.name.Contains("Austin")){
                        this.GetComponent<ThisCard>().power +=1;
                    }
                }
            }
            }
            else if(this.transform.parent == AllZones[3].transform){
            for(int i = 3; i < 6;i++){
                    for(int j = 0; j<AllZones[i].transform.childCount;j++){
                    if(AllZones[i].transform.GetChild(j).GetComponent<ThisCard>().name.Contains("Austin")){
                        this.GetComponent<ThisCard>().power +=1;
                    }
                }
            }
            }
            break;
            case "SherlockNiqua":
            if(this.transform.parent == AllZones[1].transform){
                 for(int i=0; i<P1Deck.GetComponent<Draw>().CardsInDeck.Count;i++){
                    if(P1Deck.GetComponent<Draw>().CardsInDeck[i].GetComponent<ThisCard>().cardType == "[RA]"){
                        GameObject drawcard = Instantiate(P1Deck.GetComponent<Draw>().CardsInDeck[i]);
                        drawcard.transform.SetParent(P1Hand.transform);
                        P1Deck.GetComponent<Draw>().CardsInDeck.RemoveAt(i);
                        break;
                    }
                 }
            }
            else if(this.transform.parent == AllZones[4].transform){
                 for(int i=0; i<P2Deck.GetComponent<Draw>().CardsInDeck.Count;i++){
                    if(P2Deck.GetComponent<Draw>().CardsInDeck[i].GetComponent<ThisCard>().cardType == "[MA]"){
                         GameObject drawcard = Instantiate(P1Deck.GetComponent<Draw>().CardsInDeck[i]);
                        drawcard.transform.SetParent(P2Hand.transform);
                        P1Deck.GetComponent<Draw>().CardsInDeck.RemoveAt(i);
                        break;
                    }
                 }
            } 
            break;
            case "Patio Marihuano":
            
            for(int i=0;i<6;i++){
                for(int j=0;j<AllZones[i].transform.childCount;j++){
                  fieldtotalpower = fieldtotalpower + AllZones[i].transform.GetChild(j).GetComponent<ThisCard>().power;
                  promdiv +=1;
                }
            }
            fieldtotalpower = fieldtotalpower/promdiv;
            if(PassButton.GetComponent<VictorySystem>().IsYourTurn == true){
                promdiv =0;
                finalizarturno();
            for(int i=0;i<3;i++){
                for(int j=0;j<AllZones[i].transform.childCount;j++){
                    promdiv +=1;
                }
            }
            PassButton.GetComponent<VictorySystem>().P1TotalPower = fieldtotalpower * promdiv;
            PassButton.GetComponent<VictorySystem>().P1Points.text = PassButton.GetComponent<VictorySystem>().P1TotalPower.ToString();
            PassButton.GetComponent<VictorySystem>().P2Points.text = PassButton.GetComponent<VictorySystem>().P2TotalPower.ToString();
            }
            else if(PassButton.GetComponent<VictorySystem>().IsYourTurn == false){
                finalizarturno();
                promdiv = 0;
                for(int i=3;i<6;i++){
                for(int j=0;j<AllZones[i].transform.childCount;j++){
                    promdiv +=1;
                }
            }
           PassButton.GetComponent<VictorySystem>().P2TotalPower = fieldtotalpower * promdiv;
           PassButton.GetComponent<VictorySystem>().P1Points.text = PassButton.GetComponent<VictorySystem>().P1TotalPower.ToString();
            PassButton.GetComponent<VictorySystem>().P2Points.text = PassButton.GetComponent<VictorySystem>().P2TotalPower.ToString();
            }
            this.GetComponent<Button>().interactable = false;
            break;
            case "Austin Thief":
            if(PassButton.GetComponent<VictorySystem>().IsYourTurn == true){
                this.transform.SetParent(P1Cementery.transform);
                this.GetComponent<Button>().interactable = false;
            for(int i=6;i<9;i++){
                if(AllZones[i].transform.childCount == 1){
                    AllZones[i].transform.GetChild(0).transform.SetParent(P1Hand.transform);
                    PassButton.GetComponent<VictorySystem>().IsYourTurn = false;
                    break;
                }
            }
            }
            else if(PassButton.GetComponent<VictorySystem>().IsYourTurn == false){
                this.transform.SetParent(P2Cementery.transform);
                this.GetComponent<Button>().interactable = false;
            for(int i=9;i<12;i++){
                if(AllZones[i].transform.childCount == 1){
                    AllZones[i].transform.GetChild(0).transform.SetParent(P2Hand.transform);
                    PassButton.GetComponent<VictorySystem>().IsYourTurn = true;
                    break;
                }
            }    
            }
            break;
            case "Doctor Tyrone":
            if(PassButton.GetComponent<VictorySystem>().IsYourTurn == true){
                this.transform.SetParent(P1Cementery.transform);
                this.GetComponent<Button>().interactable = false;
            for(int i=0;i<3;i++){
                if(AllZones[i].transform.childCount == 1){
                    AllZones[i].transform.GetChild(0).transform.SetParent(P1Hand.transform);
                    PassButton.GetComponent<VictorySystem>().IsYourTurn = false;
                    break;
                }
            }
            }
            else if(PassButton.GetComponent<VictorySystem>().IsYourTurn == false){
                this.transform.SetParent(P2Cementery.transform);
                this.GetComponent<Button>().interactable = false;
            for(int i=3;i<6;i++){
                if(AllZones[i].transform.childCount == 1){
                    AllZones[i].transform.GetChild(0).transform.SetParent(P2Hand.transform);
                    PassButton.GetComponent<VictorySystem>().IsYourTurn = true;
                    break;
                }
            }    
            }
            break;
        }
        }
     public void finalizarturno(){
        if(PassButton.GetComponent<VictorySystem>().IsYourTurn == true){
            PassButton.GetComponent<VictorySystem>().IsYourTurn = false; 
            PassButton.GetComponent<VictorySystem>().P2Image.GetComponent<Image>().color = new Color32(255,255,255,255);
            PassButton.GetComponent<VictorySystem>().P1Image.GetComponent<Image>().color = new Color32(51,51,51,255); 
         for(int i =0;i<AllZones.Count -1;i++){
            if(i<6){
                    AllZones[i].GetComponent<CanvasGroup>().blocksRaycasts = false;
                }
             else if(i>=6 && i<12){
                    AllZones[i].GetComponent<CanvasGroup>().blocksRaycasts = true;
             }
         }       
        }
        else if(PassButton.GetComponent<VictorySystem>().IsYourTurn == false){
            PassButton.GetComponent<VictorySystem>().IsYourTurn = true;
            PassButton.GetComponent<VictorySystem>().P1Image.GetComponent<Image>().color = new Color32(255,255,255,255);
            PassButton.GetComponent<VictorySystem>().P2Image.GetComponent<Image>().color = new Color32(51,51,51,255);
          for(int i =0;i<AllZones.Count -1;i++){
            if(i<6){
                    AllZones[i].GetComponent<CanvasGroup>().blocksRaycasts = true;
                }
             else if(i>=6 && i<12){
              AllZones[i].GetComponent<CanvasGroup>().blocksRaycasts = false;
             }
         }
        }
     }
}

