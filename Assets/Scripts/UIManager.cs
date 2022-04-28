using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager INSTANCE;

    public GameObject panelMaterials;
    public GameObject panelProperties;
    public Button close;
    public Text shapeProperties;

    private void Awake()
    {
        if(INSTANCE != null)
        {
            Destroy(this);
        }
        else
        {
            INSTANCE = this;
        }
        ClosePanels();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClosePanels()
    {
        panelMaterials.SetActive(false);
        panelProperties.SetActive(false);
        shapeProperties.gameObject.SetActive(false);
    }

    public void OpenPanels()
    {
        panelMaterials.SetActive(true);
        panelProperties.SetActive(true);
        shapeProperties.gameObject.SetActive(true);
    }
}
