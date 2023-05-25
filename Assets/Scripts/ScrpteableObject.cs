using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Item/New Weapon")]
public class ScrpteableObject : ScriptableObject
{

    public string weaponName;

    public string weaponDescription;

    public Sprite weaponSprite;

    public float weaponDamage;
    
    public float weaponMagicDamage;

    public float weaponType;
}
