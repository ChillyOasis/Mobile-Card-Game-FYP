using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {
    public GameObject card;
    public Text healthText;
    public Text attackText;
    public Text healText;

    // Start is called before the first frame update
    void Start() {

        healthText.text = card.GetComponent<HeroCard>().Health.ToString();
        attackText.text = card.GetComponent<HeroCard>().Attack.ToString();
        if (card.GetComponent<HeroCard>().Healing != 0)
        {
            healText.text = card.GetComponent<HeroCard>().Healing.ToString();
        }
    }

    void Update()
    {
        healthText.text = card.GetComponent<HeroCard>().Health.ToString();
        attackText.text = card.GetComponent<HeroCard>().Attack.ToString();
        if (card.GetComponent<HeroCard>().OGHeal != 0)
        {
            healText.text = card.GetComponent<HeroCard>().Healing.ToString();
        }
    }
}
