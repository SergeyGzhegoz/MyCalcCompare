namespace MyCalcCompare;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void OnButtonClick(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        float a = float.Parse(EntryA.Text);
        float b = float.Parse(EntryB.Text);
        float c = 0;
        string result = "";

        switch (btn.Text)
        {
            case "+":
                c = a + b;
                break;
            case "-":
                c = a - b;
                break;
            case "*":
                c = a * b;
                break;
            case "/":
                if (b != 0)
                    c = a / b;                    
                else
                    result = "Деление на 0";
                break;
        }
        if (string.IsNullOrEmpty(result))
        {
            result = c.ToString();
        }
        LabelResult.Text = result;
    }
}

