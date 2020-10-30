using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class clickSwitchScenes : MonoBehaviour {

	public Animator animator;
	public Image blackFadeImageFront;
	public Image blackFadeImageLeft;
	public Image blackFadeImageRight;
	public Image blackFadeImageBack;
	public Image blackFadeImageTop;
	public Image blackFadeImageBottom;


    public void buttonChangeScenes(string sceneName){
    	
    	StartCoroutine(FadeOutAndIn(sceneName));
    	
    }

    IEnumerator FadeOutAndIn(string sceneName) {
    	animator.SetBool("Fade_Out_And_In_Trigger", true);
    	yield return new WaitUntil(()=>(blackFadeImageFront.color.a==1)&&(blackFadeImageLeft.color.a==1)&&(blackFadeImageRight.color.a==1)&&(blackFadeImageBack.color.a==1)&&(blackFadeImageTop.color.a==1)&&(blackFadeImageBottom.color.a==1));
    	SceneManager.LoadScene(sceneName);
    }


    
    
}
