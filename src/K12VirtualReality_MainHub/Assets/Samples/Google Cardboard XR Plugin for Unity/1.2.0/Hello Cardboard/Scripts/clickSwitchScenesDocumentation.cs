using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class clickSwitchScenesDocumentation : MonoBehaviour {

	// These are public variables we can edit inside Unity
	public Animator animator;
	public Image blackFadeImageFront;
	public Image blackFadeImageLeft;
	public Image blackFadeImageRight;
	public Image blackFadeImageBack;
	public Image blackFadeImageTop;
	public Image blackFadeImageBottom;
	
    public void buttonChangeScenesDocumentation(string sceneName){
    	
    	// Start the Coroutine to switch scenes
    	StartCoroutine(FadeOutAndIn(sceneName));
    	
    }

    IEnumerator FadeOutAndIn(string sceneName) {

    	// Set the trigger to true to "trigger" the animation
    	animator.SetBool("Scene_Fade_In_And_Out_Trigger", true);

    	// wait until images fully fade to black to change scenes
    	yield return new WaitUntil(()=>(blackFadeImageFront.color.a==1)&&
    									(blackFadeImageLeft.color.a==1)&&
    									(blackFadeImageRight.color.a==1)&&
    									(blackFadeImageBack.color.a==1)&&
    									(blackFadeImageTop.color.a==1)&&
    									(blackFadeImageBottom.color.a==1));

    	// Switch to the inputted scene
    	SceneManager.LoadScene(sceneName);
    }
}
