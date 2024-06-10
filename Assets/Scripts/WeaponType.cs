using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewWeaponType", menuName = "ScriptableObjects/Weapon Type", order = 1)]
public class WeaponType : ScriptableObject
{
    public string weaponName;
    public string weaponDescription;
    public float damageDealt;
    public GameObject gunObj;
    public GameObject bulletPrefab;
}
