using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class vie : MonoBehaviour {

	public float vie_tt;
	public float LifePoint;
	public Image bar;

	void Start () {
		
	}
	

	void Update () {
		bar.rectTransform.localScale = new Vector3(LifePoint / vie_tt, 1.0f, 1.0f);
	}
}
