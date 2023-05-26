using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Items/New Weapon")]
public class Scriptableweapon : ScriptableObject
{
    public string weaponName;
    public string weaponPrice;
    public Sprite weaponSprite;
    public float weaponType;

}
