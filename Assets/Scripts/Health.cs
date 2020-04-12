using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //CONFIG
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;
    //CACHE
    //STATE
    //INITIALIZATION
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DealDamage(float damage){
        health -= damage;
        if(health <= 0){
            TrigggerDeathVfX();
            Destroy(gameObject);// destroy game object that this is attached to. game object is generic. for example gameObject lizard vs Lizard(object or prefab) lizard 
        }

    }
    private void TrigggerDeathVfX(){
        if(!deathVFX){return;} 
        GameObject deathVFXObject= Instantiate(deathVFX, transform.position, Quaternion.identity);
        Destroy(deathVFXObject,2f);// if theres nothing then dont worry unity everything will be fine
    }
}
