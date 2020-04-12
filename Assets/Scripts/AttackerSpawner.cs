using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    //CONFIG
[SerializeField] float minSpawnDelay = 3f;
[SerializeField]  float MaxSpawnDelay = 6f;
[SerializeField] Attacker attackerPrefab;
    bool spawn = true;
    //CACHE
    IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay,MaxSpawnDelay));//delay with range
            SpawnAttacker();

        }

    }
    private void SpawnAttacker(){
        Instantiate(attackerPrefab, transform.position,transform.rotation);// spawn here
    }



    //STATE

    //INITIALIZATION
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

    }

}