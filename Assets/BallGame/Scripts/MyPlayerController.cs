using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyPlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
	private int count;
	public Text countText;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		count = 0;
		setCountText();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		// float moveHorizontal = Input.GetAxis("Mouse X");
		// float moveVertical = Input.GetAxis("Mouse Y");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce(movement);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Pick Up Tag")) {
			other.gameObject.SetActive(false);
			count += 1;
			setCountText();
		}
	}

	void setCountText() {
		countText.text = "Count: "+ count.ToString();
	}


}
