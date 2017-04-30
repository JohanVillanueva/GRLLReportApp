using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GRLLReportApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            string html = "https://app.powerbi.com/view?r=eyJrIjoiZGQzNzk5YjUtNjc4NS00NDQyLWFiOTEtNmZkZDA0Nzk5MzhkIiwidCI6IjY1MTgxYWE4LTI5NTgtNDE2ZC05MWEwLTEwODAzMzE4NWUxZiIsImMiOjR9&dynamicDisplayOption=true";
            Browser.Source = html;
        }
    }
}
