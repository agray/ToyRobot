# ToyRobot

A CLI implementation of a robot that can be placed anywhere on a 5 x 5 table.
Robot cannot fall off the table.

Contains Jenkins Thin Backup config files for easy reproduction of Jenkins build jobs.

Contains a NUnit Test project to implement the TDD approach.

See Documentation directory for more information on system requirements.

## Thoughts

An **elegant** solution is better than a **simple** solution because not everything is necessarily simple.

I could have included an IRobot interface that the Robot class implemented.  
I could have genericised Robot and passed that generic class to the table to achieve polymorphism.  

...but I deemed these unnecessary and contrived.  

The table does not "HAVE-A" robot. The robot is "PLACED-ON" the table. Therefore it made more sense (to me) to make the table a static class 
and have the robot's position implied by the values of X and Y in the Position class.

A Robot HAS-A Posture  
A Posture HAS-A Position  
A Posture HAS-A Direction  	

Thus the robot's relationship to the table is implied through its Posture.  
Initially, the robot does not have a Posture (Posture = null) because it is not yet placed on the table.