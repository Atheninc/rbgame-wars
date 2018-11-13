using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ball : MonoBehaviour {

	public AmmoParam ammoParam;
	private Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce(transform.right * ammoParam.speed, ForceMode2D.Impulse);
		rb.gravityScale = ammoParam.gravity_Force;
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			var a = other.gameObject.GetComponent<vie>();
			a.LifePoint -= ammoParam.degat;
		}
		Destroy(gameObject);
	}
}
