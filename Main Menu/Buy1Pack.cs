using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy1Pack : MonoBehaviour
{
    public Text packNumInMain;
    public Text packNumInOpenPack;

    public void ButtonClicked()
    {
        /*
        numberText.text = (int.Parse(numberText.text) + 1).ToString();
        numberTextinMain.text = (int.Parse(numberTextinMain.text) + 1).ToString();
        */

        ExpScript.packs += 1;

        packNumInMain.text = ExpScript.packs.ToString();
        packNumInOpenPack.text = ExpScript.packs.ToString();
    }
}
