using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nextlevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //istrigger is on of the attached gameobjce t , now whenever player collides then after 2 seconds debug log "go"
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            Debug.Log("go");
            StartCoroutine(LoadNextLevel());
        }
    }
    //where is your coroutine function
    IEnumerator LoadNextLevel(){
        yield return new WaitForSeconds(2);
        Debug.Log("load next level");
        
    
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    
    }
}
