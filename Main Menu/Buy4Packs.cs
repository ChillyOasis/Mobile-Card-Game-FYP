using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy4Packs : MonoBehaviour
{
    public Text packNumInMain;
    public Text packNumInOpenPack;

    public void ButtonClicked()
    {
        ExpScript.packs += 4;

        packNumInMain.text = ExpScript.packs.ToString();
        packNumInOpenPack.text = ExpScript.packs.ToString();
    }
}
