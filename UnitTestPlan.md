
<p align = "center">
  Crazy Treasure Maze<br>
  <br>
  <b>Unit Test Plan</b><br>
  <br>
  <br>
  <br>
  Versoin: 1.0<br>
  <br>
  <br>
  <br>
  Prepared by<br>
  <b>Micheal Pettitt</b><br>
  <br>
  
  

|<b>Documentation</b>|<b>Version</b>|<b>Date</b>|  
|--------------------|--------------|----------|  
|Master Test Plan|1.0|06/06/2018|
|Software Requierment Specifics|1.0|06/06/2018|
|Crazy Treasure Maze System|1.0|06/06/2018|

  
# Contents
  
1.0 Introduction  
2.0 Features to be Tested and not to be Tested  
3.0 Entry /Exit Criteria   
4.0 Test case specifications   
5.0 Unit Test Deliverables   
6.0 Remaining Test Tasks  
  
 
  
# 1.0 Introduction  
This Document has been developed to describe the unite test plan for "Crazy Treasure Maze". this thest plan out lines the  
creation of unit test activities and to arrange them into a testing schedule, it will also aid the tester to write  
unit test cases and execute to the exspected outcomes.  
  
The funtional featuers of this application will be tested with the Microsoft Visual Studio standards, a plugn "NUNIT"  
Has been utilised in the testers tool chain to provide the correct frameworks, because the chosen language being C#  
and devaloped in the .NET Core frameworks, Nunit unit testing framework supports testing in the .NET Core. 
More information on Nunit can be found on the MSDN websit.
  
# 2.0 Features to be Tested and not Tested  
All functional features of Crazy Treasure Maze are to be tested in the unit testing plan this will include all Classes,  
Functions, and methods.  
  
Time restraints and lack of testers and developers on this project, any low piority iteams and sub items  
maybe left to be tested as the remaining tasks.

No software used to develope the application will be tested, plugins and dependances will also not be tested.
This unit test plan is only to test the functional requierments on the appliction it self.
  
# 3.0 Entry /Exit Criteria
## Entry Criteria  
  * Uint test plan for application hase been created and approved.  
  * Development of application is complete.  
  * Application meets the requierments of the project.
  * All criteria for test cases are developed and approved, testing data and conditions ready to execute.
  * Resourse for conduting unit tests are ready.  
  
## 4.0 Exit Criteria  
  * All Documentation is complete.
  * Records of all issues have been made.
  * All unit test have been executed.
  * All funtional requierments have passed tests.
  
# 5.0 Test case specifications  

|Project Name|Crazy Treasure Maze|||||    
|---|---|---|---|---|---|   
|||||||  
|<b>Test case ID</b>|<b>Test case description</b>|<b>Input Data</b>|<b>Steps|<b>Expected result</b>|<b>Status|<b>Actual Result</b>|  
|||||||    
|TC01_Detecton_01|To test if valuse are the same return true|0,0,0,0|Run Test|true|PASS|true| 
|TC01_Detecton_02|To test if valuse are not the same return false|1,2,3,4|Run Test|false|PASS|true|  
|TC02_DetectonXY_01|To test if -1 is returned|1,2,3,4|Run Test|-1|PASS|-1|  
|TC02_DetectonXY_02|To test if y-1 is returned|5,4,5,5|Run Test|4|PASS|4|  
|TC02_DetectonXY_03|To test if y+1 is returned|5,6,5,5|Run Test|6|PASS|6|  
|TC02_DetectonXY_04|To test if x-1 is returned|4,5,5,5|Run Test|4|PASS|4|   
|TC02_DetectonXY_05|To test if x+1 is returned|6,5,5,5|Run Test|6|PASS|6| 

# 6.0 Unit Test Deliverables  

|<b>No.</b>|<b>Deliverable Name</b>|<b>Auther</b>|<b>Reviewer</b>|  
|------------|-----------------------|-------------|---------------|  
|1|Unit Test Plan|Micheal Pettit|Client|
|2|Test Cases Execution Logs|Micheal Pettitt|Client|
|3|Test incident report|Micheal Pettitt|Client|  
  
# 5.0 Remaining Test Tasks  
None to comment on at this date  
  
# 7.0 Schedule (Test Milestone)
|<b>No.</b>|<b>Task Description</b>|<b>Start Date</b>|<b>Due Date</b>|<b>Deliverable</b>|  
|----------|-----------------------|-----------------|---------------|------------------|
|1|Create Unit Test Plan|14/05/2018|22/05/2018|Unit Test Plan Virsion 1.0|
|2|Create Unit Test Cases|23/05/2018|28/05/2018|Unit Test Case and update to unit Test Plan Virsion 1.0|
|3|Build the Test|31/05/2018|05/05/23018|Execute logs and commit on Github|  

