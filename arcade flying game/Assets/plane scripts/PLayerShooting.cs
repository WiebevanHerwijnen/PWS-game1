using UnityEngine;
using System.Collections;

public class PLayerShooting : MonoBehaviour {
    float Speed;
    public GameObject KogelVriendelijkNormaal;
    public GameObject bulletPosition;
	// Use this for initialization
	void Start () {
        Speed = 20f;
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 position = transform.position;
        position = new Vector2(position.x, position.y + Speed * Time.deltaTime);
        transform.position = position;
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        if(transform.position.y > max.y)
        {
            Destroy(gameObject);
        }
	
	}
}
