using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlayerCreator : PageCanvas
{
	private string charName;

	private int magicae;
	private int attack;

	private int health;
	private int defence;

	private int speed;
	private int potency;

	public void StorePlayer ()
	{
		GameInformationHolder.gameInformation.player = new Character (charName, 1, magicae, attack, health, defence, speed, potency);
		SaveAndLoad.SaveGameInformation ();
	}

	public void OnPageNameSubmit ()
	{
		charName = GetElementInPageByName ("PageName", "NameFieldText").GetComponent<Text> ().text;
		SwitchPage ("PageClass");
	}

	public void OnPageClassSubmit ()
	{
		int offence = (int) GetElementInPageByName ("PageClass", "Offence").GetComponent<Slider>().value;
		int defence = (int) GetElementInPageByName ("PageClass", "Defence").GetComponent<Slider>().value;
		int support = (int) GetElementInPageByName ("PageClass", "Support").GetComponent<Slider>().value;

		magicae = 10 + offence * 2;
		attack = 15 + offence * 3;

		health = 10 + defence * 2;
		this.defence = 15 + defence * 3;

		speed = 10 + support * 2;
		potency = 15 + support * 3;

		StorePlayer ();
	}
}
