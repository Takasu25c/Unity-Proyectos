using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSCebe : MonoBehaviour
{
    public void GoToMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ReturnToMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
