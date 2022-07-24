using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public GameObject GameObject;
    private float time; 
    void Start()
    {
        #region Instantiate (Clonelama)
        //Duz Clonelama
        // Instantiate(GameObject);

        //gameobjectin parenti olur 
        //Instantiate(GameObject, transform);

        //bire-bir eyni pozisiyada olur 
        //Instantiate(GameObject, transform.position, transform.rotation);
        //Instantiate(GameObject, transform.position, Quaternion.identity);

        //Position isdeyimiz kimi teyin ede bilirik 
        //Instantiate(GameObject, new Vector3(transform.position.x,3f,5f), Quaternion.identity);
        // gameobjecte beraber etmek olur 
        //GameObject game  = Instantiate(GameObject, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity);
        //game.GetComponent<BoxCollider>().enabled = false;


        #endregion

        //time = 0;
        //print(time);
    }

    // Update is called once per frame
    void Update()
    {
        // 2 Saniyede bir obyekt spawn elemek 
        #region Spawn
        //if (time >= 2)
        //{
        //    Instantiate(GameObject, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity);
        //    time = 0;
        //}
        //else
        //{
        //    time += Time.deltaTime;
        //}
        #endregion
    }
}
