using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class MenuController : MonoBehaviour
{
    [Header("Панели")]
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject authorsPanel;
    [SerializeField] private GameObject aboutPanel;
    [SerializeField] private GameObject pressed;

    [Header("Кнопки")]
    [SerializeField] private Button startButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button authorsButton;
    [SerializeField] private Button aboutButton;
    [SerializeField] private Button exitPanelButton;
    [SerializeField] private Button exitButton;

    private void Start()
    {
        // Скрываем панели при запуске
        settingsPanel.SetActive(false);
        authorsPanel.SetActive(false);
        aboutPanel.SetActive(false);
        pressed.SetActive(false);

        // Назначаем методы обработчики для кнопок
        startButton.onClick.AddListener(StartGame);
        settingsButton.onClick.AddListener(ShowSettings);
        authorsButton.onClick.AddListener(ShowAuthors);
        aboutButton.onClick.AddListener(ShowAbout);
        exitPanelButton.onClick.AddListener(ExitPanel);
        exitButton.onClick.AddListener(ExitGame);
    }

    private void StartGame()
    {
        // Загружаем сцену с индексом 1 (должна быть добавлена в Build Settings)
        SceneManager.LoadScene(1);
    }

    private void ShowSettings()
    {
        // Активируем панель настроек
        settingsPanel.SetActive(true);
        pressed.SetActive(true);
    }

    private void ShowAuthors()
    {
        // Активируем панель авторов
        authorsPanel.SetActive(true);
        pressed.SetActive(true);
    }

    private void ShowAbout()
    {
        // Активируем панель авторов
        aboutPanel.SetActive(true);
        pressed.SetActive(true);
    }

    private void ExitPanel()
    {
        // Активируем панель авторов
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