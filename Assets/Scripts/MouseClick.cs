using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour// SNAPS TO GRID
{
    // Start is called before the first frame update
 
Defender defender;
    // in other words if you click this game object (this is on acollider) then the rest of the code will run. 
        private void OnMouseDown() {
            AttemptToPlaceDefenderAt(GetSquareClicked());
            Debug.Log("Mouse Clicked");//this can be used to check if an object has been clicked. make something happen if this gameObject the script is on is clicked
            // this is on a collider that marks the play area.
        }
        public void SetSelectedDefender(Defender defenderToSelect){
            defender = defenderToSelect;
        }
        private void AttemptToPlaceDefenderAt(Vector2 gridPos){
            var StarDisplay = FindObjectOfType<StarDisplay>();
            int defenderCost = defender.GetStarCost();
            //if we have enough money then spawn the defender and spend the stars
            if (StarDisplay.HaveEnoughStars(defenderCost)){
                SpawnDefender(gridPos);
                StarDisplay.SpendStars(defenderCost);
            }

        }
        private Vector2 GetSquareClicked(){// its not ovid, it asks to return a vector 2
            Vector2 clickPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);// converts it to relative to screen
            Vector2 gridPos = SnapToGrid(worldPos);
            return gridPos;
            
        }
        private Vector2 SnapToGrid(Vector2 rawWorldPos){
            float newX = Mathf.RoundToInt(rawWorldPos.x);
            float newY =Mathf.RoundToInt(rawWorldPos.y);
            return new Vector2(newX,newY);

        }
        private void SpawnDefender(Vector2 roundedPos){
            Defender newDefender = Instantiate(defender, roundedPos, Quaternion.identity) as Defender;
        }
    
}
