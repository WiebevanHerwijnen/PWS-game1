using UnityEngine;
using System.Collections;

public class EnemyGun : MonoBehaviour {
    public GameObject enemybulletGO;

	// Use this for initialization
	void Start () {
        Invoke("FireEnemyBullet", 1f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FireEnemyBullet()
    {
        GameObject playerShip = GameObject.Find("PlayerGO");

        if(playerShip != null) //dit wil zeggen: als het schip nog niet dood is.
        {
            GameObject bullet = (GameObject)Instantiate(enemybulletGO);
            bullet.transform.position = transform.position;
            Vector2 direction = playerShip.transform.position - bullet.transform.position;
            bullet.GetComponent<EnemyBullet>().SetDirection(direction);


        }
    }
}
