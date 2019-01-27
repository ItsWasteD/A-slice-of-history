using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CutsceneManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int currentCutscene = 0;

    private string text1 = @"Vor etwa 13,8 Miliarden Jahren hat alles mit dem Urknall begonnen. 
    Das Universum begann sich rasant auszudenen. Die ersten Planeten entstanden.
    Zu dieser Zeit war aber alles Leben noch sehr weit entfernt.";

    private string text2 = @"Die ersten Lebewesen waren Bakterien sie entstanden vor 3,77 Milliarden Jahren. Sie haben keinen Zellkern und vermehrten sich nur durch Teilung.
    Diese Bakterien waren sehr resistent und kamen auch ohne Sauerstoff aus.";

    private string text3 = @"Die Organismen entwickelten sich immer wie weiter fort. Zu dieser Zeit leben im Ozean schon Bakterien, Einzeller, Pilze sowie vielzählige Pflanzen und Tiere.";

    private string text4 = @"Danach gingen viele Tier vom Wasser auf das Land über es gab eine Mischung aus Fisch und Landwirbeltiere. In den weiteren 50 Millionen Jahren war die Zeit der Landpflanzen
    und Lurche.";

    private string text5 = @"Vor 250 Millionen Jahren tauchten im Meer neue Arten von Fischen auf. Auf dem Land haben sich die Gruppen der Reptilien mächtig Entwickelt. 
    Diese Zeit gilt als Zeitalter der Dinosaurier.";

    private string text6 = @"Vor 65 Millionen Jahren begann die Neuzeit. Die Säugetiere entwickelten sich. Das Klima wurde trockener, die Wälder gingen zurück und Grasland began sich auszubreiten.";

    private string text7 = @"Vor 3,2 Millionen Jahren gab es die ersten Menschen. Sie gingen aufrecht und ihnen ging es rein ums überleben.

    Helfe im folgenden Spiel dem Neandertaler Nahrung zu finden.";

    private string[] cutscene0;

    private string[][] cutscenes;

    private int currentChapter = 0;

    void Start()
    {
        cutscene0 = new string[] { text1, text2, text3, text4, text5, text6, text7 };

        cutscenes = new string[][] { cutscene0 };

        text.text = cutscenes[currentCutscene][currentChapter];
    }

    public void nextText()
    {
        if(currentChapter + 1 < cutscenes[currentCutscene].Length)
        {
            currentChapter++;
            text.text = cutscenes[currentCutscene][currentChapter];
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }

    public void previousText()
    {
        if(currentChapter - 1 >= 0)
        {
            currentChapter--;
            text.text = cutscenes[currentCutscene][currentChapter];
        }
    }
}
