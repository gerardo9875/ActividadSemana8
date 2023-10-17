using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet1;
    [SerializeField]
    private GameObject bullet2;

    private void Update()
    {
        Shoot();
    }

    

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = Instantiate(bullet1);
            obj.transform.position = transform.position;
           
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            GameObject obj = Instantiate(bullet2);
            obj.transform.position = transform.position;
        }
    }
}
