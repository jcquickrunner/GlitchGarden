using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{



    //CONFIGURATION
[Range(0f,5f)]
[SerializeField] float CurrentwalkSpeed = 2f;
float speed;



    //CACHE


    //STATE


    //INITIALIZATION
    // Start is called before the first frame update
   
    void Update()
    {
        transform.Translate(Vector2.left *  CurrentwalkSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed){
        CurrentwalkSpeed = speed;

    }
}
