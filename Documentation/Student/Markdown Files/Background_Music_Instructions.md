# Background Music
<b>NOTE: Scene Transition Instructions should be viewed before moving to this step. </b>

## Student Goals ##
- Learn the details involved in applying audio to a scene in Unity
- Play a song in each scene
- Have audio fade in and out during scene changes
- Generalize the background music logic to use in other instances in unity projects

### Instructions ###
Naviagate to the HelloCardboard scene with details from the Basic UI Creation and Scene Transition Instructions in place
#### Playing Audio in Scenes ####
Playing audio in Unity scenes is actually very simple!
1. With the HelloCardboard scene open, add an empty game object to the hierarchy. Give it a name that defines its purpose such as BackgroundMusic. Add the Audio Source component and make sure the Play On Awake and Loop boxes are checked.

2. Now we need some audio to play. You can find audio online, or if you're more talented than us, you can upload your own beats. If you find music online, the important things to look for in this project are that the music is royalty free, free to use, and looping. We used [SoundImage.org](https://soundimage.org/looping-music/) to obtain our audio. The audio we used in our Main Menu scene is called FUTUREOPOLIS, and that is the audio we will use for this tutorial; however, you are free to pick whatever audio you like. MP3 files will play in Unity; however, we found that WAV files are preferable as Unity will convert any file you use to a WAV file anyways which can causes pauses in audio. Many websites exist online to convert audio file types if needed.

<i>Note: Most free to use audio comes with the stipulation that in order to use the audio, the creator be given credit for their work. This is also good practice even if the stipulation is not in place. This ensures that all individuals get credit for their hard work and that no plagiarism is committed unintentionally. The creator is referenced in our game credits. Following a later credits tutorial, you can reference your audio's creator there as well.</i> 

3. Right-click in the project window in the same area as the Animation and Scenes folders and create an Audio folder. Inside the Audio folder you can then right-click and select Import New Asset and add your audio file to the folder.

4. Select the BackgroundMusic game object. From the Audio folder in the project window, click and drag your audio file to the AudioClip box in the inspector.

That's it! You can now play the game and hear the audio in your scene. However, you will notice that the audio starts at full volume and ends abruptly when you change scenes. To make this smoother, lets add some fading to our audio.

#### Fading Audio in Scenes ####
1. 
