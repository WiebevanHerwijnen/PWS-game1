using UnityEngine;
using System.Collections;

public class playerControls : MonoBehaviour
{

    public float MoveSpeed;
    public GameObject KogelVriendelijkNormaal;
    public GameObject bulletPosition;
    int looper = 1;
   
    // Use this for initialization
    void Start()
    {
        MoveSpeed = 5f;
        
    }

    // Update is called once per frame
    //
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            GameObject bullet01 = (GameObject)Instantiate(KogelVriendelijkNormaal);//code voor het schieten van de bullet
            bullet01.transform.position = bulletPosition.transform.position;
        }

        Vector3 pos = transform.position;
        transform.Translate(MoveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, MoveSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 0f); //code voor de movement





          }
   
      }
            

        
    

