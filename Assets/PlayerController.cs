using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

  public Text countText;
  public Text endOfGameText;

  private int pickUpCount;
  private int pickUpTotal;
  private Rigidbody rb;

  // Use this for initialization
  void Start () {
    pickUpCount = 0;
    pickUpTotal = (GameObject.FindGameObjectsWithTag ("PickUp")).Length;
    rb = GetComponent<Rigidbody> ();
    UpdateCountText ();
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

  void OnTriggerEnter (Collider other) {
    if (other.gameObject.CompareTag ("PickUp")) {
      other.gameObject.SetActive (false);
      pickUpCount += 1;
      UpdateCountText ();
    }
  }

  void UpdateCountText () {
    countText.text = "Count: " + pickUpCount;

    if (pickUpCount == pickUpTotal) {
      endOfGameText.gameObject.SetActive (true);
    }
  }
}
