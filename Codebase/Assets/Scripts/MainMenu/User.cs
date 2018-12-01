using UnityEngine;
using UnityEngine.UI;

public class User : MonoBehaviour
{
    private GameController gameController = GameController.GetInstance();

    [SerializeField]
    private InputField userName;

    private void Start()
    {
        userName = GameObject.Find("PlayerName").GetComponent<InputField>();
        userName.text = gameController.GetUserName();
    }

    public void GetInput(string name){
        gameController.SetUserName(name);
        Debug.Log(gameController.GetUserName());
    }
}
