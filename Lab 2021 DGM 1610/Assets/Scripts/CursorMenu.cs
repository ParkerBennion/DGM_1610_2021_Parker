using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMenu : MonoBehaviour
{ 
    private void OnMouseEnter()
    {
        CursorController.instance.CursorChanger2();
    }
}
