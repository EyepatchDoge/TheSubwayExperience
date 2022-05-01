using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    

    public void MouseOn()
    {
        Cursor.visible = true;
    }

    public void MouseOff()
    {
        Cursor.visible = false;
    }

}
