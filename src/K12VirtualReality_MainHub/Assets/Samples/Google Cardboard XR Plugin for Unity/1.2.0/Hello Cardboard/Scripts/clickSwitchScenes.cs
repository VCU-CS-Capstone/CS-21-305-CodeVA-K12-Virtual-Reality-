using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class clickSwitchScenes : MonoBehaviour {

	public Animator animator;
	public Image blackFadeImage;

    public void buttonChangeScenes(string sceneName){
    	
    	StartCoroutine(FadeOutAndIn(sceneName));
    	
    }

    IEnumerator FadeOutAndIn(string sceneName) {
    	animator.SetBool("Fade_Out_And_In_Trigger", true);
    	yield return new WaitUntil(()=>blackFadeImage.color.a==1);
    	SceneManager.LoadScene(sceneName);
    }


    
    
}
