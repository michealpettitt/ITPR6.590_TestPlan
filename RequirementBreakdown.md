# Requirement Breakdown. 
  
## Requirements.  
  
### CTM1:  
    The game shall consist of a 10 by 10 matrix of rooms,  
    which shall be displayed to the player at each iteration, along with the location of the Student (indicated as an S).  
      
### CTM2:  
    At each iteration, the player shall be able to input  
    the direction they wish the Student to move (N for North, S for South, E for East or W for West).  
    There are no other options. If a player enters any command other than N, S, E, or W, or their lowercase equivalents,  
    the game shall display "Please enter N, S, E, or W".  
      
### CTM3:  
    All user input shall be case-insensitive. For example,  
    typing either "N" or "n" shall take the Student to the room to the North (if it exists).  
      
### CTM4:  
    If a room exists in the direction they have indicated,  
    the Student shall move to that room and a new iteration shall commence.  
      
### CTM5:  
    If a room does not exist, the game shall indicate to the user that they cannot move in that direction.  
      
### CTM6:  
    The game shall accept a 32-bit signed integer seed for the random number generator.  
    This should be entered as an argument for the program on the command line.  
      
### CTM7:  
    If an invalid value is entered for the seed, the system shall ignore it and assume that  
    no argument was passed in (that is, it will act as though no seed were entered).  
      
### CTM8:
    The Ghost shall move a random direction at each iteration.  
    If the Ghost attempts to move to a room 2/2 which does not exist, the user shall be informed that they hear  
    the Ghost bump into a wall. Treasure Goblin shall not move.  
      
### CTM9:
    If the Student has found the Treasure and encountered the Treasure Goblin, the player shall win.  
    If the Student has encountered the Treasure Goblin but has not found the Treasure,  
    the player shall lose. In either case, after the scenario occurs, the program shall end.  
      
### CTM10:
    If the Student is in a room directly to the North, South, East or West of the Treasure Goblin,  
    the program shall indicate that they hear somebody mumbling about a Treasure.  
      
### CTM11:
    If the Student is in a room directly to the North, South, East or West of the Ghost,  
    the program shall indicate that they hear the sounds of falling coins.
      
## Breakdown. 
  
### Class Breakdown. 
  * ClassRoom
    
  * Student 
    
  * Treasure
    
  * Ghost  
    
  * TreasureGoblin 
    

  
