using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float velcidadMovimiento;
    private float inputH;
    private float inputV;
    private CharacterController controller;
    [SerializeField] Transform camara;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        inputH = Input.GetAxisRaw("Horizontal");
        inputV = Input.GetAxisRaw("Vertical");
        Vector3 direccionMovimiento = (camara.forward * inputV + camara.right * inputH).normalized;

        controller.Move(direccionMovimiento * velcidadMovimiento * Time.deltaTime);
    }
}
