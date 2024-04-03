namespace BMIDemo
{
    public partial class MainPage : ContentPage
    {
        const double UnderweightThreshold = 18.5;
        const double NormalweightThreshold = 24.9;
        const double OverweightThreshold = 29.9;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var weight = double.Parse(Weight.Text);
            var height = double.Parse(Height.Text) / 100;

            var imc = weight / (height * height);
            BMI.Text = imc.ToString("F2");

            string result = GetBmiResultMessage(imc);
            DisplayAlert("Result", result, "OK");
        }
        private string GetBmiResultMessage(double imc)
        {
            if (imc < UnderweightThreshold)
                return "You are underweight!";
            else if (imc <= NormalweightThreshold)
                return "Your weight is normal!";
            else if (imc <= OverweightThreshold)
                return "You are overweight!";
            else return "You are obese! Please take action!";
    }
    }
}
