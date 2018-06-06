# ITPR6.590 - Test Plan
# Contents  
* 1.0 Introduction   
* 2.0 Goals    
* 3.0 Objectives    
* 4.0 Test Items  
* 5.0 Features to be tested  
* 6.0 Features not to be tested  
* 7.0 Approach  
* 8.0 Iteams pass/Fail criteria  
* 9.0 Test deliverables     
* 10.0 Responsibilities  
* 11.0 schedule   
  
  
## 1.0 Introduction 
### Objective
    This Document has been established to describe the testing requirements and outcomes of the project  
    “Crazy Treasure Maze”.  
    The intention of this document is to detail and outline the process that the testing and development  
    team will follow for this project to obtain the desired outcomes.

### Project Overview
    This project is to develop and test a console application “Crazy Treasure maze”.  
    The concept of this application is to navigate a player (student) through a ten by ten  
    matrix (rooms), the end goal is to locate a hidden treasure that is randomly placed in one  
    of the rooms that make up the matrix.  
  
    During the quest the player will need to avoid encountering a sprit (ghost), If the student  
    occupies the same room as the ghost the game will end informing the player of the end  
    of game. If the ghost moves to a room that dose not contain another room next to it the  
    player will be alerted buy text that the ghost was heard bumping into a wall.  
    If the player is in a room that is next to the ghost, text shell let the player know that they  
    can hair coins falling on the floor.  
  
     A sprit (Treasure Goblin) will be placed at random in one of the rooms. The Treasure  
    goblin will be hidden and non-visible to the player, if the player is in a room a Jasion to  
    the room the treasure goblin is in, the player will be warned via text that they hear  
    somebody mumbling about the treasure. If the player lands in the same room as the  
    treasure goblin and not the treasure the player will lose the game. To win the game the  
    player will need to have encountered the treasure and the treasure goblin in that order.  
  
### Scope
    The scope of this test plan is to test the functional requirements for the application  
    “Crazy Treasure Maze”. The test plan will define the requirements of how to test that  
    The application meets all the required outcomes, it will document and outline the  
    individual procedures for unit testing at the base level. Test plan will not test for any  
    discrepancies with the tests them salves, nor will it test the programming language or its  
    pre-built libraries, it will not test the systems that it is released on for performance or  
    efficiency issues.  
  
### Constraints 
    A lack of time and staffing for this project dictates the limitations on the testing and its  
    Procedures, the lack of a pair reduces the ability to pair review the testing outcomes  
    allowing for discrepancies that may otherwise be caught and reviewed. With the lack of a  
    pair the time taken to produce the desired tests may take longer and affect the date that 
    tests are completed.  
  
## 2.0 Goals  
    The main Goal of this testing plan is to "Verify and validate" the application,  
    this will be achieved by testing each funtional requierment, sub goals will 
    be meet during the testing that will inculed making the application fail tests, 
    making the application pass tests, eliminating aterfacts from the code, 
    building robust program and prventing future issues/bugsand keeping to project milstones.
    
    Goals for this project:
* Finding defect that have been created by developer during development.
* Producing a Quality application.
* prevent defects.
* making sure the end application meets the requierments of the project.
* To eliminate as many defects in the application by the release date.
      
     
## 3.0 Objectives  
* Povide a appliucation that meets requiermenst
* show evadince of testing an testing procedures
* buld a tangible testing plane
* eliminate as meany bugs, issues and defects as posibly
* prevent future defects
* All expected results match the actual results.
  
## 4.0 Test Items  
   Test iteams should executs as to the Software Requierment Specificatiuons for  
   the application Crazy Treasure Maze.
   
## 5.0 Features to be tested  
    The following features are to be tested with unit testing.
      
|<b>ID</b>|<b>Features Description</b>|<b>Priority</b>|  
|---------|---------------------------|---------------|  
|1|return the correct format of the 10 x 10 maxrix|High|  
|2|user input is equal to the movment to the student|High|  
|3|edge case in a user attemps to move outside the matrix a warning is returnd|Medium|  
|4|edge case ghost cant move out side of the 10x10 matrix|High|  
|5|application should accept a 32bit sind int|low| 
|6|that the ghost moves in a random direction during its moves|High|  
|7|test location of X, Y  for ghost, goblin, treasure|Low|  
|8|edge case a user cant move outside matrix|High|  
|9|a student is in a room next to the Goblin|Low|  
|10|a student is in a room next to the ghost|Low|  
|11|a student is in a room next to the treasure|Low|  
    
## 6.0 Features not to be tested
    this test plan will not test any hardware requierments that may affect speed or operation 
    to the application, it will not test development software or framework dependinces.  
## 7.0 Approach  
    The following is the order in which this project will be devaloped and tested.  
* Install ToDoList application and out line the project schedual, 
    add milstones and completion dates.
* For better understanding this will bedevalpoed as a white box project.  
* Read throught and brakedown the software requierment specifics.
* A list of assumption established and leasoned with the client.  
* A unit test plan developed to test the functional requierments of the project.
* software devalopment starts along with inital unit tests.  
* issue loge kept to maintain issue resolve.  
* unit test resolts and reports documentsed.  
* Reports on findings.  

    A Github repository has been established to recored the deliverbles of this project.  
    Because of time constraints The devalopment approch will be that closs to TDD, the unit tests  
    will be devaloped in conjunction with the application, this in a sence is not a true TDD form 
    But suits the constraints of this project.
## 8.0 Iteams pass/Fail criteria  
* All test are exauted.
* Any magoure defects that could affect relase are resolved.  
* repoting on unit tests are accrete.  
* Documentation is up to date and matching the rquierments of the project.  
* A recored of all low level tests not completed befor due date are recored. 
* Application operates to the requierments of the Software Requierment Specification.

## 9.0 Test deliverables  
|<b>No.</b>|<b>Deliverables</b>|<b>Author</b>|<b>Reviewer</b>|  
|----------|-------------------|-------------|---------------|  
|1|Master Test Plan|Micheal Pettitt|Client|  
|2|Unit Test Plan|Micheal Pettitt|Client|  
|3|Requirement Traceability matrix|Micheal Pettitt|Client|  
|4|Evidence of the tests|Micheal Pettitt|Client|  
|5|Findings report|Micheal Pettitt|Client|  
  

## 10.0 Responsibilities
    All aspects of thes documentation will be carried out by the developer.
    The requierments for the developer to complecte the testing of this application will be as follows:  
* Develope testing requierment.
* Develope a testing plan.
* Document any assuptions and possible issues with Application.
* Keep a error/issue log of any issues that occure during and after development.
* Develop Application.
* Development of unit tests,
* Conduct and record unit test resolts.
* Summiting final report to client By the 8 june.

## 11.0 schedule  
    The schedualing for this project will be ketp and main taind via the ToDoList aplication  
    and will be added to the Github repository  
    for this project, as for the limitations provided by only having one member  
    in the development and testing so tasks that maybe deamed  
    less critical may be postponed till such a point they can be completed.
