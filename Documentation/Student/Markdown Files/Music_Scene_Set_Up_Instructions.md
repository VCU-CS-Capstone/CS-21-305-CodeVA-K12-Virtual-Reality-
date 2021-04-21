# Directions for Music Scene Set Up

## __NOTICE: This section assumes you have fully completed the General Setup and All Space Instructions.__

## Getting Started

After completing the General Set Up Instructions and the Space scene, you should have a general idea of how Unity works. </br>
We will now move forward to creating the Music scene, which provides a few extra challenges. The instructions will be more open ended from here to help teach you one of the most important things a programmer can learn: how to teach yourself. Don't be afraid to research things you don't understand at the moment; this is an important part of the learning process. </br>

To begin, we must acquire all assets required from the Unity Asset Store. For our case, it is better to use premade assets as creating these ourselves would be another project in itself.

Assets Used: 
- [Auditorium](https://assetstore.unity.com/packages/3d/environments/auditorium-141127) : All Auditorium Assets
- [Instruments](https://assetstore.unity.com/packages/3d/props/stylized-musical-instruments-pack-176502) : All instrument prefabs

Download and import these assets into Unity. If you have problems during importation, consult Unity documentation online.

<i>NOTE: These assets are not free. If free assets are needed, explore the Unity Asset Store and find suitable alternatives. </br>
The Auditorium asset is simply an environment to use; any free environment will work fine. </br>
The instruments were the most concise pack we could find; free instruments will work here as well. </br> </i>

## Seting Up the Environment

We will now set up the Auditorium Environment. If you used a different environment, tailor all instructions to fit your assets as best as possible. This leaves you room for creativity.

1. In the Project Window, find the Auditorium Asset Folder, find the Auditorium scene within, and press CTRL+D to duplicate it. This will create a new scene, Auditorium1. Change the name of Auditorium1 to Music Main Menu and open it.
2. In the Music Main Menu hierarchy, create an empty game object called Built-In Auditorium Assets and drag all existing elements in the hierarchy to be children of the Built-In Auditorium Assets object. This will us help clean up our hierarchy quite a bit. 
3. Follow General Set Up and Space Instructions to set up the camera, reticle, canvas UI, and scene changing script (You will not have a button to attach this script to yet.) </br>
<i> (Hint: You can copy and paste all of these elements in, change the UI as needed for the next instructions, and update the destination for the scene changing script in Unity when the time comes) </i> </br>
Position the XRRig camera in front of the stage in a way that looks pleasing to you. We used X: -0.3, Y: 0.5, and Z: 6.
4. To brighten up the stage a little, create a directional light above the middle of the stage and name it Light for Instruments. You shouldn't have to change any Inspector settings besides the X, Y, and Z location values.

5. Create an empty game object called Auditorium Audio. Create four empty game object children named AudioFrontLeft, AudioFrontRight, AudioMiddleLeft, and AudioMiddleRight and add an audio source component to each. Move each game object to be place over the Auditorium speaker for which it was named within the scene. For example, the AudioFrontLeft object goes over the speaker on the front left of the stage. For all audio sources, in the inspector, uncheck Loop, change the Spatial Blend to 3D, and set the Stereo Pan to either left or right depending on the game objects location in the scene with respect to the camera.

Your hierarchy should now look similar to this, though naming conventations may vary for the SceneChanger object and the switching scenes script object. </br>
![Initial_Music_Hierarchy](Screenshots/Music/Initial_Music_Hierarchy.png "Initial Music Hierarchy")

