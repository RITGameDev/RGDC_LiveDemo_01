# RGDC_DuckHunt
![Screenshot of finished game](screenshot_1.png "Screenshot")

## Art assets:
[I got the art assets here, on Open Game art](https://opengameart.org/content/platformer-art-deluxe "Open Game Art")

## Steps to follow:
1. Create a new project (make sure you select 2D)
2. Import the art assets that you want
3. Setup the environment however you want
  * If you want your background to tile then make sure you change the "Sprite Renderer" component
4. Pick something that you want to use as a flying enemy type.
5. Drag the sprite into the scene, and put this on a sorting layer that is above all the other ones.
6. Add "Box 2D Collider" and "Rigidbody 2D" components to it
7. Turn the "Gravity Scale" to 0 on the Rigidbody
8. Drag and drop this object from the scene Hierarchy, and put into the Project folder. This makes the object become a prefab, so you can easily make one change and apply it to several objects in the scene.
9. Now, Make a folder in the Project view called "prefabs". It is very important to keep your project organized and readable for other people.
10. Now make a folder called "Scripts", this will be where you organize your codebase for all your Unity projects, and it is standard for most Unity devs.
11. Create a C# script by right clicking in the project view, and selecting "Create -> C# Script"
 * Call it DestroyOnClick
12. Attatch this to the enemy object that you made, and run the game.
* The object should disappear when you click on it!
13. Now we need a way to spawn these enemies continuously, so lets make an EnemySpawner script!
14. You can think of coroutines in Unity a little bit like threads. Unity has just recently added Threading support in Unity 2017, so now a lot of people are using that yet. Threading is also a more complicated programming topic that we can't really get into today.
15. Now that we are spawning a bunch of these enemies, notice how the ones that you miss are staying alive. This is _really_ bad for memory, even on this small scale. To solve this, we will create a DestroyAfterTime script, so that enemies will disappear abotu a couple seconds, after they have exited the camera bounds.
* Take note that this is still not optimal, just a little bit better. The proper way of doing this would be using object pooling or caching of some kind, but given that most people here are freshmen that topic is a bit too advanced.
16. Now that we have enemies spawning, lets get them moving in different directions when they spawn! Create a SetVelocityOnstart script, and attatch it to the enemy prefab.
17. Alright, looking good! Now for the last thing, we are gonna be keeping score of how many objects we have destroyed. Make a C# script called "ScoreKeeper"
* In the OnMouseDown method of the enemy, incrememnt the score.
18. Add in some animations and particle effects as you wish, and you have a fully functional game!
