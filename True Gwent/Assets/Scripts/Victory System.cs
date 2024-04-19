using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictorySystem : MonoBehaviour
{
    public List<Image> RoundCounters = new List<Image>();
    public int P1TotalPower;
    public int P2TotalPower;
    public TMP_Text VictoryText;
    public int P1GainedRounds;
    public int P2GainedRounds;
    public GameObject P1Deck;
    public GameObject P2Deck;
    public List<GameObject> AllZones = new List<GameObject>();
    public int[] AllZonesCounters = new int[13];
    public GameObject Returnbutton;
    public TMP_Text Returnbuttonimage;
    public GameObject P1Cementery;
    public GameObject P2Cementery;
    public Image P1Image;
    public Image P2Image;
    public bool IsYourTurn;
    public int PassCounter =0;
    public TMP_Text P1Points;
    public TMP_Text P2Points;
    private List<string> NameKeeper = new List<string>();

    void Start()
    {
        IsYourTurn = true;
        for(int i=3;i<6;i++){
            AllZones[i].GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
        P2Image.GetComponent<Image>().color = new Color32(51,51,51,255);
        for(int u=0;u<AllZonesCounters.Length;u++){
            AllZonesCounters[u] = 0;
        }
        P1TotalPower = 0;
        P2TotalPower = 0;
        P1GainedRounds = 0;
        P2GainedRounds = 0;
        for(int z=0; z<RoundCounters.Count;z++){
            RoundCounters[z].GetComponent<Image>().color = new Color32(0,0,0,0);
        }
        Returnbutton.GetComponent<Image>().color = new Color32(0,0,0,0);
        Returnbuttonimage.GetComponent<TMP_Text>().color = new Color32(0,0,0,0);
        Returnbutton.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    void Update()
    {
    if(IsYourTurn == true){
        for(int p=0;p<6;p++){
            if(AllZones[p].transform.childCount == AllZonesCounters[p]+1){
                P1TotalPower = P1TotalPower + AllZones[p].transform.GetChild(AllZonesCounters[p]).GetComponent<ThisCard>().power;
                 AllZonesCounters[p] +=1;
                 CountPoints();
                PassCounter =0;
                P1Image.GetComponent<Image>().color = new Color32(51,51,51,255);
                P2Image.GetComponent<Image>().color = new Color32(255,255,255,255);
                for(int o=0;o<AllZones.Count-1;o++){
                     if(o <=5){
                        AllZones[o].GetComponent<CanvasGroup>().blocksRaycasts = false;
                     }
                     if(o >5){
                        AllZones[o].GetComponent<CanvasGroup>().blocksRaycasts = true;
                     }
                }
                IsYourTurn = false;
            }
            else if(AllZones[12].transform.childCount == AllZonesCounters[12]+1){
                 AllZonesCounters[12] +=1;
                 CountPoints();
                PassCounter =0;
                P1Image.GetComponent<Image>().color = new Color32(51,51,51,255);
                P2Image.GetComponent<Image>().color = new Color32(255,255,255,255);
                for(int o=0;o<AllZones.Count-1;o++){
                     if(o <=5){
                        AllZones[o].GetComponent<CanvasGroup>().blocksRaycasts = false;
                     }
                     if(o >5){
                        AllZones[o].GetComponent<CanvasGroup>().blocksRaycasts = true;
                     }
                }
                IsYourTurn = false;
            }
        }
       }
       else if(IsYourTurn == false){
        for(int t = 6;t <=11;t++){
            if(AllZones[t].transform.childCount == AllZonesCounters[t]+1){
                P2TotalPower = P2TotalPower + AllZones[t].transform.GetChild(AllZonesCounters[t]).GetComponent<ThisCard>().power;
                CountPoints();
                AllZonesCounters[t] +=1;  
                PassCounter = 0;
                P2Image.GetComponent<Image>().color = new Color32(51,51,51,255);
                P1Image.GetComponent<Image>().color = new Color32(255,255,255,255);
                for(int o=0;o<AllZones.Count-1;o++){
                     if(o <=5){
                        AllZones[o].GetComponent<CanvasGroup>().blocksRaycasts = true;
                     }
                     if(o >5){
                        AllZones[o].GetComponent<CanvasGroup>().blocksRaycasts = false;
                     }
                }
                IsYourTurn = true;
            }
            else if(AllZones[12].transform.childCount == AllZonesCounters[12]+1){
                 AllZonesCounters[12] +=1;
                 CountPoints();
                PassCounter =0;
                P1Image.GetComponent<Image>().color = new Color32(51,51,51,255);
                P2Image.GetComponent<Image>().color = new Color32(255,255,255,255);
                for(int o=0;o<AllZones.Count-1;o++){
                     if(o <=5){
                        AllZones[o].GetComponent<CanvasGroup>().blocksRaycasts = false;
                     }
                     if(o >5){
                        AllZones[o].GetComponent<CanvasGroup>().blocksRaycasts = true;
                     }
                }
                IsYourTurn = false;
            }
        }
       }
    }
    public void Victory(){
        if(PassCounter == 2){
        if(P1TotalPower > P2TotalPower){
            P1GainedRounds +=1;
            P1Deck.GetComponent<Draw>().drawedcard = 0;
            P2Deck.GetComponent<Draw>().drawedcard = 0;
            RoundCounters[0].GetComponent<Image>().color = new Color32(255,255,255,255);
            P1Deck.GetComponent<Button>().interactable = true;
            P2Deck.GetComponent<Button>().interactable = true;
            PassCounter = 0;
            P1TotalPower =0;
            P2TotalPower =0;
            P1Points.text = "";
            P2Points.text = "";
            for(int u=0;u<AllZonesCounters.Length;u++){
             AllZonesCounters[u] = 0;
            }
          for(int i = 0;i<AllZones.Count - 1;i++){
             if(i<6){
                for(int j= AllZones[i].transform.childCount - 1; j>=0;j--){
                    AllZones[i].transform.GetChild(j).SetParent(P1Cementery.transform);
                }
             }
            else if(i>=6){
                for(int j = AllZones[i].transform.childCount - 1;j>=0;j--){
                     AllZones[i].transform.GetChild(j).SetParent(P2Cementery.transform);
                }
             }
             else if(i == 12){
                for(int j= AllZones[i].transform.childCount - 1; j>=0;j--){
                    AllZones[i].transform.GetChild(j).SetParent(P1Cementery.transform);
                }
             }
          }
            if(P1GainedRounds == 2){
            RoundCounters[1].GetComponent<Image>().color = new Color32(255,255,255,255);
            Returnbutton.GetComponent<CanvasGroup>().blocksRaycasts = true;
            VictoryText.text = "P1 Wins The Game";
            Returnbutton.GetComponent<Image>().color = new Color32(255,0,0,255);
            Returnbuttonimage.GetComponent<Image>().color = new Color32(255,255,255,255);
            Returnbutton.GetComponent<CanvasGroup>().blocksRaycasts = true;
            }
        }
        else if(P1TotalPower < P2TotalPower){
            P2GainedRounds +=1;
            P1Deck.GetComponent<Draw>().drawedcard = 0;
            P2Deck.GetComponent<Draw>().drawedcard = 0;
            RoundCounters[2].GetComponent<Image>().color = new Color32(255,255,255,255);
            P1Deck.GetComponent<Button>().interactable = true;
            P2Deck.GetComponent<Button>().interactable = true;
            PassCounter = 0;
            P2TotalPower = 0;
            P1TotalPower = 0;
            P1Points.text = "";
            P2Points.text = "";
           for(int u=0;u<AllZonesCounters.Length;u++){
             AllZonesCounters[u] = 0;
            }
           for(int i = 0;i<AllZones.Count;i++){
             if(i<6){
                for(int j= AllZones[i].transform.childCount - 1; j>=0;j--){
                    AllZones[i].transform.GetChild(j).SetParent(P1Cementery.transform);
                }
             }
             else if(i>=6){
                for(int j = AllZones[i].transform.childCount - 1;j>=0;j--){
                     AllZones[i].transform.GetChild(j).SetParent(P2Cementery.transform);
                }
             }
             else if(i == 12){
                for(int j= AllZones[i].transform.childCount - 1; j>=0;j--){
                    AllZones[i].transform.GetChild(j).SetParent(P1Cementery.transform);
                }
             }
          }
            if(P2GainedRounds == 2){
            RoundCounters[3].GetComponent<Image>().color = new Color32(255,255,255,255);
            Returnbutton.GetComponent<CanvasGroup>().blocksRaycasts = true;
            VictoryText.text = "P2 Wins The Game";
            Returnbutton.GetComponent<Image>().color = new Color32(255,0,0,255);
            Returnbuttonimage.GetComponent<Image>().color = new Color32(255,255,255,255);
            }
            
        }
        else if(P1TotalPower == P2TotalPower){
            P1Deck.GetComponent<Button>().interactable = true;
            P2Deck.GetComponent<Button>().interactable = true;
            for(int s=0;s<AllZones.Count;s++){
            AllZones[s].GetComponent<CanvasGroup>().blocksRaycasts = true;
             }
             for(int u=0;u<AllZonesCounters.Length;u++){
             AllZonesCounters[u] = 0;
            }
           for(int i = 0;i<AllZones.Count - 1;i++){
             if(i<6){
                for(int j= AllZones[i].transform.childCount - 1; j>=0;j--){
                    AllZones[i].transform.GetChild(j).SetParent(P1Cementery.transform);
                }
             }
             if(i>=6){
                for(int j = AllZones[i].transform.childCount - 1;j<12;j--){
                     AllZones[i].transform.GetChild(j).SetParent(P2Cementery.transform);
                }
             }
          }
        }
       }
    }
    public void EndTurn(){
        if(IsYourTurn == true){
            IsYourTurn = false;
            PassCounter+=1;    
            P2Image.GetComponent<Image>().color = new Color32(255,255,255,255);
            P1Image.GetComponent<Image>().color = new Color32(51,51,51,255); 
         for(int i =0;i<AllZones.Count -1;i++){
            if(i<6){
                    AllZones[i].GetComponent<CanvasGroup>().blocksRaycasts = false;
                }
             else if(i>=6){
                    AllZones[i].GetComponent<CanvasGroup>().blocksRaycasts = true;
             }
         }       
        }
        else if(IsYourTurn == false){
            IsYourTurn = true;
            PassCounter+=1;
            P1Image.GetComponent<Image>().color = new Color32(255,255,255,255);
            P2Image.GetComponent<Image>().color = new Color32(51,51,51,255);
          for(int i =0;i<AllZones.Count -1;i++){
            if(i<6){
                    AllZones[i].GetComponent<CanvasGroup>().blocksRaycasts = true;
                }
             else if(i>=6){
              AllZones[i].GetComponent<CanvasGroup>().blocksRaycasts = false;
             }
         }
        }
    }
     public void CountPoints(){
        if(IsYourTurn == true){
         P1Points.text = P1TotalPower.ToString();
        }
       else if(IsYourTurn == false){
         P2Points.text = P2TotalPower.ToString();
       }
      
    }
}
