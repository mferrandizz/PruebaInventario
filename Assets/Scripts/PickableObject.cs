using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour
{
    public ScrpteableObject weapon;

    SpriteRenderer sRenderer;

    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();

        sRenderer.sprite = weapon.weaponSprite;
    }

    /*void OnTriggerEnter2D(Collider2D other)
    {
        InventoryManager.Instance.AddWeapon(weapon);
        Destroy(other.gameObject);

    }*/

}
