using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour// CONTROLS THE SWITCHING OF COLORS ON THE BUTTONS
{
    //CONFIG
    [SerializeField] Defender defenderPrefab;
 private void OnMouseDown() {
     var buttons = FindObjectsOfType<DefenderButton>();//this is a collection
     foreach(DefenderButton button in buttons){
         button.GetComponent<SpriteRenderer>().color = new Color32(34,34,34,255);//first switch to the grayed out version version
     }
     GetComponent<SpriteRenderer>().color = Color.white; //on click change color back to normal
 FindObjectOfType<MouseClick>().SetSelectedDefender(defenderPrefab);
     //ohhhhhhhhh so every time you click on a button it gets turned white and the other one is grayed out. if i click on This Button, it turns white and the other turns gray
 }


}
