using AppDev1.Objects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDev1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DescriptionPage : ContentPage
    {
        public ObservableCollection<Project> Items { get; set; }
        public DescriptionPage(Project project)
        {
            InitializeComponent();
            Title = project.Title;
            Items = new ObservableCollection<Project>();
            Items.Add(project);
            MyListView.ItemsSource = Items;
        }
    }
}