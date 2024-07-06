using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pausemenu : MonoBehaviour
{
    public GameObject pausePanel;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseMenuOpen(){
       if(pausePanel.activeSelf){
           pausePanel.SetActive(false);
         }else{
           pausePanel.SetActive(true);
         }   
    }
    //create a void function to open a scene 
    public void OpenScene(){
        SceneManager.LoadScene("mainmenu");
    }
    //create a void function to reload active scene
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
