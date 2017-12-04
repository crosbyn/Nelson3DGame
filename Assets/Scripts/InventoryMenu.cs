using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenu : MonoBehaviour {

    [SerializeField]
    private GameObject inventoryMenuPanel;

    private List<InventoryObject> playerInventory;
   
#region Properties
    public List<InventoryObject> PlayerInventory
    {
        get
        {
            return playerInventory;
        }
    }
    #endregion

    //Happens before Start
    //Needs to initial inventory list early so other things can access it in Start
    private void Awake()
    {
        playerInventory = new List<InventoryObject>();
    }


    void Start ()
    {
        HideMenu();
	}
	

	void Update ()
    {
        HandleInput();
	}

    private bool IsMenuOpen
    {
        get
        {
            return inventoryMenuPanel.activeSelf;
        }
    }

    private void HandleInput()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (IsMenuOpen)
                HideMenu();
            else
                ShowMenu();
        }
    }

    private void ShowMenu()
    {
        inventoryMenuPanel.SetActive(true);
        UpdateCursor();
    }

    private void HideMenu()
    {
        inventoryMenuPanel.SetActive(false);
        UpdateCursor();
    }

    private void UpdateCursor()
    {
        if (IsMenuOpen)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.visible = false;
        }
    }


}
