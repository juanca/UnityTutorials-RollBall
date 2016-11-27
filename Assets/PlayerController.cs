using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

  private Rigidbody rb;

	// Use this for initialization
	void Start () {
    rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

  // FixedUpdate is called once per fixed frame
  void FixedUpdate () {
    float horizontal = Input.GetAxis ("Horizontal");
    float vertical = Input.GetAxis ("Vertical");
    Vector3 movement = new Vector3 (horizontal, 0.0f, vertical);

    rb.AddForce (movement);
  }
}
