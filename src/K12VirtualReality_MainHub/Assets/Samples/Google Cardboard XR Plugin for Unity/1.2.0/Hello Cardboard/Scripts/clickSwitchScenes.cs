using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickSwitchScenes : MonoBehaviour {

	public Animator animator;

    public void buttonChangeScenes(string sceneName){
    	animator.SetTrigger("Fade_Out");
    	SceneManager.LoadScene(sceneName);
    }


    
    
}
