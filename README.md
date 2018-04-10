Project2Repo
# Project2 - simulations of cities and bodies of water
by Reynaldo Garcia and Luciano Wollffe

## Important Links:

* [Video Demo Youtube link](link here)
* [Video Demo mp4 file ](link here)


Project description:

Download the APK file and install it on an Android phone. Once you have done so you will have a stand-alone unity application in your Android phone. Open the application shortcut and insert the phone into the Google Cardboard. You cannot move in this project. Simply move your head around to any one of the interactable objects, stare at them for at least five seconds and the interaction will be complete. There are no win or lose conditions in this game. Instead it's objective is to educate the user on water resources. 



## Self-created models/textures:

*All the windows created by Ray in GIMP

*Rain texture Ray

*River created by Luciano in Blender

*factory created by Luciano

*houses created by Luciano

Other game objects that are simple geometry were created inside the Unity Editor

## Imported models:

*Smoke texture imported from: http://3png.com/b-1126653.html

*Basic Water Package imported by Unity

*Skybox: https://assetstore.unity.com/packages/2d/textures-materials/sky/skybox-4183

## Tutorials and Other References Used:

*fixing a plane issue by the top answer in: https://answers.unity.com/questions/157604/objects-disappear-when-too-far-away.html

*Research of the game's environmental science by Luciano. Please see the compiled Power Point presentation on them attatched to this project where the sources are included

*Adding fire: https://www.youtube.com/watch?v=qShjsxopbfQ

*Importing the ocean system: https://www.youtube.com/watch?v=2bbDq-w8to4

*fixing clipping: https://answers.unity.com/questions/157604/objects-disappear-when-too-far-away.html

*Unity's official documentation: https://docs.unity3d.com/Manual/index.html

*Adding a skybox into the scene: 



# Duties:

## Luciano:

Houses, factory, river with algae, scripts that control an interaction (partial), enabling scripts to make the correct windows appear during their right interactions, researched all 
of the water resource facts that appear on the windows, and compilec them into the Powerpoint Presentation.

## Ray:

The big body of water (not the river), the first-person controller, the skybox, designed all the windows in GIMP, the smoke particle systems, the fire particle system, the 
rain particle system,imported the ocean system from Unity's Standard Assets package.


# Issues:

*Clipping: We wanted our scene to be big. This is because the game takes place all around an island city. This leads to a couple of development issues. One of them involved
what they call clipping. When the FPS moves around the terain becomes less visible. This means that the user cannot look at the whole city at once. So what we found online
is that the field of view attribute in the Main Camera object had to be set to an arbritarily large sized value. This fixed the issue.

*We want certain events to occur once the user clicks on a given object. This is called the interactions. For example clicking on the factory opens up a window.
At first we were using box colliders, then I told Luciano to use the UI buttons on the window instead. We then together looked up how to use the buttons in Unity's own documentation
and how our scripts would have to be written in order to be compatible with them.

*Most interestingly Ray was not able to test on his computer resulting from a setting somewhere deep inside his laptop that would not allow him to deploy APK's into his Android phone
and Luciano did not have an Android device of his own. So we had to test on a live device using Luciano's laptop and Ray's phone.


Project structure:


