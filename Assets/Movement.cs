using Mirror;
using UnityEngine;

public class Movement : NetworkBehaviour
{
    void Update()
    {
        if (!hasAuthority)
            return;

        transform.position = transform.position + 3f * Time.deltaTime * new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0
        );
    }
}
