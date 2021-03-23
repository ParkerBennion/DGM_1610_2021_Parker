using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public static CursorController instance;
    public Texture2D crosHair, redCross;

    private void Awake()
    {
        instance = this;
        //Cursor.SetCursor(Croshair, Vector2.zero, CursorMode.ForceSoftware);
        //Cursor.visible = false;
    }

    public void CursorChanger()
    {
        Cursor.SetCursor(crosHair, new Vector2(crosHair.width / 2, crosHair.height / 2), CursorMode.Auto);
    }

    public void CursorChanger2()
    {
        Cursor.SetCursor(redCross, new Vector2(crosHair.width / 2, crosHair.height / 2), CursorMode.Auto);
    }

    public void CursorChanger3()
    {
        Cursor.SetCursor(null, Vector2.zero,CursorMode.Auto);
    }

/* void update()
 {
     Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
     transform.position = cursorPos;
 }*/
}
