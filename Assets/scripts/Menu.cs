using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void NewGame()
    {
        //Empezamos con la escenade Nivel 1
        SceneManager.LoadScene("Nivel1");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
