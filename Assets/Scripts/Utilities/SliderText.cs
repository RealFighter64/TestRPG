using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderText : MonoBehaviour
{
	public void SetSliderText(float value) {
		GetComponent<Text>().text = value + "";
	}
}
