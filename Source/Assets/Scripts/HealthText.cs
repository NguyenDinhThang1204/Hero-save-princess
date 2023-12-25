using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthText : MonoBehaviour
{
    public Vector3 moveSpeed = new Vector3 (0, 75, 0);

    RectTransform textTransform;

    private void Awake()
    {
        textTransform = GetComponent<RectTransform>();
    }
    private void Update()
    {
        textTransform.position += moveSpeed * Time.deltaTime;
    }
}
