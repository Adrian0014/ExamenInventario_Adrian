using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    
    public Scriptableweapon[] weapons;
    public Text[] weaponsNames;
    public Text[] weaponsPrice;
    public Image[] weaponsSprites;

    public Scriptableweapon[] armors;
    public Text[] armorsNames;
    public Text[] armorsPrice;
    public Image[] armorsSprites;

    void Awake()
    {
        instance = this;
    }

    public void AddWeapon(Scriptableweapon weapon)
    {
        for( int i = 0; i < weapons.Length; i++)
        {

            if(weapon.weaponType == 0)
            {
                if(weapons[i] == null)
                {
                    weapons[i] = weapon;
                    weaponsNames[i].text = weapon.weaponName;
                    weaponsPrice[i].text = weapon.weaponPrice;
                    weaponsSprites[i].sprite = weapon.weaponSprite;

                    return;                
                }
            }
            if(weapon.weaponType == 1)
            {
                if(armors[i] == null)
                {
                    armors[i] = weapon;
                    armorsNames[i].text = weapon.weaponName;
                    armorsPrice[i].text = weapon.weaponPrice;
                    armorsSprites[i].sprite = weapon.weaponSprite;

                    return;                
                }
            }   

        }
    }
   
}