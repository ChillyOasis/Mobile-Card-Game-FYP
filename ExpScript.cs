using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpScript : MonoBehaviour
{
    public Text levelText;
    public Text expGainText;
    public Text expToGoText;
    public Text packNumInMain;
    public Text packNumInOpenPack;

    public static int iLevel = 1;
    public static int iExpGain = 0;
    public static int iExpToGo = 100;
    public static int packs = 0;

    // Start is called before the first frame update
    void Start()
    {
        levelText.text = iLevel.ToString();
        expGainText.text = iExpGain.ToString();
        expToGoText.text = iExpToGo.ToString();

        packNumInMain.text = packs.ToString();
        packNumInOpenPack.text = packs.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (iExpGain >= iExpToGo)
        {
            iLevel++;
            iExpGain = iExpGain - iExpToGo;
            iExpToGo *= 2;
            packs++;

            levelText.text = iLevel.ToString();
            packNumInMain.text = packs.ToString();
            packNumInOpenPack.text = packs.ToString();
        }
        expGainText.text = iExpGain.ToString();
        expToGoText.text = iExpToGo.ToString();
    }
}
