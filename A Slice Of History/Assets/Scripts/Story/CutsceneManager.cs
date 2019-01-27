using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CutsceneManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int currentCutscene = 0;

    //Chapter 1
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

    //Chapter 2
    private string text8 = @"Der griechische Bote Pheidippides, lief im Jahr 490 vor Christus in zwei Tagen von Athen nach Sparta. Er wollte Hilfe im Krieg gegen die Perser suchen.
    500 Jahre später formten Plutarch und Lukian eine Legende.";
    private string text9 = @"Die Legende besagt, das nach dem Sieg der Athener, in der Schlacht von Marathon, ein Läufer den 40 Kilometer langen Weg auf sich nahm, um zu berichten, dass sie gesiegt haben
    und anschliessen vor Erschöpfung Tod zusammengebrochen sei.";
    private string text10 = @"Bei den Langstreckenläufen der Neuzeit dachte aber niemand an die Historie. Erst als 1890 ein Hügel mit Gräbern der gefallenen Athener ausgegraben wurde, kam die Legende wieder
    in Erinnerung.";
    private string text11 = @"Der Sprachwissenschaftler Michel Bréal wollte den legendären Lauf im Rahmen der 1896 geplanten Olympischen Spielen von Athen als Wettkampf aufleben lassen.";
    private string text12 = @"Mit einem Brief, teilte er seinem Freund dem Gründer des IOC(Internationales Olympisches Komitee) mit, dass der Sieger einen von ihm gestifteten Pokal erhalten soll.
    So wurde der Olympische Marathon 1896 von Athen der erste organisierte Marathonlauf.";
    private string text13 = @"Helfe dem Läufer den Marathon zu gewinnen!";

    private string[] cutscene0;
    private string[] cutscene1;

    private string[][] cutscenes;

    private int currentChapter = 0;

    void Start()
    {
        cutscene0 = new string[] { text1, text2, text3, text4, text5, text6, text7 };
        cutscene1 = new string[] { text8, text9, text10, text11, text12, text13 };

        cutscenes = new string[][] { cutscene0, cutscene1 };

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
            //SceneManager.LoadScene(2);
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
