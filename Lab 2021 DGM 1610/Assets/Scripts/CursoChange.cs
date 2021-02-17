using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursoChange : MonoBehaviour
{
    private void OnMouseEnter()
    {
        CursorController.instance.CursorChanger();
    }
}
