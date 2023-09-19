namespace PagesDemo;

public partial class TabbedPageDemo : TabbedPage
{
	public TabbedPageDemo()
	{
		InitializeComponent();
	}
    
    private void nwd(object sender, EventArgs e)
    {
        if (int.TryParse(a.Text, out int la) &&
            int.TryParse(b.Text, out int lb))
        {
            while (la != lb)
            {
                if (la > lb)
                {
                    la -= lb; 
                }
                else
                {
                    lb -= la; 
                }
            }
            resultLabel.Text = $"NWD: {la}";
        }
        else
        {
            resultLabel.Text = "B≥πd: Wprowadü poprawne liczby.";
        }

    }
    
}