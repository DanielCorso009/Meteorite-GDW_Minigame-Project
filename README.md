# Meteorite(GDW_Minigame)
 minigame for GAME 3000

---------------------METEORITE------------------------------------------------------------------------------------
You are a lone white metorite on its way to the planet below.
Unfortunately some space Junk is trapping you in.
Some of it looks breakable, maybe you can find a way out?

blue is unbreakable

red is breakable but only when a strong enough force hits it.

purple is bouncy

blue hexagons are unbreakable but deposit a powerful pellet that can break breakable material

yellow pellets are very delacate and strong if it touches anything it will break

With these tools, you may be able to escape!
---------------------------------------------------------------------------------------------------------------------

*******CONTROLS*************************************
LEFT & RIGHT KEYS: MOVE LEFT AND RIGHT
DOWN KEY: ACCELERATE DOWNWARDS
SPACE: JUMP
*****************************************************

++++++++LOG+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
Ive wanted to see how I could make something speed their gravity up and change its vertical speed.
So I created code that does not rely on the gravity scale of the player but allowed him to speed up the downward movement.
Obviously making this would be uselless if I didn't give it something to break. 
Programming the jumping and collision was daunting at first since it was my first time doing this in Unity, but eventually I got it to work.
The bouncy platforms initially were going to be platforms that would defy gravity and be pushable. It lea to too much jank so I decided to make them bouncy,
thinking that it will allow the player to reach the height needed that a single jump couldnt get.
Finally, the one that took the longest to implement was definitely the projectile launcher and the projectile itself.
I Gave it some spin to differentiate with the other platforms and made it a hexagon as well. I made it so if you were holding DOWN while airborne, then you would produce a projectile from it. 
It worked but the next thing after was to adjust the speed at which the projectile was produced and have the producer fire it at the angle needed.  OVerall it took me a day for this to be done.
The projectile just did not want to cooperate initially. The way I was checking collision between the red platforms and the projectile was that I was trying to compare gameObjects, but that wasnt working.
I then had the weird idea to compare the names of the inital projecctile Prefab and the Instanced projecile. It didnt  work becaus the prefabes name had "(CLONE)" at the end.
Using the C# function of name.Substing(), I was able to cut the end par out and collision between the two objects worked correctly from then on
I didnt know how to end it so I added a 2nd red platform to make the player go back up the side and then break the final red platform.

generally I dont know much about level design so it might look weird. but everything has been dejanked by 97% (CURSE YOU PROJECTILE GENERATOR!!!!)
