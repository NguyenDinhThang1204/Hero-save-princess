using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public Transform launchPoint;
    public GameObject projectilePrefab;
    
    public void FireProjectile()
    {
        GameObject projectile =  Instantiate(projectilePrefab, launchPoint.position, projectilePrefab.transform.rotation);
        Vector3 origScale = projectile.transform.localScale;

        projectile.transform.localScale = new Vector3(
            origScale.x * transform.localScale.x > 0 ? 1 : -1,
            origScale.y,
            origScale.z
            );
        float angleZ = transform.localScale.x > 0 ? 225f : 135f;
        projectile.transform.rotation = Quaternion.Euler(0f, 0f, angleZ);
    }
}
