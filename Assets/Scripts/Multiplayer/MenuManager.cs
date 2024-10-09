using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    [SerializeField] Menu[] _Menus;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else if (Instance != this) Destroy(gameObject);
    }

    public void OpenMenu(string menuToOpen)
    {
        foreach (var menu in _Menus)
        {
            menu.SetEnablity(menu.MenuName == menuToOpen);
        }
    }

    public void OpenMenu(Menu menuToOpen)
    {
        foreach (var menu in _Menus)
        {
            menu.Close();
        }
        menuToOpen.Open();
    }

    public void CloseMenu(Menu menu) => menu.Close();
}
