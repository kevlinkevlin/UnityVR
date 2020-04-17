using UnityEngine;
using UnityEngine.AI;

public class MonsterController : MonoBehaviour
{
    public GameObject MyTarget;
    private NavMeshAgent MyAgent;
    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        MyAgent = GetComponent<NavMeshAgent>();
        ani = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float dis = Vector3.Distance(transform.position,MyTarget.transform.position);
        // Debug.Log(dis);
        if(dis >= 20)
        {
            ani.SetBool("run",false);
            // MyAgent.speed = 3;
            MyAgent.ResetPath();
        }
        else if (dis < 20 && dis > 5)
        {
            ani.SetBool("run",true);
            MyAgent.SetDestination(MyTarget.transform.position);
            
        }
        else
        {
            ani.SetBool("run",false);
            ani.SetTrigger("attack");
            MyAgent.stoppingDistance = 3.0f;
        }
        
    }
}
