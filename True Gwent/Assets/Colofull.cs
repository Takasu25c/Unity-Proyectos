using System.Collections;
using System.Collections.Generic;
using System.Resources;
using JetBrains.Annotations;
using TMPro;
using TMPro.Examples;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;
public class Colofull : MonoBehaviour
{
  private Image image;
  public float speed;
  private float hue;
  private float sat;
  private float bri;
  public bool randomize;
  public bool invertible;
  void Start(){
    image = GetComponent<Image>();
    if(randomize){
      hue = Random.Range(0,1);
    }
    sat =1;
    bri = 1;
    image.material.color = Color.HSVToRGB(hue,sat,bri);
  }
  void Update(){
    Color.RGBToHSV(image.material.color, out hue, out sat, out bri);
    if(invertible){
     hue += speed/10000;
    if(hue <= 0){
      hue = 0.99f;
    }
    }
    else{
    hue += speed/10000;
    if(hue >=1){
      hue = 0;
    }
    image.material.color = Color.HSVToRGB(hue,sat,bri);
    }
  }
 }
