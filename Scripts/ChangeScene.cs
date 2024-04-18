using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
public void LoadScene()
{
    SceneManager.LoadScene("Book");
}

public void ExitApp()
{
    Application.Quit();
    Debug.Log("application exited");
}

public void ReturnMenu()
{
    SceneManager.LoadScene("Menu");
}

public void PlayVideo()
{
    SceneManager.LoadScene("VideoPlay");
}
}
 
 //we use SceneOBJ as a dummy object which helps to load the scene and also to the scene changing script is attached to it.