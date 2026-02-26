using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;

public class Player : MonoBehaviour
{
    [SerializeField] float velocity = 2;
    private Rigidbody2D rb;
    private PhotonView pv;

    public GameObject rayo;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        pv = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!pv.IsMine) return;

       
                transform.position = new Vector2(transform.position.x, transform.position.y + Input.GetAxis("Vertical") * Time.deltaTime * velocity);
            
            if (transform.position.y > 4)
            {
                transform.position = new Vector2(transform.position.x, 4);
            }
            if (transform.position.y < -4)
            {
                transform.position = new Vector2(transform.position.x, -4);
            }
        
            if (Input.GetKeyDown(KeyCode.J))
        {
            rayo.GetComponent<GenerateRayo>().GenerarRayo();
        }
    }
}
