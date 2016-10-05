namespace security_lab1_csharp.View.Improvement.ImproverPanels
{
    public class KeyImproverPanelFactory
    {
        public static KeyImproverPanel[] getPanels()
        {
            return new KeyImproverPanel[] { new KeyImproverPanelAStar(), new KeyImproverPanelAnnealing(), new KeyImproverPanelGenetics() };
        }
    }
}