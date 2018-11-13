using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class vie : MonoBehaviour {

	public int vie_tt;
	public int LifePoint;
	public Image bar;

	void Start () {
		
	}
	

	void Update () {
		print(bar.rectTransform.rect);
	}
}
