using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PonydayManager
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = GetCite();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            this.textBoxDescription.Text = GetCite();            
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        #endregion

        private string[] _cites = new string[] {
            "Zwei Dinge sind zu unserer Arbeit nötig: Unermüdliche Ausdauer und die Bereitschaft, etwas, in das man viel Zeit und Arbeit gesteckt hat, wieder wegzuwerfen. (Albert Einstein)",
            "Mein Großvater sagte mir einst, dass es zwei Sorten von Menschen gäbe. Die, die arbeiten und die, die sich die Lorbeeren für diese Arbeit einheimsen. Er sagte mir, ich solle versuchen in der ersten Gruppe zu sein; es gäbe dort viel weniger Konkurrenz. (Indira Gandhi)",
            "Nichtstun macht nur dann Spaß, wenn man eigentlich viel zu tun hätte. (Noël Coward)",
            "Weil Denken die schwerste Arbeit ist, die es gibt, beschäftigen sich auch nur wenige damit. (Henry Ford)",
            "Arbeite klug, nicht hart. (Dr. Gregory House)",
            "Teamarbeit ist, wenn vier Leute für eine Arbeit bezahlt werden, die drei besser machen könnten, wenn sie nur zu zweit gewesen wären und einer davon krank zu Bett läge. (Martin Wolgast)",
            "Ein Faulpelz ist ein Mensch, der sich keine Arbeit damit macht, sein Nichtstun zu begründen. (Gabriel Laub)",
            "Kein Mensch ist so beschäftigt, dass er nicht die Zeit hat, überall zu erzählen, wie beschäftigt er ist. (Robert Lembke)",
            "Müde macht uns die Arbeit, die wir liegenlassen, nicht die, die wir tun. (Marie von Ebner-Eschenbach)",
            "Heute studiert jeder zweite an der Uni sein späteres Hobby für die Arbeitslosigkeit. (Elmar Kupke)",
            "Es gibt drei Sorten von Menschen: solche, die sich zu Tode sorgen; solche, die sich zu Tode arbeiten; und solche, die sich zu Tode langweilen. (Winston Churchill)",
            "Donner ist gut und eindrucksvoll, aber die Arbeit leistet der Blitz. (Mark Darwin)",
            "Holzhacken ist deshalb so beliebt, weil man bei dieser Tätigkeit den Erfolg sofort sieht. (Albert Einstein)",
            "Faulheit ist die Furcht vor bevorstehender Arbeit. (Marcus Tullius Cicero)",
            "Es ist gefährlich, einen extrem fleißigen Bürokollegen einzustellen, weil die anderen Mitarbeiter ihm dann dauernd zuschauen. (Henry Ford)",
            "Manche Arbeiten muss man Dutzende Male verschieben, bevor man sie endgültig vergisst. (Anonym)",
            "Die Asiaten haben den Weltmarkt mit unlauteren Methoden erobert – sie arbeiten während der Arbeitszeit. (Ephraim Kishon)",
            "Gegenüber der Fähigkeit, die Arbeit eines einzigen Tages sinnvoll zu ordnen, ist alles andere im Leben ein Kinderspiel. (Johann Wolfgang von Goethe)",
            "Tue nie etwas halb, sonst verlierst du mehr, als du je wieder einholen kannst. (Louis Armstrong)",
            "Persönlichkeiten werden nicht durch schöne Reden geformt, sondern durch Arbeit und eigene Leistung. (Albert Einstein)",
            "Die Nichtzusammenarbeit mit dem Schlechten gehört ebenso zu unseren Pflichten wie die Zusammenarbeit mit dem Guten. (Mahatma Gandhi)",
            "An nichts gewöhnt man sich so schnell wie an das langsame Arbeiten. (Ernst R. Hauschka)",
            "Nicht, was ich habe, sondern was ich schaffe, ist mein Reich. (Thomas Carlyle)",
            "Für Wunder muss man beten, für Veränderungen aber arbeiten. (Thomas von Aquin)",
            "Es gibt zwei Möglichkeiten, Karriere zu machen: Entweder leistet man wirklich etwas, oder man behauptet, etwas zu leisten. Ich rate zur ersten Methode, denn hier ist die Konkurrenz bei weitem nicht so groß. (Danny Kaye)",
            "Freude an der Arbeit lässt das Werk trefflich geraten. (Aristoteles)",
            "Die Arbeit ist etwas Unnatürliches. Die Faulheit allein ist göttlich. (Anatole France)",
            "Angenehm sind die erledigten Arbeiten. (Cicero)",
            "Erkenne, wo du stehst, wo du hinwillst. Mach deinen Plan. Und dann geh! (Ken Cardigan)",
            "Der eine hat Arbeit und Fleiß, der andere Nutzen und Preis. (unbekannt)",
            "Die Arbeit läuft dir nicht davon, wenn du deinem Kind den Regenbogen zeigst. Aber der Regenbogen wartet nicht, bis du mit der Arbeit fertig bist. (Chinesisches Sprichwort)",
            "Bei jeder Arbeit ist es vor allem wichtig, dass man zuerst einmal einfach irgendwie anfängt. Dann kommt die Sache in Fluß. (Carl Hilty)",
            "Man sollte nie so viel zu tun haben, dass man zum Nachdenken keine Zeit mehr hat. (Georg Christoph Lichtenberg)",
            "Wer den ganzen Tag arbeitet, hat keine Zeit, Geld zu verdienen. (John D. Rockefeller)",
            "Das Talent arbeitet, das Genie schafft. (Robert Schumann)",
            "Strebe nach Ruhe, aber durch das Gleichgewicht, nicht durch den Stillstand deiner Tätigkeit. (Friedrich von Schiller)",
            "Die Arbeit hält drei schlimme Übel von uns fern: Langeweile, Laster und Not (Voltaire)", 
            "Arbeit ist mehr als bloßer Broterwerb. Sie bedeutet auch Selbstverwirklichung. (Norbert Blüm)",
            "Wer sich zu wichtig für kleine Arbeiten hält, ist oft zu klein für wichtige Arbeiten. (Jaques Tati)",
            "Arbeiten, um nicht denken zu müssen, ist auch Faulheit. (Erhard Blanck)",
            "Um die tatsächliche Arbeit des Denkens zu vermeiden, beschreitet der Mensch jeden möglichen Ausweg. (Thomas Alva Edison)",
            "Wissenschaft hat etwas Faszinierendes an sich. So eine geringfügige Investition an Fakten liefert so einen reichen Ertrag an Voraussagen. (Mark Twain)",
            "Wird das Geschaute und Erlebte in der Sprache der Logik nachgebildet, so treiben wir Wissenschaft, wird es durch Formen vermittelt, so treiben wir Kunst. (Albert Einstein)",
            "Bildung ist die Fähigkeit, fast alles anhören zu können, ohne die Ruhe zu verlieren oder das Selbstvertrauen. (Robert Lee Frost)",
            "Eine Erkenntnis von heute kann die Tochter eines Irrtums von gestern sein. (Marie von Ebner-Eschenbach)",
            "Die Summe unserer Erkenntnis besteht aus dem, was wir gelernt, und aus dem, was wir vergessen haben. (Marie von Ebner-Eschenbach)",
            "Nicht in der Erkenntnis liegt das Glück, sondern im Erwerben der Erkenntnis. (Edgar Allan Poe)",
            "Es gibt mehr Leute, die kapitulieren, als solche, die scheitern. (Henry Ford)",
            "Erfolg ist so ziemlich das letzte, was einem vergeben wird. (Truman Capote)",
            "Unsere Fehlschläge sind oft erfolgreicher als unsere Erfolge. (Henry Ford)"
        };

        private string GetCite()
        {
            return _cites[new Random().Next(_cites.Length)];
        }
    }
}
