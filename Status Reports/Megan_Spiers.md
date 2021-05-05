# Weekly status reports

## Week One

### Tasks
- Integrate cardboard into unity/unreal (whichever we decide on)
- imform Mr. Shank what engine we picked and show him what I've done in the selected engine
### Accomplishments
- Downloaded and Installed Unity
- Played with FPS microgame to learn unity
- researched cardboard integration with unity and unreal
- Meeting with Mr. Shank
### Issues
- N/A

## Week Two

### Tasks
- practice more unity
- practice new tools to add to unit
### Accomplishments
- Read SOL pdf for Mr. Shank
- Created a basic pool table model in unity to practice movement and materials
### Issues
- N/A

## Week Three

### Tasks
- practice more unity
- Come up with 2 easy, 2 medium, and 1 spicy idea for VR
### Accomplishments
- Created pool ball in blender 
- Came up with 2 easy ideas for VR
### Issues
- N/A

## Week Four

### Tasks
- explore with unity
- Look into limitations of google cardboard 
- Pick our projects to work on
### Accomplishments
- Continued to learn unity/blender 
- Came up with 5 ideas for VR
### Issues
- N/A

## Week Five

### Tasks
- implement test project and learn about importing textures
- gather facts for planet project
### Accomplishments
- Decided to work on solar system project first
### Issues
- N/A

## Week Six

### Tasks
- Finish Scene Transition in Cardboard
- Begin work on a main screen UI
### Accomplishments
- began work on first VR project (solar system)
- Worked with scene transitions and tried to relate to cardboard
### Issues
- N/A

## Week Seven

### Tasks
- Get unity to play the fade out and fade in animations
- Think about how our facts and information about planets can be laid on in UI form and what buttons are needed
### Accomplishments
- Created a sample scene off the main google cardboard room to transtion to
- Created fade in/fade out animations for use with scene transition
- Sucessfully got unity to switch scenes and play fade in animation when a button on a UI is pressed
### Issues
- Unity only plays the fade in animation and not the fade out animation so scene transtion is still more jarring than desired

## Week Eight

### Tasks
- Update UI to respond to hover and be more user friendly
- Research about UI's in Unity
### Accomplishments
- Fixed Animation Issue
- Set up scene transition main menu screen and space scene
### Issues
- N/A

## Week Nine

### Tasks
- Get a reticle / gaze timer working
- Set up proper transitions to scenes
### Accomplishments
- Set up temporary transitions to between space scene and planet scenes
- Made UI more responisve (buttons now change color when hovered over)
- Changed all default cameras to XR cameras to work with VR
- Researched how to implement reticles / gaze timer in unity for cardboard
### Issues
- Issue: Google Cardboard's heavily documented way of making a reticle is only available through prefabs for the outdated cardboard VR SDK. The new Google XR SDk has very little documentation of reticle implementation

## Week Ten

### Tasks
- Get a gaze timer working if we want one
- Documentation for everything thus far
### Accomplishments
- Added temporary transition to Pluto scene / button to return back to Space scene
- Added GoogleVR assets to give us more freedom with prefabs
- Noticed and corrected scene transition error from a simple image in front of camera fading to a cube around the camera fading so that transition is not jarring regardless of where user looks during transition
- Angled all UI buttons by -20 degrees to give the illusion that they are always facing the camera to make clicking them easier
- Added reticle to all scenes that responds on click to UI buttons in all scenes and planets in the Space scene
### Issues
- N/A

## Week Eleven

### Tasks
- Finish documentation
- Plan how to display facts on UI
- Look into how music breaks/skips in space scene 
### Accomplishments
- Fixed VR error in main menu scene
- Documentation for various things
### Issues
- N/A

## Week Twelve

### Tasks
- more documentation
- Fix audio issue
- finish plan for UI facts display 
- Anything else we need 
### Accomplishments
- Worked on documentation 
- Move space scene buttons into a more functional setting below the user's view
- Moved back buttons in scene to the left side 
- Started planning how UI facts will be displayed 
### Issues
- N/A

## Week Thirteen

### Tasks
- Finish documentation
- Last minute bug squashing 
### Accomplishments
- Added documentation to students instructions
- Fix audio issue by adding different music to space scenes
- Finish adding UI panels that display facts around planets
- Work on documentation for various things 
### Issues
- N/A


# Spring Semester

## Week One

### Tasks
- Get random objects to instantiate at designated location 
- Start the purchasing process for the Unity Asset Store assets once we know which route to take
### Accomplishments
- Met with Mr. Shank and decided what project we're going to start next
- Researched and located assets to use for stage environment / music instruments 
- Researched how to instantiate a random gameobject (instrument) from a set of gameobjects (all the instruments) at a certain location
### Issues
- To have VCU buy the assets or reimburse us

## Week Two

### Tasks
- Push all new assets to dev branch
- Shank wants instruments to be removed from array after spawn; implement that logic and make sure total number of instruments is divisible by 3
- Add some in game buttons for testing 
- Look for / fix any possible issues and bugs in previous code
### Accomplishments
- Created script that spawns three random objects at designated locations from a script
- Created a new script that destroys objects after a certain time limit (for testing)
- Added Jacob's script to game objects
- Purchased all assets 
- Set up the auditorium environment for use
- Create new prefabs of all instruments so they use spawn script, destroy script, movement script, are detectable, and always face the camera
### Issues
- N/A

## Week Three

### Tasks
- Work with Jacob to implement select instrument options 
- Alter and attach destroyer script to all game objects to be able to handle destroy logic
- Look into how to have dynamic text on panels for info about instruments 
### Accomplishments
- Finished Initial prep of instruments and environment 
- Altered Spawning script to cycle through all instruments and end. 
- Altered spawner script to reshuffle the list of instruments with every method call so that the   spawning is always random 
- Fixed scene transition error in new music scene 
### Issues
- N/A

## Week Four

### Tasks
- Work with Jacob and Jackson to get a struct created to allow all instruments to have multiple value types 
- Assign certain instruments to be  "correct"
- Make sure proper instruments spawn according to music 
### Accomplishments
- Added a a mesh collider to all instruments 
- Made instruments selectable and used destruction script as test place holder
- Create psuedocode for making sure the Instrument that matches music spawns accordingly 
- Right now instruments are destroyed when clicked 
### Issues
- N/A

## Week Five

### Tasks
- Get back on track and do whatever is needed 
### Accomplishments
- Brainstormed with Jacob and Jackson about how quiz logic should work 
- Made sample update to destruction script 
### Issues
- N/A

## Week Six

### Tasks
- Get back on track and do whatever is needed 
### Accomplishments
- Researched next steps in project 
### Issues
- N/A

## Week Seven

### Tasks
- Work with Jacob to see how ending finite game mode could work
- Possibly add auditory cues for right/wrong answers 
- Bug squashing 
### Accomplishments
- Set up music scenes for use
- Added rope animation to each music scene for button menus
- Added background music to all music scenes 
### Issues
- N/A

## Week Eight

### Tasks
- Add auditory indicators for right/wrong answers in quiz
- Finished gallery scene instrument descriptions 
### Accomplishments
- Added audio for instruments to gallery scene
- Added background music to all scenes
- Added sample description text for each Instrument in gallery scene
### Issues
- N/A

## Week Nine

### Tasks
- Finish gallery descriptions 
- Finish audible indicators 
- Updated credits 
- Documentation
### Accomplishments
- Added base descriptions for all gallery instruments 
- Updated all buttons / UI elements to work with animator 
- Created method to delay calling methods by a few seconds 
### Issues
- N/A

## Week Ten

### Tasks
- Bug squashing
- Documentation
### Accomplishments
- Added descriptions for all gallery instruments 
- Updated all buttons / UI elements again to work with animator 
- Updated credits and added CodeVA logo to credits
- Added audible indicators for right and wrong answers 
- Commented all code
### Issues
- N/A

## Week Eleven

### Tasks
- Documentation
- Whatever the team needs from me
### Accomplishments
- Reviewed presentation materials 
- Looked for bugs in project 
- Began mapping out plan for documentation 
### Issues
- N/A

## Week Twelve

### Tasks
- Documentation
### Accomplishments
- Met with team and Shank to discuss presentation details
### Issues
- N/A

## Week Thirteen

### Tasks
- Documentation 
### Accomplishments
- Finished set up documentation
- Start credits and animator documentation
### Issues
- N/A

## Week Fourteen

### Tasks
- N/A 
### Accomplishments
- Finished all documentation
### Issues
- N/A
