using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClimateZoneScript : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler 
{
  public Draggable.Slot typeofItem = Draggable.Slot.HANDCARD;
  public void OnPointerEnter(PointerEventData eventData){
    Debug.Log("OnPointerEnter");
    if(this.transform.childCount == 3){
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
      }
    public void OnPointerExit(PointerEventData eventData){
    Debug.Log("OnPointerExit");  }
  public void OnDrop(PointerEventData eventData){
    Debug.Log ("On Drop To");
    Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null){
          if(typeofItem == d.typeofItem || typeofItem == Draggable.Slot.HANDCARD){
          d.parentToReturnTo = this.transform;
          } 
        }
  }
}