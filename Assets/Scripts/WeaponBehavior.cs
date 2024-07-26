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

    public GameObject tempBullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnShoot(InputValue value){
        //_shoot = value.Get<bool>();
        StartCoroutine("Shoot");
    }

    public IEnumerator Shoot(){
        Debug.Log("kill myself");
        yield return new WaitForSeconds(rateOfFire);
        var bullet = Instantiate(tempBullet, gunLocation.position, gunLocation.transform.localRotation);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward*1000);
        yield return null;
    }


}
