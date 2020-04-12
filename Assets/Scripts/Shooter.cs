using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
   //CONFIG



   //CACHE

[SerializeField] GameObject projectile;
[SerializeField] GameObject gunPosition;
   //STATE


   //INITIALIZATION





   //GENERAL METHODS

   public void Fire(){//empty method 
   //this is all done in an event in the animation itself at a certain frame
       Instantiate(projectile, gunPosition.transform.position, Quaternion.identity);//no rotation, just the rotation that it arrives with
   }
}
