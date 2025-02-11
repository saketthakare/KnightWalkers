﻿using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    readonly ICommand quitCommand = new QuitCommand();
    readonly ICommand settingsCommand = new SettingsCommand();
    readonly ICommand helpCommand = new HelpCommand();
    readonly ICommand playCommand = new PlayCommand();
    readonly ICommand characterCommand = new CharacterCommand();
    readonly ICommand homeCommand = new HomeCommand();
    readonly ICommand pauseCommand = new PauseCommand();
    readonly ICommand leaderboardCommand = new LeaderboardCommand();

    public Button quitButton, settingsButton, helpButton, playButton, characterSelectionButton, homeButton, pauseButton, leaderboardButton;

    void Start(){
        if(quitButton)
            quitButton.onClick.AddListener(quitCommand.Execute);
        if(settingsButton)
            settingsButton.onClick.AddListener(settingsCommand.Execute);
        if(helpButton)
            helpButton.onClick.AddListener(helpCommand.Execute);
        if (playButton)
            playButton.onClick.AddListener(playCommand.Execute);
        if (characterSelectionButton)
            characterSelectionButton.onClick.AddListener(characterCommand.Execute);
        if (homeButton)
            homeButton.onClick.AddListener(homeCommand.Execute);
        if (pauseButton)
            pauseButton.onClick.AddListener(pauseCommand.Execute);
        if (leaderboardButton)
            leaderboardButton.onClick.AddListener(leaderboardCommand.Execute);
    }
}
