using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponBehavior : MonoBehaviour
{
    [SerializeField]
    private bool _shoot;
    [SerializeField]
    private float rateOfFire;

    public WeaponType weaponType;

    

    [SerializeField]
    private GameObject currentPlayerGun;
    [SerializeField]
    private Transform gunLocation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnShoot(InputAction.CallbackContext context){
        _shoot = context.ReadValue<bool>();
        Shoot();
    }

    public IEnumerator Shoot(){
        yield return new WaitForSeconds(rateOfFire);
        var bullet = Instantiate(weaponType.bulletPrefab, gunLocation.position, currentPlayerGun.transform.rotation);

        yield return null;
    }


}
