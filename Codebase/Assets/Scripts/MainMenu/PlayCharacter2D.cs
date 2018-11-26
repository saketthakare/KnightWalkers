using UnityEngine;
using UnityEngine.UI;

public class PlayCharacter2D : MonoBehaviour
{
    public GameObject player;
    private GameController gameController = GameController.GetInstance();

    public Texture john;
    public Texture hound;
    public Texture tyrion;

    void Start(){
        player.GetComponent<RawImage>().texture = GetTexture();
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
}
