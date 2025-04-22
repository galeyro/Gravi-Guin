using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraScript : MonoBehaviour
{

    [SerializeField] private float followSpeed = 0.2f;
    //[SerializeField] private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] private Vector3 offset;

    void Update()
    {
        if (PlayerController.Instance != null)
        {
            Vector3 targetPosition = PlayerController.Instance.transform.position + offset;
            targetPosition.z = transform.position.z; // Mantén el Z fijo
            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
        }
    }
}
