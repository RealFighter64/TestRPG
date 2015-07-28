using UnityEngine;
using System.Collections;

public static class Items
{
	public static ItemBase weakPotion = new ItemConsumable("Weak Potion", // Item Name \\
	                                                   "Recovers a small amount of health.", // Item Desc \\
	                                                   10, // Health Revovery \\
	                                                   0, // Magicae Recovery \\
	                                                   0); // Randomness \\
	public static ItemBase weakEther = new ItemConsumable("Weak Ether",
	                                                      "Recovers a small amount of magicae.",
	                                                      0,
	                                                      10,
	                                                      0);
	public static ItemBase potion = new ItemConsumable("Potion",
	                                                   "Recovers some health.",
	                                                   25,
	                                                   0,
	                                                   0);
	public static ItemBase ether = new ItemConsumable("Ether",
	                                                   "Recovers some magicae.",
	                                                   0,
	                                                   25,
	                                                   0);
	public static ItemBase strongPotion = new ItemConsumable("Strong Potion",
	                                                         "Recovers a large amount of health.",
	                                                         50,
	                                                         0,
	                                                         0);
	public static ItemBase strongEther = new ItemConsumable("Strong Ether",
	                                                        "Recovers a large amount of magicae.",
	                                                        0,
	                                                        50,
	                                                        0);
}

