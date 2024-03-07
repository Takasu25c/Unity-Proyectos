using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
 public Transform parentToReturnTo = null;

 public enum Slot {P1DEAD, P1MELEE, P1RANGED, P1SIEGE, P1MAUGMENT, P1RAUGMENT, P1SAUGMENT, P1LEADER, CLIMATE, P2DEAD, P2MELEE, P2RANGED, P2SIEGE, P2MAUGMENT, P2RAUGMENT, P2SAUGMENT, P2LEADER, HANDCARD}
 public Slot typeofItem = Slot.P1DEAD;
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
 }

}

