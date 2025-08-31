using UnityEngine;
using UnityEngine.UI;

public class PanelCloseButton : MonoBehaviour
{
    [SerializeField] private GameObject panelToClose;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(ClosePanel);
    }

    private void ClosePanel()
    {
        panelToClose.SetActive(false);
    }
}