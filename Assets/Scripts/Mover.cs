using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	//public BITalinoReader reader;

	private Rigidbody rb;
	public float speed;

	//public int channelRead = 0;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();

		rb.velocity = transform.forward * speed;
	}

	//void Update()
	//{
	//	BITalinoFrame[] frames = reader.getBuffer();

	//	if (frames.getAGetAnalogValue (channelRead) == 1) {
	//		rb.velocity = transform.forward * speed * 0.5f;
	//	}

	//}		

}
