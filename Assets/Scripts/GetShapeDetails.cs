using UnityEngine;

public class GetShapeDetails : MonoBehaviour
{
    public Light directionLight;
    public Light spotLight;
    public LayerMask shapeLayerMask;

    Ray mouseRay;
    RaycastHit raycastHit;
    // Start is called before the first frame update
    void Start()
    {
        UIManager.INSTANCE.close.onClick.AddListener(ResetHighlightedObjects);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(mouseRay, out raycastHit, shapeLayerMask))
            {
                Debug.Log(raycastHit.collider.gameObject.layer.ToString());
                Debug.Log("mask: " + shapeLayerMask.ToString());
                if (raycastHit.collider.gameObject.layer == 6)
                {
                    Helper.SELECTED_SHAPE = raycastHit.collider.gameObject;
                    Shape shape = Helper.SELECTED_SHAPE.GetComponent<ShapeDetails>().shape;
                    UIManager.INSTANCE.shapeProperties.text = $"Shape: {shape.name} \n" +
                        $"Formula of volume: {shape.VolumeFormula} \n" +
                        $"Formula of Surface Area: {shape.SurfaceareaFormula}.";
                    Debug.Log(raycastHit.collider.tag);
                    HighlightSelectedObject();
                    UIManager.INSTANCE.OpenPanels();
                }
            }
        }
    }

    void HighlightSelectedObject()
    {
        directionLight.enabled = false;
        spotLight.enabled = true;
        spotLight.gameObject.transform.position = new Vector3(raycastHit.collider.gameObject.transform.position.x, spotLight.gameObject.transform.position.y, raycastHit.collider.gameObject.transform.position.z);
    }

    void ResetHighlightedObjects()
    {
        directionLight.enabled = true;
        spotLight.enabled = false;
        UIManager.INSTANCE.ClosePanels();
    }
}
