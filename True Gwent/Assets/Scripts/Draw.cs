using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Draw : MonoBehaviour
{
    public int DeckSize;
    public GameObject Hand;
    private List<GameObject> CardsInHand { get; set; }
    public List<GameObject> CardsInDeck;
    private int randomil;
    public int drawedcard;
    public GameObject PassButton;
    void Start()
    {
      drawedcard = 0;
        for(int b = 0; b<40;b++){
            if(b >=0 && b <= 4){
              CardsInDeck[b] = Instantiate(Resources.Load("Golden Hero") as GameObject);
              CardsInDeck[b].GetComponent<ThisCard>().thisId = b;
            }
            else if(b == 5){
              CardsInDeck[b] = Instantiate(Resources.Load("Leader") as GameObject);
              CardsInDeck[b].GetComponent<ThisCard>().thisId = b;
            }
            else if(b > 5 && b<=8){
              CardsInDeck[b] = Instantiate(Resources.Load("Augment") as GameObject);
              CardsInDeck[b].GetComponent<ThisCard>().thisId = b;
            }
            else if(b>8 && b <=11){
              CardsInDeck[b] = Instantiate(Resources.Load("Climate") as GameObject);
              CardsInDeck[b].GetComponent<ThisCard>().thisId = b;
            }
            else if(b == 12 || b ==13){
              CardsInDeck[b] = Instantiate(Resources.Load("Lure") as GameObject);
              CardsInDeck[b].GetComponent<ThisCard>().thisId = b;
            }
            else{
              CardsInDeck[b] = Instantiate(Resources.Load("SilverHero") as GameObject);
              CardsInDeck[b].GetComponent<ThisCard>().thisId = b;
            }           
        }
        
        
        CardsInHand = new();
        DeckSize = 40;
    }
    void Update(){
    }

    public void OnClick()
    {
      randomil = Random.Range(0,CardsInDeck.Count);
      GameObject drawcard = Instantiate(CardsInDeck[randomil]);
      if(drawcard.GetComponent<ThisCard>().typeText.text == "[M]"){
        drawcard.GetComponent<Draggable>().typeofItem = Draggable.Slot.MELEE;
      }
      else if(drawcard.GetComponent<ThisCard>().typeText.text == "[R]"){
        drawcard.GetComponent<Draggable>().typeofItem = Draggable.Slot.RANGED;
      }
      else if(drawcard.GetComponent<ThisCard>().typeText.text == "[S]"){
        drawcard.GetComponent<Draggable>().typeofItem = Draggable.Slot.SIEGE;
      }
      else if(drawcard.GetComponent<ThisCard>().typeText.text == "[MA]"){
        drawcard.GetComponent<Draggable>().typeofItem = Draggable.Slot.MAUGMENT;
      }
      else if(drawcard.GetComponent<ThisCard>().typeText.text == "[RA]"){
        drawcard.GetComponent<Draggable>().typeofItem = Draggable.Slot.RAUGMENT;
      }
      else if(drawcard.GetComponent<ThisCard>().typeText.text == "[SA]"){
        drawcard.GetComponent<Draggable>().typeofItem = Draggable.Slot.SAUGMENT;
      }
      else if(drawcard.GetComponent<ThisCard>().typeText.text == "[CL]"){
        drawcard.GetComponent<Draggable>().typeofItem = Draggable.Slot.CLIMATE;
      }
      drawcard.transform.SetParent(Hand.transform);
      CardsInDeck.RemoveAt(randomil);
      drawedcard +=1;
      if(drawedcard == 10 && PassButton.GetComponent<VictorySystem>().P1GainedRounds == 0 && PassButton.GetComponent<VictorySystem>().P2GainedRounds == 0){
        this.GetComponent<Button>().interactable = false;
      }
      else if(drawedcard == 2 && PassButton.GetComponent<VictorySystem>().P1GainedRounds == 1 || PassButton.GetComponent<VictorySystem>().P2GainedRounds == 1){
        this.GetComponent<Button>().interactable = false;
      }
    }
}