
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{

    public Transform player;

    Vector3 offset;



    private void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 targetPos = offset + player.position;
        targetPos.x = 0;
        transform.position = targetPos;
    }
}
