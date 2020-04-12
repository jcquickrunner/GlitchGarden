using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] int starCost = 100;
   public void AddStars(int amount){
       FindObjectOfType<StarDisplay>().AddStars(amount);
   }

   public int GetStarCost(){
       return starCost;

   }
}
