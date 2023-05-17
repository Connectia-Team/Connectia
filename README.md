# Connectia

Connectia is a competitive multiplayer FPS game developed with Unreal Engine 5. The game features various points spread across its maps that can be captured by two competing teams. The objective is to capture the enemy's main point. Controlling a point gives each team member a passive XP boost, and XP can also be gained by killing enemies. Increasing XP levels up a player, and reaching a new level awards an additional skill point that can be spent on upgrading various characteristics of the player's weapon.

## Some of the game features
* Character system
  * First-person view
  * Health and death mechanics
  * Advanced animations from Lyra
  * Third-person death camera
* Combat system
  * Basic weapon mechanics (shooting, reloading, etc.)
  * Damage falloff
  * Different damage values for different body parts
  * Randomized recoil based on normal distribution
  * Dynamic characteristics (damage, range, fire rate, stability (recoil), magazine capacity) that can be changed during the game
* Game points system
  * Points are interconnected to form a graph
  * A new point can only be captured by a team if they have already captured the previous point in the graph
  * Capture status is displayed in the world through dynamic materials
  * Controlling a point gives the team a passive XP boost
* Leveling system
  * Earning XP increases the player's level, giving free skill points
  * Skill points can be spent to upgrade the dynamic characteristics of the weapon
* Game modes
  * Lobby
    * Deathmatch warmup
    * The main match will start when all players vote
  * Main game mode
    * Automatic balanced distribution of new players to teams
    * Capturing the enemy's main point results in winning the game
    * The minimap shows the positions of the local player, teammates, and game point capture states
* Online
  * Steam sessions are integrated
  * Direct connection via IP is also supported

The network architecture of all game systems is implemented with some basic anti-cheat measures, such as preventing infinite ammo cheats.

## Documentation
Partial and detailed documentation, including screenshots, is available [here](./Documentation/pz.pdf) (in Russian).

### Style Guide
https://github.com/Allar/ue5-style-guide/blob/main/README.md

### Repo Structure

Repository structure is fixed, and it only has a few toplevel directories. Every other directory or file is ignored.

- `/Source`
- `/Config`
- `/Plugins`
- `/Content`
- `/RawContent`
- `/Documentation`

`git-lfs` management rules are mostly defined for file types, and not _paths_, however there can entire paths marked to be managed by `git-lfs`. Without a special note, expect only type-based rules apply to a directory.

#### `/Source`

C++ source code is stored under the `/Source` path. As with most other directories, this directory is managed by standard git (and not `git-lfs`). That means no blobs. Do not put here any `.dll`s, `.exe`s, `.zip`s and other binaries. Only text files are allowed.
Generated text files can reside in the local `/Source` dir, but should be ignored by git with additional entries in `.gitignore`.

#### `/Config`

Engine and game config files.

#### `/Plugins`

Game plugins. Every plugin lives in a subdirectory of the `/Plugins` dir. A plugin internal directory structure is not strictly documented, so there are no assumptions on how a plugin is structured.
It may be useful to use git submodules to manage plugins in a more robust manner.
It is expected that each plugin will have it's own `.gitignore` file in it's subdirectory, as well other required specific git tweaks.

#### `/Content`

Game assets in Unreal Engine formats, `.uasset` and `.umap`. Only those two file types are allowed, everything else is ignored.

#### `/RawContent`

**This directory is managed entirely by `git-lfs`.**

`/RawContent` is a directory where you store assets in their source formats, in contrast to `/Content`, where assets are stored in the engine format (after the import). Having an asset in a source format is useful when you're still making updates to it. It may be a good idea to also have separate repos for managing work-in-progress assets (maybe in smaller collections or even idividually).

#### `/Documentation`

This directory contains some of the game documentation.
