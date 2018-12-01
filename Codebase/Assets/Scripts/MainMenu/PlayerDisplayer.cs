using UnityEngine;
using UnityEngine.UI;

public class PlayerDisplayer : MonoBehaviour
{
    private GameController gameController = GameController.GetInstance();

    private GameObject[] characterList;
    private string playCharacter;

    void Start(){
        Transform trans = GameObject.FindWithTag("PlayerList").transform;

        int characterCount = trans.childCount;
        characterList = new GameObject[characterCount];

        for (int i = 0; i < characterCount; i++)
            characterList[i] = trans.GetChild(i).gameObject;
        DisplayPlayer();


    }

    void Update(){
        if (playCharacter != gameController.GetPlayer())
            DisplayPlayer();
    }

    private void DisplayPlayer()
    {
        foreach (GameObject obj in characterList)
            obj.SetActive(false);

        playCharacter = gameController.GetPlayer();
        if (playCharacter == "john")
        {
            GameObject.FindWithTag("PlayerList").transform.Find("hound").gameObject.SetActive(true);
        }
        if (playCharacter == "hound")
        {
            GameObject.FindWithTag("PlayerList").transform.Find("hound").gameObject.SetActive(true);
        }
        if (playCharacter == "tyrion")
        {
            GameObject.FindWithTag("PlayerList").transform.Find("tyrion").gameObject.SetActive(true);
        }
        if (playCharacter == "drogo")
        {
            GameObject.FindWithTag("PlayerList").transform.Find("drogo").gameObject.SetActive(true);
        }
    }
}
