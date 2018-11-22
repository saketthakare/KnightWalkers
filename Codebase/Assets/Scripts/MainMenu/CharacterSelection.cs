using UnityEngine;

public class CharacterSelection : MonoBehaviour {

    private GameObject[] characterList;
    private int index;
    private readonly GameController gameController = GameController.GetInstance();
    // Use this for initialization
    private void Start () {
        characterList = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
            characterList[i] = transform.GetChild(i).gameObject;

        foreach (GameObject obj in characterList)
            obj.SetActive(false);

        if (characterList[0])
        {
            characterList[0].SetActive(true);
            index = 0;
        }

	}
	
	// Update is called once per frame
	/*void Update () {
		
	}*/

    public void Left(){
        characterList[index].SetActive(false);
        index--;
        if (index < 0)
            index = characterList.Length - 1;

        characterList[index].SetActive(true);
    }

    public void Right()
    {
        characterList[index].SetActive(false);
        index++;
        if (index == characterList.Length)
            index = 0;

        characterList[index].SetActive(true);
    }

    public void Back()
    {
        GameObject.Find("Canvas").transform.Find("CharacterSelectionMenu").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("MainMenu").gameObject.SetActive(true);
    }

    public void Confirm()
    {
        string character = characterList[index].name;
        gameController.SetPlayer(character);
        GameObject.Find("Canvas").transform.Find("CharacterSelectionMenu").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("MainMenu").gameObject.SetActive(true);
    }
}
