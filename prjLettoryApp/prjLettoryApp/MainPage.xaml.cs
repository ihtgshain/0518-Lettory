using prjLettoryApp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace prjLettoryApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        List<Label> listLb = new List<Label>();
        Lottery loNums;
        public void DrawLottery(object sender, EventArgs e)
        {
            loNums =new Lottery();
            ShowNums();
        }

        public void Sort(object sender, EventArgs e)
        {
            if (listLb.Count == 0) return;

            loNums.BubbleSort();
            ShowNums();
        }

        private void ShowNums()
        {
            listLb.Clear();
            stackLettory.Children.Clear();
            labInfo.Text = loNums.isSorted? "(Sorted)" : "(original order)";
            labInfo.TextColor = Color.Black;
            for (int i = 0; i < loNums.len; i++)
            {
                listLb.Add(new Label());
                listLb[i].Text = loNums[i];
                listLb[i].FontSize = 20;
                stackLettory.Children.Add(listLb[i]);
            }
        }

    }

  
}
