using UnityEngine;
using System.Collections;

public class ItemConsumable : ItemBase
{
	public int healthAmount;
	public int magicaeAmount;
	// Insert status effect healing here \\
	public int randomAmount;

	public ItemConsumable (string name, string desc, int healthAmount, int magicaeAmount, int randomAmount)
	{
		this.name = name;
		this.desc = desc;
		this.healthAmount = healthAmount;
		this.magicaeAmount = magicaeAmount;
		this.randomAmount = randomAmount;
	}

	public override void Use () {
		GameInformationHolder.gameInformation.player.currentHealth += healthAmount;
		GameInformationHolder.gameInformation.player.currentMagicae += magicaeAmount;
	}

}

