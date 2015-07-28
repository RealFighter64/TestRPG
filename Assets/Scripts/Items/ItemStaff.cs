using UnityEngine;
using System.Collections;

public class ItemStaff : ItemBase
{
	public int health;
	public int defence;

	public override void Use() {
		GameInformationHolder.gameInformation.player.equippedStaff = this;
	}

	public ItemStaff (string name, string desc, int health, int defence)
	{
		this.name = name;
		this.desc = desc;
		this.health = health;
		this.defence = defence;
	}
}

