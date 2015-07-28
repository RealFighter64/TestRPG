using UnityEngine;
using System.Collections;

[System.Serializable]
public class Character
{
	public string name;
	public int level;

	public int currentHealth;
	public int currentMagicae;

	public int magicae;
	public int attack;
	public int health;
	public int defence;
	public int speed;
	public int potency;

	public ItemStaff equippedStaff;
	public ItemCore equippedCore;
	public ItemHead equippedHead;

	public ItemBase[] inventory;

	public Character (string name,
	                  int level,
	                  int magicae,
	                  int attack,
	                  int health,
	                  int defence,
	                  int speed,
	                  int potency)
	{
		this.name = name;
		this.level = level;
		this.magicae = magicae;
		this.attack = attack;
		this.health = health;
		this.defence = defence;
		this.speed = speed;
		this.potency = potency;
	}

	public void GiveItem() {

	}
}

