using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PatricksPsychoDings
{
    public partial class PatricksPsychoDings : Form
    {

        #region Eigenschaften für die Nummernanzeige

        private Timer Timer;
        private Random Random;
        private List<Label> NumberLabels;

        private int CurrentLabel = -1;                                      // Der index des aktuell angezeigten Nummernfeldes
        private bool AcceptNumberInput = false;                             // Legt fest ob das drücken der F1 Taste ausgewertet wird.
        private List<int> NumberStack = new List<int>();                    // Die Liste der letzten Zahlen
        private List<bool> UserNumberResponseHistory = new List<bool>();    // Eine Historie von richtig/falschen F1 eingaben des Benutzers

        #endregion

        #region Eigenschaften für die angezeigten und eingegebenen Wörter

        private List<KeyValuePair<string, string>> UserInputs = new List<KeyValuePair<string, string>>();   // Zwischenspeicher für das Schlüsselwort und die Antwort des Benutzers

        private List<string> Keywords = new List<string> {                  // Die Liste der Wörter die dem Benutzer angezeigt werden
            "Speck",
            "Kuchen",
            "Laktose",
            "Puderzucker",
            "Haferschleim",
            "Schinken",
            "Joghurt",
            "Marzipan",
            "Milch",
            "Hefe"
        };

        #endregion

        public PatricksPsychoDings()
        {
            InitializeComponent();                                          // Erstellen der Komponenten des aktuellen Fensters. Muss an erster stelle stehen

            Random = new Random();                                          // Zufallsgenerator initialisieren

            Timer = new Timer()
            {
                Interval = 2000                                             // Den Interval auf 2 Sekunden festlegen
            };

            Timer.Tick += UpdateNumberDisplay;                              // Diese Methode wird beim erreichen des Intervals aufgerufen

            NumberLabels = new List<Label> {                                // Die Nummernfelder in der richtigen Reihenfolge in eine Liste laden
                labelTopLeft,
                labelTopRight,
                labelBottomRight,
                labelBottomLeft
            };
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;                                    // "Los geht's!" Button ausblenden

            textInput.Visible = true;                                       // Eingabefeld anzeigen
            labelCenter.Visible = true;                                     // Textausgabefeld anzeigen

            UpdateNumberDisplay(null, null);                                // Erste Zahl direkt anzeigen
            UpdateKeyword();                                                // Erstes Schlüsselwort anzeigen
            Timer.Start();                                                  // Timer starten
        }

        private void UpdateNumberDisplay(object sender, EventArgs e)
        {
            AcceptNumberInput = true;                                       // Das drücken der F1 Taste ist wieder erlaubt

            if (CurrentLabel >= 0)
            {
                NumberLabels[CurrentLabel].Visible = false;                 // Die letzte Nummer ausblenden
            }

            if (++CurrentLabel >= NumberLabels.Count)                       // Zähler hochzählen und prüfen ob außerhalb des Gültigen Bereichs
            {
                CurrentLabel = 0;                                           // Zähler zurücksetzen
            }

            var numberToDisplay = Random.Next(0, 10);                       // Zufällige Zahl zwischen 0 und 9 generieren

            NumberLabels[CurrentLabel].Text = numberToDisplay.ToString();   // Zahl im neuen Nummernfeld einblenden
            NumberLabels[CurrentLabel].Visible = true;                      // Aktuelles Nummernfehld einblenden

            if (!IsOddNumber(numberToDisplay))
            {
                NumberStack.Clear();                                        // Bei einer geraden Zahl wird der Zwischenspeicher geleert
            }
            else
            {
                NumberStack.Add(numberToDisplay);                           // Generierte Nummer im Zwischenspeicher hinterlegen
            }

            if (NumberStack.Count > 3)
            {
                AcceptNumberInput = false;                                  // Das prüfen der F1 Taste bis zur nächsten Zahl unterbinden
                UserNumberResponseHistory.Add(false);                       // Der Benutzer hat nicht rechtzeitig F1 gedrückt, das wird als Fehleingabe gewertet
                NumberStack.Clear();                                        // Zwischenspeicher leeren nach der falscheingabe
            }
        }

        private bool IsOddNumber(int number)
        {
            return number % 2f != 0;
        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            if (!AcceptNumberInput)
            {
                return;                                                     // Die Eingabe ignorieren
            }

            AcceptNumberInput = false;                                      // Auswertung bis zum nächsten Interval unterbrechen

            if (NumberStack.Count != 3)
            {
                UserNumberResponseHistory.Add(false);                       // Zwischenspeicher hat nicht genug Zahlen zum Prüfen, zählt als Fehleingabe
            } else
            {
                UserNumberResponseHistory.Add(NumberStack.All(number => IsOddNumber(number)));  // Prüfen ob die letzten drei Zahlen alle ungerade sind
            }

            NumberStack.Clear();                                            // Zwischenspeicher zurücksetzen
        }

        private void UpdateKeyword()
        {
            var keyWord = Keywords[Random.Next(0, Keywords.Count)];

            labelCenter.Text = keyWord;
            textInput.Text = string.Empty;
        }

        private void textInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserInputs.Add(new KeyValuePair<string, string>(labelCenter.Text, textInput.Text)); // Speichern des Schlüsselwortes und der Benutzereingabe

                if (UserInputs.Count >= 20)
                {
                    Timer.Stop();                                           // Programm wird nach 20 Eingaben beendet
                }
                else
                {
                    UpdateKeyword();                                        // Nächstes Schlüsselwort anzeigen
                }
            }
        }
    }
}
