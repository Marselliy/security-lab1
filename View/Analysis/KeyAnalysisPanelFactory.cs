using System.Windows.Forms;

namespace security_lab1_csharp.View.Analysis
{
    public class KeyAnalysisPanelFactory
    {
        public static KeyAnalysisPanel[] getPanels()
        {
            return new KeyAnalysisPanel[] {new KeyAnalysisPanelGlobal(), new KeyAnalysisPanelVigenere(), new KeyAnalysisPanelPoly()};
        }
    }
}