using UnityEngine;
using UnityEngine.UI;

public class HomeMenu : MonoBehaviour, IHomeMenu
{
    readonly ICommand quitCommand = new QuitCommand();
    readonly ICommand settingsCommand = new SettingsCommand();
    readonly ICommand helpCommand = new HelpCommand();
    readonly ICommand playCommand = new PlayCommand();
    readonly ICommand characterCommand = new CharacterCommand();
    public GameObject player;
    private GameController gameController = GameController.GetInstance();

    public Texture john;
    public Texture hound;
    public Texture tyrion;

    public Button quitButton, settingsButton, helpButton, playButton, characterSelectionButton;

    void Start(){
        quitButton.onClick.AddListener(quitCommand.Execute);
        settingsButton.onClick.AddListener(settingsCommand.Execute);
        helpButton.onClick.AddListener(helpCommand.Execute);
        playButton.onClick.AddListener(playCommand.Execute);
        characterSelectionButton.onClick.AddListener(characterCommand.Execute);
    }

    void Update(){

        player.GetComponent<RawImage>().texture = GetTexture();
    }

    private Texture GetTexture()
    {
        string playCharacter = gameController.GetPlayer();
        if (playCharacter == "john")
            return john;
        if (playCharacter == "hound")
            return hound;
        if (playCharacter == "tyrion")
            return tyrion;
        return john;
    }

    /*public void handleInput(){
    }
    public void Play()
    {

    }

    public void Help()
    {

    }

    public void Settings()
    {
        GameObject.FindWithTag("MainMenu").SetActive(false);
        GameObject.Find("Canvas").transform.Find("SettingsMenu").gameObject.SetActive(true);
    }

    public void Quit()
    {
       quitCommand.Execute();
    }*/
}
