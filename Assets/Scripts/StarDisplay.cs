using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class StarDisplay : MonoBehaviour
{
  Text starText;// get component of type text within the object this script is applied to
  //CONFIG 
  [SerializeField] int stars = 100;
  
    // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay(){
      starText.text =stars.ToString();// change the text in this text object to the int at the top
    }

    public bool HaveEnoughStars(int amount){
      return stars >= amount;//returns true if the interger at the top stars is greater than or equal to amount
    }
public void AddStars(int amount){
  stars += amount;
  UpdateDisplay();
  
}

public void SpendStars(int amount){// so long as we have enough to substract without getting under 0 then do the rest of the code
  if (stars >= amount){
stars -= amount;
  UpdateDisplay();
  }
  
}




}
