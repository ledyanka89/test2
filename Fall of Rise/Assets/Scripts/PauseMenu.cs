using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
     
    void Update() 
    { 
        if (Input.GetKeyDown(KeyCode.Escape)) 
        { 
            SceneManager.LoadScene("Menu");
        } 
    } 
}
