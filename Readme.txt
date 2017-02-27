
I have used WPF for interactive UI with MVVM design pattern. 

This solutions containts multiple projects -

1) CarFinder.Agents
2) CarFinder.COnsole
3) CarFinder.Helpers
4) CarFinder.Models
5) CarFinder.Tests
6) Carfinder.UI
7) CarFinder.ViewModel


CarFinder.Agents:
This is the pluggable implementations of the CarFinder. I have implemented two agents, RandomCarFinder & StartingZeroCarFinder. RandomCarFinder randomly picks up the velocity & position and calculates the position and returns it. StartingZerocarFinder - this implementation starts the velocity & Position at zero and calculates the position. One additional thing is it stores the previous values and increments them and calculates the position.


CarFinder.COnsole:
This is the Console project implementation. Executing this will read the Input.csv included in the project under "Files" folder and stores results in the "results.csv" file inside the "bin\Files" folder.

Carfinder.Helpers:
This is a helpers library class.

CarFinder.Models:
This is the Model project and contains the "Car" implementation. I have used Timer and tick events to move the car forward and also calls the pluggable implementations. This project is being shared by both WPF and Console projects.

CarFinder.UI:
This is the WPF project with simple UI not code-behind for the file.

CarFinder.ViewModel:
This is the "VM" project used for interaction between Views and Models.




