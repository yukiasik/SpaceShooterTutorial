using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTalinoController : MonoBehaviour
{
    public static BITalinoReader Reader;

    private void Start()
    {
        Reader = GetComponent<BITalinoReader>();
    }
}
