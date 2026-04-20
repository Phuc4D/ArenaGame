using UnityEngine;

public class Gun : MonoBehaviour
{
    private float rotateOffSet = 180f;
    [SerializeField] private Transform firePos;

    [SerializeField] private GameObject bulletPrefabs;
    [SerializeField] private float shotDelay = 0.15f;
    [SerializeField] private int maxAmmo = 24;
    private float nextShot;
    private bool isReload = false;
    [SerializeField] private float reloadDelay = 0.5f;
    private float reloadTime;



    public int currentAmmo;

    void Start()
    {
        currentAmmo = maxAmmo;
    }
    void Update()
    {
        RotateGun();
        Shoot();
        Reload();
        if (currentAmmo <= 0 && !isReload)
        {
            Reload();
        }
    }
    void Shoot()
    {
        if (Input.GetMouseButtonDown(0) && currentAmmo > 0 && Time.time > nextShot && !isReload)
        {
            nextShot = Time.time + shotDelay;
            Instantiate(bulletPrefabs, firePos.position, firePos.rotation);
            currentAmmo--;
        }
    }
    void Reload()
    {
        if (Input.GetMouseButtonDown(1) && currentAmmo < maxAmmo && !isReload)
        {
            isReload = true;
            reloadTime = Time.time + reloadDelay;
        }
        if (isReload && Time.time > reloadTime)
        {
            currentAmmo = maxAmmo;
            isReload = false;
        }

    }
    void RotateGun()
    {
        if (Input.mousePosition.x < 0 || Input.mousePosition.x > Screen.width || Input.mousePosition.y < 0 || Input.mousePosition.y > Screen.height)
        {
            return;
        }
        Vector3 displacement = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(displacement.y, displacement.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle + rotateOffSet);
        if (angle < -90 || angle > 90)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, -1, 1);

        }
    }


}
