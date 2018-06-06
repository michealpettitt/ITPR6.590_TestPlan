  
# Defects.  
  
### Initial input lag 001
    On first instace of the user attempting to make a movment within the application  
    no movement is observed to change, on second input for movement the displayed "s"  
    for the users caractor inacts its movment. 
### Input lag 002:
    The user inputs appear to be one movment behind user inputs, The user will press a movment key,  
    at this point the exspected location will be one behind the exspected location.
### Continuation move 003:  
    After the user has input a movment command changing direction, the "s" will move to the next room   
    in the previos direction and not commit to the move in the new direction.
### Collision Detection 004:  
    when the s (student) is one room from the g (ghost) a collision is detected. detection should occoure  
    when the ghost and the student share the same x & y values.  
### Incorrect user inputs 005:  
    When a user inputs any other keys other than the ones specified for use a warning text should inform  
    the user oh the incorrect input. Input is failing to display or is displaying to fast to see.  
### Incorrect movements Ghost 006:  
    Ghost random position will only randomly count up on the y axis, eventualy taking the ghost  
    out of viwe, continued inputs will show the y value exstending past the preset array size.  
    No array error is given crashing the applicaton as what would be exspected in such situations.  
      
    Resolved.      
### Index outside bounds 007:  
    After issue 006 resolved, Ghost will attempt to move out side the bounds of the arrays crashing  
    the application resoulting in the index outside of bounds error.  
    System.IndexOutOfRangeException: 'Index was outside the bounds of the array.  
      
    Resolved.  
### Ghost sticks to wall 008:  
    After issue 007 resolved, ghost will enter finale array cell and not move.  
      
    Resolved.
### Ghost move 009: 
    Ghost will move regardless to the key being pressed.
    if a non specified key is pressed the ghost will still make its turn.

  

    
