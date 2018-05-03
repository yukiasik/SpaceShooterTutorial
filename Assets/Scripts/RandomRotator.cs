using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
	public float tumble;

	void Start ()
	{
        transform.eulerAngles = new Vector3(Random.Range(0, 300), Random.Range(0, 300), Random.Range(0, 300));
	}

    private void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * tumble);
    }
}
