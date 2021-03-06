using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mover : MonoBehaviour
{
	private Rigidbody rb;
    private double eda;
    private BITalinoReader reader;

    public float edaMultiplier = 1;
    public float edaValueToSlow = 100;
    public ManagerBITalino.Channels ChannelType;
    public bool UseBITalion;
    public float BasicSpeed;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
        eda = 0;
        if (!UseBITalion)
        {
            rb.velocity = transform.forward * BasicSpeed;
        }
        else
        {
            reader = BTalinoController.Reader;
        }
    }

    void Update()
    {
        if(!UseBITalion)
        {
            return;
        }
      
        if (reader.asStart)
        {
            foreach (BITalinoFrame frame in reader.getBuffer())
            {
                eda += frame.GetAnalogValue((int)ChannelType);
            }
            eda = (eda / reader.BufferSize) * -edaMultiplier;
            Debug.Log("EDA : " + eda);
            transform.Translate(transform.forward * Time.deltaTime * ((float)eda > edaValueToSlow ? BasicSpeed * 0.5f : BasicSpeed));
        }
    }

}
