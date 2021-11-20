using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CameraHandling : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bar;
    public GameObject pectus_bar;
    public GameObject sternum;
    Vector3 Localposition;
    Vector3 temp;
    [SerializeField] float maxRotationSpeed;
    [SerializeField] TextMeshProUGUI promptText;
    float rotation;
    float rotation_temp;
    public Text text;
    public Text text_1;
    void Start()
    {
        Localposition = bar.transform.position;
        temp = Localposition; 
        rotation = sternum.transform.rotation.eulerAngles.x - 270;
        rotation_temp = rotation;
        Debug.Log(temp);
        Debug.Log(rotation);
        text_1.text = "The position of the bar is: " + temp.ToString();
        text.text = "The rotation of the sternum is: " + rotation_temp.ToString();

    }


    // Update is called once per frame
    void Update()
    {
        Localposition = bar.transform.position;
        rotation = sternum.transform.rotation.eulerAngles.x - 270;
        if (Localposition != temp) {
            temp = Localposition;
            text_1.text = "bar: " + temp.ToString();
        } 
        if (Mathf.Abs(rotation - rotation_temp) > 1) {
            rotation_temp = Mathf.Floor(rotation);
            text.text =  rotation_temp.ToString() + " degrees";
        } 


            float rotationInput = Input.GetAxis("Vertical");
            bar.transform.RotateAround(pectus_bar.transform.position, bar.transform.right, rotationInput * maxRotationSpeed * Time.deltaTime);
    }
}
