using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
// Standard definitions for all cards
    public string cardName;
    public string description;
    public Sprite artwork;
    public string cardType;
    public int cardID;
    // cardID consist of 5 digits
    // First digit represent card type:
    //      1 for Hero
    //      2 for Spell
    //      3 for Equipment
    // Second digit represent hero role type:
    //      1 for Damage
    //      2 for Tank
    //      3 for Healer
    //      0 if it's a Equipment card

    // Hero cards
    public int health;
    public int attack;
    public int heal;

    // Spell cards
    // Damage heroes:
    public string spell;
    public int spellAttack;         // Attack spell cards
    public bool entireEnemyTeam;    // If damage spell affects entire enemy team
    // Tank / Support heroes:
    public int spellReduceDmg;     // Protection spell cards
    public int spellHealing;        // Healing spell cards
    public bool entireParty;        // If tank or healing spell affects entire team
    public int drawCards;           // Allows drawing of cards

    // Equipment cards
    public int boostAttack;         // Damage boost
    public int eqReduceDmg;        // Reduce damage taken
    public int passiveHealing;      // Healing receive at start of round


    public void Print()
    {
        Debug.Log(name + ": " + description);
    }

    public Card(int CardID, string Description, int Health, int Attack, int Heal, string Name, int SpellAttack, int SpellHealing, string CardType)
    {
        cardID = CardID;
        name = Name;
        description = Description;
        health = Health;
        attack = Attack;
        heal = Heal;
        spellAttack = SpellAttack;
        spellHealing = SpellHealing;
        cardType = CardType;


    }
}