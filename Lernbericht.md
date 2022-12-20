# Lern-Bericht
Peanut: Koch,Meyer,Gilardoni,Grigioni,Erismann

## Einleitung

In diesem Projekt haben wir ein Programm programmiert in Winforms, mit dem man Black Jack spielen kann.

## Was habe ich gelernt?

 Wir haben gelernt wie man ein Bild in Winforms, mit einem Knopfdruck wechselt.

## Beschreibung

✍️ Verwenden Sie drei verschiedene Medien, um zu zeigen, was Sie gelernt haben. Zum Beispiel:

* Eine textliche Beschreibung
* Ein deutliches, aussagekräftiges Bild oder eine kommentierte Bildschirm-Aufnahme
* Ein gut dokumentierter Code-Fetzen
* Ein Link zu einem *selbst aufgenommenen* youtube-Video oder `.gif`.

## Verifikation
Text: Beschreibung wie unser Code funktioniert.
Surcecode: Der Beispiels Code zeigt wie man so etwas programmiert.
´´´ using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamPenutExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(@"C:\Users\nicla\source\repos\TeamPenutExample\Pic1.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(@"C:\Users\nicla\source\repos\TeamPenutExample\Pic2.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(@"C:\Users\nicla\source\repos\TeamPenutExample\Pic3.gif");
        }
    }
}
´´´
GIF: Das GiF zeigt wie der Code funktioniert.

![Gif2](https://user-images.githubusercontent.com/79938743/208619842-db16314b-020c-4514-9cf0-635f2af4e447.gif)
![Unbenannt](https://user-images.githubusercontent.com/79938743/208619919-4b060429-8480-4d05-8f25-aca3a46fdab4.png)

# Reflektion zum Arbeitsprozess

👍 Wir waren schnell mit Winforms vertraut.

👍 Wir hatten gute Arbeitsphasen.

👍 Gute Kommunikation im Team.

👎 Wir haben Parameter in Winforms nicht verstanden und haben sie so nicht verwendet.

👎 Wir haben eine zu aufwendige Funktion einbauen wollen und haben so viel Zeit verbraucht und es nicht geschaft.


**VBV**: 
