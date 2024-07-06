using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class SceneController : MonoBehaviour
{
    public Button nextLevelButton;
    public Button previousLevelButton;
    

    void Start()
    {
        

        // Add listeners to the buttons
        nextLevelButton.onClick.AddListener(LoadNextScene);
        previousLevelButton.onClick.AddListener(LoadPreviousScene);
    }
    //create the LoadNextScene function and LoadPreviousScene function , just detect the scene index of current scene and load the next scene and previous scene
    void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    //now create the LoadPreviousScene function
    void LoadPreviousScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex - 1);
    }

   
}
