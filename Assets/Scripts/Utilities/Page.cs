using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Page : MonoBehaviour
{
	[HideInInspector]
	public Dictionary<string, RectTransform> elements;

	// Use this for initialization
	public void Start ()
	{
		RectTransform[] children = GetComponentsInChildren<RectTransform>();

		elements = new Dictionary<string, RectTransform>();
		foreach (RectTransform child in children) {
			elements.Add(child.gameObject.name, child);
		}
	}

	public RectTransform GetElementByName(string name) {
		return elements[name];
	}
}

