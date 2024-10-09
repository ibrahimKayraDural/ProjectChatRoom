using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public string MenuName;
    public bool b_Open = false;

    public void Open() => SetEnablity(true);
    public void Close() => SetEnablity(false);
    public void SetEnablity(bool setTo)
    {
        b_Open = setTo;
        gameObject.SetActive(setTo);
    }
}
