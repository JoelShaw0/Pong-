using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float MovementSpeed = 20;
    public KeyCode FirstUp;
    public KeyCode FirstDown;
    public KeyCode FirstLeft;
    public KeyCode FirstRight;
    public float tiltAngle;
    float smooth = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //var movement = Input.GetAxis("Vertical");
        //transform.position += new Vector3(0, movement, 0) * Time.deltaTime * MovementSpeed;
        if (Input.GetKey(FirstUp))
        {
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime * MovementSpeed;
        }
        else if (Input.GetKey(FirstDown))
        {
            transform.position += new Vector3(0, -1, 0) * Time.deltaTime * MovementSpeed;
        }
        else if (Input.GetKey(FirstLeft))
        {
            float tiltAroundZ = 1 * tiltAngle;
            Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }
        else if (Input.GetKey(FirstRight))
        {
            float tiltAroundZ = 1 * -tiltAngle;
            Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }
        else if (Input.GetKey(KeyCode.R))
        {
            //SceneManager.LoadScene("TwoPlayer");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
