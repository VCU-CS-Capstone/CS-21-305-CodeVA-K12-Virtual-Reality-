 # Space User Interface creation
<b>NOTE: Setup, Introductory UI, Scene Transition, Background Music, and Space Instructions should all be viewed before moving to this step. </b>

## Student Goals ##
- Add a user interface to each planet scene
- Add a user interface to the broad solar system scene
- Understand the use of buttons and materials in relation to text color in Unity
- Generalize UI logic to use in other instances in Unity projects

### Instructions ###
An example of one scene will be created in this tutorial. You will be expected to develop the other scenes based on the same logic.
#### Individual Planet / Star Scene ####
Navigate to your desired starting planet or star. For the sake of this tutorial, we will use our Sun scene.
1. In the Sun scene, all that should be present in the hierarchy at this time are the XRRig camera, the sun object with proper material applied, 
the GvrEventSystem prefab, and the GvrEditorEmulator. From the HelloCardBoard scene, copy and paste in the SceneChanger game object and all its children 
and the SceneChangerScript game object. Don't worry that the Canvas looks weird now as we will change this drastically during this tutorial; however, 
it provides a good baseline to start making our changes.
2. Change the SceneChanger game object to a location where you can see the Canvas in front of the camera and in front of the planet or star. The actual numbers will depend upon
your XRRig location and planet size. You should only need to change the X, Y, and Z position values for this step. These values can be changed later; this is just to get
the Canvas into view so that we can see the changes we make to our scene.
3. 
