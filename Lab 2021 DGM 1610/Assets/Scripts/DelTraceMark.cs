﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelTraceMark : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bulletE"))
        {
            Destroy(gameObject);
        }
        
    }

}
