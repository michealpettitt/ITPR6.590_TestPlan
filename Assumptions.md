
# Assumptions   

This document is to discuss any assumptions made for this project.  
Because of the vague nature of the requirements of this project some critical  
assumptions must be made.  
  
Recording of such assumptions are important for a project, for reasons of scope creep, time restrictions  
and its test development lifecycle.

## Assumption 1  
### What is a room?
It is unclear how a room should be represented in the application; the assumption is that it  
is a value held within the array? The value is of type string and to achieve the result we have  
used a dot to represent that value, so the user of the application will see a 10x10 matrix of dots.  
  
 .  .  .  .  .  .  .  .  .  .   
 .  .  .  .  .  .  .  .  .  .   
 .  .  .  .  .  .  .  .  .  .   
 .  .  .  .  .  .  .  .  .  .   
 .  .  .  .  .  .  .  .  .  .   

 It is imaged that each dot in the above matrix is a room.  
   
 
 
## Assumption 2
### How do we view the treasure and the goblin?  
It is not stated if the treasure and the treasure goblin are visible to the user, it reads as they  
are not visible but is not ever specified.  
It is assumed they are not visible and will only be represented as a x and y value allowing for  
detection between the characters.  
 
## Assumption 3  
### How does the student start?
The student is the character the user can move around with inputs from the keyboard, this student will  
need a location to start from each time the game reloads. Is the student to load in a set location each  
time or should it be random?  
to resolve we have fixed the student to a location in the bottom left corner of the 10x10 matrix.  
  
## Assumption 4  
### How to end/close the application?
If the player would like to end/close the application while playing how will they do so?  
a issue found here is that no other keys other than the directional keys are valid inputs.  
To end and close the application we have added a termination key, which is the "p" key on the key board.  
by pressing the key, the application will be closed.

## Assumption 5  
### What happens when the game is won or lost?  
After user can win or lose the game depending on interactions on the  
screen, after which point no other instruction is given.  
It is assumed once the user wins or loses the game, the application is terminated.







