using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

	public AmmoParam ammoParam;
	private Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.gravityScale = ammoParam.gravity_Force;
		rb.AddForce(transform.right * ammoParam.speed, ForceMode2D.Impulse);
	}
}
