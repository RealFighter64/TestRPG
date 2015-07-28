using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TotalText : MonoBehaviour {
	public Slider[] sliders;
	public Button submit;
	public float max;

	public void Update() {
		float total = 0;
		foreach(Slider slider in sliders) {
			total += slider.value;
		}

		GetComponent<Text>().text = total + "";

		if (total <= max) {
			submit.interactable = true;
		} else {
			submit.interactable = false;
		}
	}
}
