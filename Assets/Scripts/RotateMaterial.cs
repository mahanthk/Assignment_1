using UnityEngine;

public class RotateMaterial : MonoBehaviour
{
    private void OnMouseOver()
    {
        transform.Rotate(new Vector3(0, 1, 0) * 20 * Time.deltaTime, Space.Self);
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Helper.SELECTED_SHAPE.GetComponent<MeshRenderer>().materials = this.gameObject.GetComponent<MeshRenderer>().materials;
        }
    }
}
