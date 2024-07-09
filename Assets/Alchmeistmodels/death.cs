using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if transform.position.y is less than -25 then reload active scene
        if(transform.position.y < -40){
            //use scenemanageent to relaod scene

            ReloadActiveScene();
        }
        
        
    }
    public void ReloadActiveScene()
    {
        // Get the active scene and reload it
        Scene activeScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(activeScene.name);
    }
}
