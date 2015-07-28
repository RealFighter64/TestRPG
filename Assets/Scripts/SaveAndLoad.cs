using UnityEngine;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveAndLoad
{
	public static BinaryFormatter binaryFormatter = new BinaryFormatter();

	public static string Serialize(object obj) {
		MemoryStream memoryStream = new MemoryStream();
		binaryFormatter.Serialize(memoryStream, obj);
		return System.Convert.ToBase64String(memoryStream.ToArray());
	}

	public static object Deserialize(string temp) {
		if (temp == string.Empty) {
			return null;
		}
		MemoryStream memoryStream = new MemoryStream(System.Convert.FromBase64String(temp));
		return binaryFormatter.Deserialize(memoryStream);
	}

	public static void SaveGameInformation() {
		PlayerPrefs.SetString("_GAMEINFORMATION", Serialize(GameInformationHolder.gameInformation));
	}

	public static void LoadGameInformation() {
		GameInformationHolder.gameInformation = (GameInformation) Deserialize(PlayerPrefs.GetString("_GAMEINFORMATION"));
	}
}

