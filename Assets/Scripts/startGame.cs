using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{

public GameObject audios; 

    public void StartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }

    public void Start() {
        DontDestroyOnLoad(audios);
    }

    public void StopGame() {
        Application.Quit(); 
    }

}


