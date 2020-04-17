
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public ParticleSystem FireEffect;
    private AudioSource FireSound;
    private RaycastHit rayHit;
    public GameObject Player;
    
    private int PI_angle = 120;
    public float speed = 0.0f;
    private void Start()
    {
        FireSound = GetComponent<AudioSource>(); 
    }

    private void Update()
    {   

        if (Input.GetKey(KeyCode.W))
    {
        Player.transform.Translate(transform.forward * Time.deltaTime * speed );
        Debug.Log("前");

    }
    else if (Input.GetKey(KeyCode.A))
    {
        Player.transform.Translate(-transform.right * Time.deltaTime * speed );
        Debug.Log("左");
    }
    else if (Input.GetKey(KeyCode.S))
    {
        Player.transform.Translate(-transform.forward * Time.deltaTime * speed );
        Debug.Log("後");

    }
    else if (Input.GetKey(KeyCode.D))
    {
        Player.transform.Translate(transform.right * Time.deltaTime * speed );
        Debug.Log("右");
    }
    else if (Input.GetKey(KeyCode.Space))
    {
        Player.transform.Translate(transform.up * Time.deltaTime * speed );
        Debug.Log("右");
    }
    else if (Input.GetKey(KeyCode.F))
    {
        Player.transform.Translate(-transform.up * Time.deltaTime * speed );
        Debug.Log("右");
    }
    else
    {}
            

    }
    public void FireEvent()
    {
        if(Physics.Raycast(transform.position,transform.forward,out rayHit,100f))
        {
            FireEffect.transform.position = rayHit.point;
            FireEffect.transform.rotation = Quaternion.Euler(270,0,0);
            FireEffect.Stop();
            FireEffect.Play();
            FireSound.Stop();
            FireSound.Play();
        }
        if(rayHit.transform.tag == "Enemy")
        {
            Debug.Log("Hit!");
            Destroy(rayHit.transform.gameObject);
            GMScript.Monster_Num++;
        }

    }
}
