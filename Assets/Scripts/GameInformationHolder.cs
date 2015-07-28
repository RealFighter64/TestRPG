using UnityEngine;
using System.Collections;

public class GameInformationHolder : MonoBehaviour
{
	public static GameInformation gameInformation = new GameInformation();

	public void Awake ()
	{
		DontDestroyOnLoad (this.gameObject);
	}
}

