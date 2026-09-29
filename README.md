# GameEngineWeeklyActivity

Anson Leung 100748012

Can't think of a title for this but the gameplay loop is super simple. You hit enemies with your "sword", enemies are the cubes. I am using the Weekly Activity we have done for the base. Was trying to base this on the original Legend of Zelda which is hard to see currently. Move imidiately after the game opens because it just drops you into playing. Only 4 enemies has been placed, I have factory pattern coded for the weekly activity but I did not add the functionality for this.

I have chosen the singleton pattern to create an audio manager, I have created an audio manager like this in the past but that was for fmod, so I basiclly rebuilt it and made it simple for this assignment.

Singletons are good for an audio manager because it avoids having multiple sources of sounds all playing at once as it is centralized into one gameobject instead. You also could avoid having problems with volume as only the singleton audio manager adjusts the volume. Also could be called easily from anywhere.

I have added a slider to adjust the SFX for the game, it could be pull up in a menu pressing esc. This just shows the usefulness of a singleton manager.

WASD: Move
Right click: attack
Esc: SFX Menu

The files for the related content for singleton is in the week 3 folder.

No diagram since I'm kind of low on time, sorry.

Reference for the sound generator since I want to make something quick.
https://sfxr.me/

The base singleton class has been taken from the slides and in this repo.
https://github.com/PacktPublishing/Game-Development-Patterns-with-Unity-2021-Second-Edition