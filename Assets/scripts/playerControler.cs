using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerControler : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    

    private int count;
    public Text countText;
    public Text winText;
    //called before rendring a frame game code go there
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        countText.text = "Count: " + count.ToString();
        if (count >= 48)
        {
            winText.text = "You Win!";
        }
        winText.text = ""; 
    }

    //called before any physics calculation physics code here (forces here)
    void FixedUpdate () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0, v);
        rb.AddForce(movement *speed);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            countText.text = "Count: " + count.ToString();
            if (count >= 48)
        {
            winText.text = "You Win!";
        }
        }
    }
}
