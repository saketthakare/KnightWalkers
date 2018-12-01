# fa18-202-invictus

## Team Members:
1. Ajinkya Thakare
2. Akshay Jaiswal
3. Janhavi Dahihande
4. Priyal Agrawal
5. Saket Thakare

## Project Idea
We are building a game named 'KNIGHT WALKERS'. This is an endless running game, built on Unity3D game engine. The theme of the game is based on the famous TV series: Game Of Thrones. Player can select from three characters - Hound, Tyrion and Khal Drogo. In the game play, player can collect coins and speed boosts to increase the score, while avoiding obstacles in the form of fire and fences. If the player touches any of these obstacles, his health will be reduced. Lost health can be regained by collecting health potion. Game will end once player loses all of his health. Final score of player will be displayed on the score board after end of game play. We have also implemented a leader board functionality which displays the names of top five scorers, along with the rank as per current game play. For this purpose, we are sending the score for each game play to a node.js server hosted on cloud via APIs. All the scores are stored in cloud hosted MySQL database. 

## Links for project artifacts
- Scrum Burndown Report
- Youtube Video

## Design Patterns
Following design patterns have been implemented to build the game features-

- Command Pattern for game menu
- Factory pattern for creating game objects like fire, fence, boost, coin and health-potion
- Observer pattern for handling collisions with game objects mentioned above
- Observer pattern for monitoring and updating player health
- Bridge pattern for storing scores on server and fetching leader board data

##UML Diagrams

- CLass Diagram

![Class-Diag](./Project%20Reports/UML%20Diagrams/Class Diagram.png)

- Sequence Diagram

![Sequence-Diag](./Project%20Reports/UML%20Diagrams/Class Diagram.png)

- Activity Diagram

![Activity-Diag](./Project%20Reports/UML%20Diagrams/Activity Diagram.png)

- Use Case Diagram

![UseCase-Diag](./Project%20Reports/UML%20Diagrams/UseCase.png)

## Game Play Screenshots

- Main Menu

![Main Menu](./Project%20Reports/Game%20Screenshots/MainMenu.png)

- Instructions Screen

![Instructions](./Project%20Reports/Game%20Screenshots/InstructionsMenu.png)

- Audio Settings Screen

![Audio Settings](./Project%20Reports/Game%20Screenshots/AudioSettingsMenu.png)

- Character Selection Screen

![Character Selection](./Project%20Reports/Game%20Screenshots/CharacterSelectionMenu.png)

- Game Play

![Game Play](./Project%20Reports/Game%20Screenshots/GamePlay.png)

- Score Board

![Score Board](./Project%20Reports/Game%20Screenshots/ScoreBoard.png)

- Leader Board

![Leader Board](./Project%20Reports/Game%20Screenshots/LeaderBoard.png)


