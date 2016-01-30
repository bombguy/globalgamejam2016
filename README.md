# Life of a Probe
*#globalgamejam2016*

You are a young magician wishing to test your summoning limits.
Collect mana orbs to power your summon. 
Collect Dream or Dragon orbs to choose your possession. But collecting both will cancel each other. While possessed, picking up a mana orb will give you a charge of Q power to defeat your enemies. Kill enemies and bosses quickly before your possession expires!

## Getting Started


### Prerequisities

1. Clone this repository into your designated system.


```
git clone https://github.com/bombguy/globalgamejam2016
```

### Installing

#### Linux
1. cd to the directory and run:

```
sudo chmod +x 
./LOAP.x86
```

#### OSX
1. Copy LOAP.app to your Applications folder and launch from icon.
2. cd to th directory and run:

```
sudo chmod +x 
./LOAP.x86
```

#### Windows
1. cd to the directory and run: 
```
LOAP.exe
```

#### From Source Code
1. Install Unity 5 with corresponding build module(s) to your system.
2. Open the project in Unity.
3. Build and run by pressing: CTRL+B

## Game Manual

### Controls
Q or E for power?
W, A, S, D to move
Any Pause game buttons?

Press space to enter the Netherworld

###Characters and Spawned Objects

Cloaked magician (1*1unit)
-	Normal (black hair, tan skin, white eyes, white cloak with black insignia mark) 
-	Angel Possession (golden hair, tan skin, blue eyes, blue cloak with gold insignia mark)
o	Movement speed boost
o	Long range straight attack
o	No hp bonus
o	**fly over obstacles? (if too hard to program, can change power)
-	Dragon Possession (white hair, tan skin, red eyes, red cloak with black insignia mark)
o	Movement boost 
o	Short range cone attack
o	+1hp

Pick up orbs
-	Mana orb (white with black core)
o	Slightly smaller than other 2 orbs
-	Dream orbs (Blue with golden core)
-	Dragon orbs (Red with black core)

Basic Enemies (1*1 unit)

Fire sprites – flame up in a 2 unit + sign 
Ice sprites – create a 50% movement speed debuff road
	2 sec melting timer
Wind Sprite – Charge up and dash 10 units (or early if collision occurs)
**Void sprites – teleport
-	Always in pairs

Basic enemies moves in circles, with slightly randomized times to unleash their powers.
Enemies switch walking direction if a collision occurs, or walk back two spaces first

Bosses (2*2units)
Fire Spirit – Level 1, 6, 11 etc
	Same power but larger / more often
	Base Stats: 3Hp + HpLevelModifier; .45PayerSpeed * SpeedLevelModifier; 6 sec PowerTimer – Level Modifer.
Ice Spirit – Level 2..
	Same power but larger / more often
	Base Stats: 3Hp + HpLevelModifier; .5PlayerSpeed * SpeedLevelModifier; 4 sec MeltTimer + Level Modifer.
Wind Spirit – Level 3…
	Same power but larger / more often
Base Stats: 3Hp + HpLevelModifier; .60PlayerSpeed * SpeedLevelModifier; 6 sec PowerTimer – Level Modifer 
Angel – Level 4…
	Same power as player angel 
Base Stats: 4Hp + HpLevelModifier; .55PlayerSpeed * SpeedLevelModifier; 5 sec PowerTimer – Level Modifer 
Dragon – Level 5…
	Same power as player angel 
Base Stats: 5Hp + HpLevelModifier; .5PlayerSpeed * SpeedLevelModifier; 6 sec PowerTimer – Level Modifer

Bosses have some sort of follow / face player AI
Bosses will cycle and get improved stats with every cycle. Game becomes impossible eventually?
Have an enrage timer on bosses of about 30sec * level modifier. Bosses stats go up by 25% in enrage most

Orb Collection Mechanics
-	With every mana orb collection a new enemy appears at a pylon away from the player.
-	Max of two mana orbs can spawn at one pylon at any time. And player must collect a mana orb at a different location before respawning occurs.
-	Mana orb must be collected ever 10 seconds
-	Level 1 starts with 4 mana orbs to summon boss
-	Boss must be defeated before collection for new boss begins however the one mana orb every 10 sec requirement is still in play
-	An Angel or Dragon orb spawns randomly every 3-4 sec. Disappears in 15 sec


## Built With
* Photoshop
* Unity 5

## Contributing

Please read [CONTRIBUTING.md](CONTRIBUTING.md) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

For the versions available, see the [tags on this repository](https://github.com/bombguy/globalgamejam2016/tags). 

## Authors

* **Charles** - [bombguy](https://github.com/bombguy)
* **Chris** - [ingochris](https://github.com/ingochris)
* **Igor** - 
* **Isidro** - [igomez92](https://github.com/igomez92)
* demonictomato
* lazylad91
* Natasha Dsouza
* Pooja
* Shruti
* Skandy

See the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## License

This project is licensed under the Mineral License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Cold Stone Ice Cream

