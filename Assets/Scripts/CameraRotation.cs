using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button))]
public class CameraRotation : MonoBehaviour
{

    public GameObject curr_camera;
    public GameObject center;
    //public GameObject right_camera;
    //public GameObject left_camera;
    public Button right, left;
    [SerializeField] float maxRotationSpeed;

    //public UnityEvent onPointerDown;
    //public UnityEvent onPointerUp;

    //public UnityEvent whilePointerPressed;

    // Start is called before the first frame update
    void Start()
    {
        curr_camera.SetActive(true);
        right.onClick.AddListener(RightButtonClicked);
        left.onClick.AddListener(LeftButtonClicked);
    }


    void RightButtonClicked() {  
        curr_camera.transform.RotateAround(center.transform.position, curr_camera.transform.up, -1 * maxRotationSpeed * Time.deltaTime); 
    }

    void LeftButtonClicked() {
        curr_camera.transform.RotateAround(center.transform.position, curr_camera.transform.up, 1 * maxRotationSpeed * Time.deltaTime);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
