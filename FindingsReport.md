# Findings  
## Introduction  
This findings document is to record and discuss the outcome of the project, it will include a discussion on issues and mistakes made during the process, as well as thing new that had been Laurent, what could have been done differently and how that would have been achieved.
We will cover test that did not pass the unit testing, and why they might have failed. Some observations on parts of the project that interested/challenged how the testing was to be conducted.

## Issues created by developer  
### Not reading the requirements and documentation  
It became apparent that during the development and testing cycle of this project that some features had been missed or misunderstood. This lead to some difficulties in testing or having to restructure the way the program had been written.
One example of this is the way the function to display the 10x10 matrix was built, in stead of returning a value, it was built to write directly to the console. The difficulties became apparent when trying to test this function, to be able to test a restructure of this function was required. Not a difficult process more a time consuming one to have to go through and make it all work together.
 
### Placing functions in the incorrect location or doubling up code blocks  
The duplication of the inbuilt Random function caused large issues with the random movements of the ghost character. It was though that adding a new instance of the random function to the function that controlled the movements of the ghost would be the best option only to cause the ghost to walk out of the 10x10 matrix.
The out come to this was an edge case that would have been easily avoided if the documentation of the random function and the requirements of the game had been better understood.  
  
![](https://github.com/michealpettitt/ITPR6.590_TestPlan/blob/master/pic1.png)  
  
### Placing functions in the incorrect location or doubling up code blocks  
The duplication of the inbuilt Random function caused large issues with the random movements of the ghost character. It was though that adding a new instance of the random function to the function that controlled the movements of the ghost would be the best option only to cause the ghost to walk out of the 10x10 matrix.
The out come to this was an edge case that would have been easily avoided if the documentation of the random function and the requirements of the game had been better understood.
 
## Unclear Documentation By MSDN
### Unit testing libraries  
The installation of NUnit and NUget was well documented within the MSDN documentation and all steeps to produce unit test had been followed, when it came to try to use the main project as a library, the functions could not be accessed. Meany hours had been wasted trying to figure out and get the testing operational.
The solution turned out to be relatively simple, the main project class needed to be set to public and so did any functions wishing to be tested, after that point unit testing worked flawless.  
  
![](https://github.com/michealpettitt/ITPR6.590_TestPlan/blob/master/pic2.png)  
![](https://github.com/michealpettitt/ITPR6.590_TestPlan/blob/master/pic3.png)  

## Failed Tests
### Matrix test Failure 
The unit test to produce the 10x10 matrix was set to fail purposely on the first run, it was witnessed that the actual output diagnosed was what I would have expected. On updating the test to ideally get a passed, the test resulted in another failure, this went about in circles till Bug Test (an inbuilt bug testing feature in visual studio) was run, at that point on inspecting the actual output it was also correct even though it failed the test. From this I copied and pasted the output into the expected output variable in my unit test where it then still failed.  
  
![](https://github.com/michealpettitt/ITPR6.590_TestPlan/blob/master/pic4.png)  
![](https://github.com/michealpettitt/ITPR6.590_TestPlan/blob/master/pic5.png)  

To fix this error required putting the matrix all on a single line, as shown in the following image, I am unsure why this would happen but has resolved they issue.

![](https://github.com/michealpettitt/ITPR6.590_TestPlan/blob/master/pic6.png) 
![](https://github.com/michealpettitt/ITPR6.590_TestPlan/blob/master/pic7.png)  
  
## What could have done better?
Time management and working with a team member would have lightened up the work load. Also have a built a better understanding of certain requirements sooner as well as understanding implementing unit test frame works soon.

## Conclusion
The Conclusion to this, is that there is now a better understanding in how software testing is conducted, it has also aided in establish a more efficient way to conduct programming tasks in the future.
It is felt that all though some minor features had been left out of the application that it meets requirements of the testing scenario.





