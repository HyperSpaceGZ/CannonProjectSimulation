using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CannonShot : MonoBehaviour
{
    public float BulletForce;
    public float objectLifetime = 3;
    public GameObject Bullet;
    public Transform BulletSpawner;
    public Slider ForceSlider;
    public TextMeshProUGUI ForceText;


    public void Update()
    {
        BulletForce = ForceSlider.value;
        ForceText.text = "" + ForceSlider.value;
    }

    void ShootBall()
    {
        GameObject bulletClone = Instantiate(Bullet, BulletSpawner.position, BulletSpawner.rotation);
        Rigidbody bulletRB = bulletClone.GetComponent<Rigidbody>();
        bulletRB.AddRelativeForce(Vector3.forward * BulletForce, ForceMode.Impulse);
        StartCoroutine(DeactivateObject(bulletClone));
    }

    IEnumerator DeactivateObject(GameObject objToDeactivate)
    {
        yield return new WaitForSeconds(objectLifetime);
        Destroy(objToDeactivate);
    }

    private void OnEnable()
    {
        ShootingButton.shootingEvent += ShootBall;

    }

    private void OnDisable()
    {
        ShootingButton.shootingEvent -= ShootBall;
    }
}
