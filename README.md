# Mammalian-Bacterial-Simulation
For my A-Level Computer Science course I had a coursework project in which I was to deliver a product for a specified end-user. In this case, the end-user was Dr Tracy Nevitt of Neem Biotech. 
to see an example of the program running click below.

## An Example of it Running Below
[![IMAGE ALT TEXT](http://img.youtube.com/vi/xSXazlLjXyU/0.jpg)](http://www.youtube.com/watch?v=xSXazlLjXyU "NEA")

The product I was asked to deliver a rudamentary system that simulates an exponential bacterial growth among mammalian cells, 
### Objectives

- The user was expected to be able to enter the starting conditions and virulence of the bacteria involved.

 - The simulation was to involve some randomness in particle movement as to replicate brownian motion at such small scales, to try and replicate this I chose to give each cell a random position and velocity on start up. 

### How it Works
I created this program with the help of unity as it gave me the tools necessary to create an agent based simulation like this. download the docx of the documentation to see an in depth breakdown

The large circular cells are mammalian cells, and the small pod shaped cells are bacteria. When a bacteria comes into contact with a mammalian cell it will infect it, depending on the infection percentage chosen in the previous scene the mammalian cell will either survive (turn green) or die and release more bacteria (turn red and fade away) 

The "game" can be paused ceasing the motion of all cells, or it can be slowed with the slider on the screen. When the program detects that no more change can happen it will end the simulation and 
