using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //CONFIG
    [SerializeField] float projectileSpeed;
    [SerializeField] float damage = 100f;

    //CACHE

    //STATE

    //INITIALIZATION

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.right* projectileSpeed* Time.deltaTime);//direction x and 0y/ speed
    }

     private void OnTriggerEnter2D(Collider2D otherCollider) {
         var Health = otherCollider.GetComponent<Health>();// storing the script health in a variable.
         var attacker = otherCollider.GetComponent<Attacker>();
         if (attacker && Health )//if it has both these components
         {
             Health.DealDamage(damage); 
             Destroy(gameObject);//destroy self

         }
         //health method called deal damage
         Debug.Log("i hit something " + otherCollider.name);
         
        
    }
}
