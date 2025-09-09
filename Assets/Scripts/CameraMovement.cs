using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] public GameObject camera;
    [SerializeField] private float speed;
    private Vector3 cameraV;
    private Vector3 playerV;
    [SerializeField] private float temperDistance;



    // Update is called once per frame
    void Update()
    {
        cameraV = new Vector3(camera.transform.position.x, camera.transform.position.y, -10);
        playerV = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        Movement();
    }

    public void Movement()
    {
         float ypos = player.transform.position.y - camera.transform.position.y;
            float xpos = player.transform.position.x - camera.transform.position.x;
            if (ypos > temperDistance || ypos < -temperDistance || xpos > temperDistance || xpos < -temperDistance){
                transform.position = Vector3.MoveTowards(cameraV,playerV,30f * Time.deltaTime);
            } else {
                transform.position = Vector3.MoveTowards(cameraV,playerV,10f * Time.deltaTime);
            }
    }
}
