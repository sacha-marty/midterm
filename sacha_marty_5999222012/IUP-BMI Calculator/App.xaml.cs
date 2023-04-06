using IUP_BMI_Calculator.Repository;

namespace IUP_BMI_Calculator;

public partial class App : Application
{
    //TODO
    public App(string DbPath)
	{
		InitializeComponent();

		MainPage = new AppShell();


        BMIResultRepository BMIresrepo = new BMIResultRepository(DbPath);

}
}
