using UnityEngine;
using System.Collections;

public class ItemHead : ItemBase
{
	public int speed;
	public int potency;

	public override void Use() {
		GameInformationHolder.gameInformation.player.equippedHead = this;
	}

	public ItemHead (string name, string desc, int speed, int potency)
	{
		this.name = name;
		this.desc = desc;
		this.speed = speed;
		this.potency = potency;
	}
	
}

