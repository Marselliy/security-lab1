namespace security_lab1_csharp.View.Search
{
    public class KeySearchPanelFactory
    {
        public static KeySearchPanel[] getPanels()
        {
            return new KeySearchPanel[] { new KeySearchPanelMono(), new KeySearchPanelVigenere(), new KeySearchPanelPoly() };
        }
    }
}