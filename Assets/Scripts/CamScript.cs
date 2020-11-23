using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    public float speedH;
    public float speedV;
    public float speedX;
    public float speedY;
    private Animator animation;

    float moverHorizontal;
    float moverVertical;
    float zoom;
    float yaw;
    float pitch;

    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        moverHorizontal = Input.GetAxis("Horizontal");
        moverVertical = Input.GetAxis("Vertical");
        zoom = Input.mouseScrollDelta.y*3f;
        transform.Translate(moverHorizontal, zoom, moverVertical);

        
        yaw += speedX * Input.GetAxis("Mouse X");
        pitch -= speedY * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch,yaw,0.0f);
        

        if (gameObject.transform.position.x > 269 && gameObject.transform.position.y > 3 && gameObject.transform.position.z > 205){
            Destroy(animation);
        }

    }
}
