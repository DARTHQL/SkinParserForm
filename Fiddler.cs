using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkinParserForm {
    static class Fiddler {
        [DllImport("user32.dll")]
        private static extern int SetWindowText(IntPtr hWnd, string text);

        private static readonly string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private static readonly string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        private static readonly string path = $@"{localAppData}\Programs\Fiddler\Fiddler.exe";
        private static readonly string customRulesPath = $@"{documents}\Fiddler2\Scripts\CustomRules.js";

        static Fiddler() {
            if (!File.Exists(path)) {
                throw new FileNotFoundException(path);
            }

            if (!File.Exists(customRulesPath)) {
                throw new FileNotFoundException(customRulesPath);
            }
        }

        public static void Disguise() {
            Process p = Process.Start(path);

            while (p.MainWindowHandle == IntPtr.Zero) {
                Application.DoEvents();
            }

            SetWindowText(p.MainWindowHandle, "Spaghetti");
        }

        public static void EditRules() {
            using (FileStream fs = File.Open(customRulesPath, FileMode.Open)) {
                fs.Close();
            }
        }
    }
}
