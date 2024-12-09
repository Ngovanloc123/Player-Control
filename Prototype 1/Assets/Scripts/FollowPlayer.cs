using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Làm cho camera không có hiện tượng jittering
    void LateUpdate()
    {
        // Thêm vector để camera phía sao object
        transform.position = player.transform.position + offset; 
    }
}
