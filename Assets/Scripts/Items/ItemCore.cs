using UnityEngine;
using System.Collections;

public class ItemCore : ItemBase
{
	public int magicae;
	public int attack;

	public override void Use() {
		GameInformationHolder.gameInformation.player.equippedCore = this;
	}

	public ItemCore (string name, string desc, int magicae, int attack)
	{
		this.name = name;
		this.desc = desc;
		this.magicae = magicae;
		this.attack = attack;
	}
}

