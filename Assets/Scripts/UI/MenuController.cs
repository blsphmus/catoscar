using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class MenuController : MonoBehaviour
{
    [Header("������")]
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject authorsPanel;
    [SerializeField] private GameObject aboutPanel;
    [SerializeField] private GameObject pressed;

    [Header("������")]
    [SerializeField] private Button startButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button authorsButton;
    [SerializeField] private Button aboutButton;
    [SerializeField] private Button exitPanelButton;
    [SerializeField] private Button exitButton;

    private void Start()
    {
        // �������� ������ ��� �������
        settingsPanel.SetActive(false);
        authorsPanel.SetActive(false);
        aboutPanel.SetActive(false);
        pressed.SetActive(false);

        // ��������� ������ ����������� ��� ������
        startButton.onClick.AddListener(StartGame);
        settingsButton.onClick.AddListener(ShowSettings);
        authorsButton.onClick.AddListener(ShowAuthors);
        aboutButton.onClick.AddListener(ShowAbout);
        exitPanelButton.onClick.AddListener(ExitPanel);
        exitButton.onClick.AddListener(ExitGame);
    }

    private void StartGame()
    {
        // ��������� ����� � �������� 1 (������ ���� ��������� � Build Settings)
        SceneManager.LoadScene(1);
    }

    private void ShowSettings()
    {
        // ���������� ������ ��������
        settingsPanel.SetActive(true);
        pressed.SetActive(true);
    }

    private void ShowAuthors()
    {
        // ���������� ������ �������
        authorsPanel.SetActive(true);
        pressed.SetActive(true);
    }

    private void ShowAbout()
    {
        // ���������� ������ �������
        aboutPanel.SetActive(true);
        pressed.SetActive(true);
    }

    private void ExitPanel()
    {
        // ���������� ������ �������
        settingsPanel.SetActive(false);
        authorsPanel.SetActive(false);
        aboutPanel.SetActive(false);
        pressed.SetActive(false);
    }

    private void ExitGame()
    {
        UnityEngine.Application.Quit();
    }


}