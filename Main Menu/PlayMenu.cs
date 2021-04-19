using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayMenu : MonoBehaviour
{
   /* [SerializeField] private string VersionName = "0.1";
    [SerializeField] private GameObject UsernameMenu;
    [SerializeField] private GameObject ConnectPanel;

    [SerializeField] private InputField UsernameInput;
    [SerializeField] private InputField CreateGameInput;
    [SerializeField] private InputField JoinGameInput;

    [SerializeField] private GameObject StartButton;

  
    public void PvPgame()
    {
        Debug.Log("vs other player");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
   */
    public void PvAIgame()
    {
        Debug.Log("vs ai");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


/*
    //---------------------------- CONNECT TO PHOTON SERVER ----------------------------
    private void Awake()
    {
        PhotonNetwork.ConnectUsingSettings(VersionName);
        Debug.Log("Connecting to Master");
    }

    private void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(TypedLobby.Default);
        Debug.Log("CONNECTED to Master");
    }


    // Start is called before the first frame update
    void Start()
    {
        UsernameMenu.SetActive(true);
    }


    //---------------------------- ALLOW USER TO SET OWN USERNAME ----------------------------
    public void ChangeUsernameInput()
    {
        if (UsernameInput.text.Length >= 3)
        {
            StartButton.SetActive(true);
        }
        else
        {
            StartButton.SetActive(false);
        }
    }

    public void SetUsername()
    {
        UsernameMenu.SetActive(false);
        PhotonNetwork.playerName = UsernameInput.text;
    }
    */
}
