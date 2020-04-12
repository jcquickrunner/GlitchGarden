using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class LevelLoader : MonoBehaviour
{
    //CONFIG
    
     int currentSceneIndex;
    [SerializeField] int waitInSeconds = 5;

//CACHE


//STATE

 //INITIALIZATION

   
   
    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex= SceneManager.GetActiveScene().buildIndex;// wait before going a function
        if (currentSceneIndex == 0){
            StartCoroutine(WaitForTime());
        }
    }
    IEnumerator WaitForTime(){
        yield return new WaitForSeconds(waitInSeconds);
        LoadNextScene();
    }
public void LoadNextScene(){
    SceneManager.LoadScene(currentSceneIndex + 1);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
