# Background Music
<b>NOTE: Scene Transition Instructions should be viewed before moving to this step. </b>

## Student Goals ##
- Learn the details involved in applying audio to a scene in Unity
- Play simple audio in each scene
- Have audio fade in and out during scene changes
- Generalize the background music logic to use in other instances in Unity projects

### Instructions ###
Naviagate to the HelloCardboard scene with details from the UI Creation and Scene Transition Instructions in place
#### Playing Audio in Scenes ####
Playing audio in Unity scenes is actually very simple!
1. With the HelloCardboard scene open, add an empty game object to the hierarchy. Give it a name that defines its purpose such as BackgroundMusic. Add the Audio Source component and make sure the Play On Awake and Loop boxes are checked.

2. Now we need some audio to play. You can find audio online, or if you're more talented than us, you can upload your own beats. If you find music online, the important things to look for in this project are that the music is royalty free, free to use, and looping. We used [SoundImage.org](https://soundimage.org/looping-music/) to obtain our audio. The audio we used in our Main Menu scene is called FUTUREOPOLIS, and that is the audio we will use for this tutorial; however, you are free to pick whatever audio you like. MP3 files will play in Unity; however, we found that WAV files are preferable as Unity will convert any file you use to a WAV file anyways which can causes pauses in audio. Many websites exist online to convert audio file types if needed.

<i>Note: Most free to use audio comes with the stipulation that in order to use the audio, the creator be given credit for their work. This is also good practice even if the stipulation is not in place. This ensures that all individuals get credit for their hard work and that no plagiarism is committed unintentionally. The creator is referenced in our game credits. Following a later credits tutorial, you can reference your audio's creator there as well.</i> 

3. Right-click in the project window in the same area as the Animation and Scenes folders and create an Audio folder. Inside the Audio folder you can then right-click and select Import New Asset and add your audio file to the folder.

4. Select the BackgroundMusic game object. From the Audio folder in the project window, click and drag your audio file to the AudioClip box in the inspector.

5. You can repeat these steps to add audio to any scenes you create.

That's it! You can now play the game and hear the audio in your scene. However, you will notice that the audio starts at full volume and ends abruptly when you change scenes. To make this smoother, lets add some fading to our audio.

#### Fading Audio in Scenes ####
There are many ways to make audio fade in Unity. We choose to use an animation similar to the fading scene transition logic. To edit only the BackgroundMusic game object, you could create a new Animation Controller if you wanted; however, for simplicity, we simply added on to our SceneChanger animations as we wanted the fade to happen when we switched scenes.

1. To make the BackgroundMusic game object accessible to the SceneChanger Controller, drag the BackgroundMusic game object to be a child of the SceneChanger game object but <b>NOT</b> a child of the Canvas. 

2. Navigate to and open the SceneFadeIn animation. Select the BackgroundMusic game object and press the record button. At the 0:00 second mark, in the BackgroundMusic game object inspector, set the volume to 0. At the 1:00 second mark, set the volume to 1. Stop recording.

3. Repeat step 2 in the SceneFadeOut animation. Set the volume to 1 at the 0:00 second mark and 0 at the 1:00 second mark.

That's it! If you play the game you can now hear the audio fading in to open a scene and fading out to close a scene.

4. Copy the BackgroundMusic game object and paste it in the New Scene scene in the same location as a child of the SceneChanger game object but <b>NOT</b> the Canvas. Find a new audio file you like and drag it to the AudioClip box in the BackgroundMusic game object inspector in this scene. 

We used the same game object name of BackgroundMusic in both scenes so the animation will work regardless of what file is used for the audio source.

5. Play the game and see your background music in action!
