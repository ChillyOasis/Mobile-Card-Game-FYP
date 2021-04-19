using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenAPack : MonoBehaviour
{
    public Button button;
    public Text packNumInMain;
    public Text packNumInOpenPack;

    // Start is called before the first frame update
    void Start()
    {
        if (ExpScript.packs == 0)
        {
            button.interactable = false;
        }
        else
        {
            button.interactable = true;
        }

        button.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        if (ExpScript.packs > 0)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }

    void TaskOnClick()
    {
        packNumInMain.text = ExpScript.packs.ToString();
        packNumInOpenPack.text = ExpScript.packs.ToString();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
}