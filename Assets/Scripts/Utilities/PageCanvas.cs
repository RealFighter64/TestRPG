using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PageCanvas : MonoBehaviour
{
	public string startingPage;
	[HideInInspector]
	public Dictionary<string, Page> pages;
	[HideInInspector]
	public string currentPage;

	public void Start ()
	{
		Page[] children = GetComponentsInChildren<Page>();
		pages = new Dictionary<string, Page>();
		foreach (Page child in children) {
			pages.Add(child.gameObject.name, child);
		}
		currentPage = startingPage;
	}

	public void Update ()
	{
		foreach (string key in pages.Keys) {
			if (key == currentPage) {
				pages[key].gameObject.SetActive (true);
			} else {
				pages[key].gameObject.SetActive (false);
			}
		}
	}

	public void SwitchPage (string page)
	{
		currentPage = page;
	}

	public RectTransform GetElementInPageByName(string pageName, string elementName) {
		return pages[pageName].GetElementByName(elementName);
	}
}
