using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            AddRustlersRibsButton.Click += OnAddRustlersRibsButtonClicked;
            AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkButtonClicked;
            AddTrailBurgerButton.Click += OnAddTrailBurgerButtonClicked;
            AddDakotaDoubleButton.Click += OnAddDakotaDoubleButtonClicked;
            AddTexasTripleButton.Click += OnAddTexasTripleButtonClicked;
            AddAngryChickenButton.Click += OnAddAngryChickenButtonClicked;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClicked;
            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClicked;
            AddCornDodgersButton.Click += OnAddCornDodgersButtonClicked;
            AddPanDeCampoButton.Click += OnAddPanDeCampoButtonClicked;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClicked;
            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClicked;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClicked;
            AddWaterButton.Click += OnAddWaterButtonClicked;
        }

        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e) 
        {
            OrderListView.Items.Add(new CowpokeChili());
        }

        void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs());
        }

        void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PecosPulledPork());
        }

        void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TrailBurger());
        }

        void OnAddDakotaDoubleButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new DakotaDoubleBurger());
        }

        void OnAddTexasTripleButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTripleBurger());
        }

        void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new AngryChicken());
        }

        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new BakedBeans());
        }

        void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }

        void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CornDodgers());
        }

        void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PanDeCampo());
        }

        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowboyCoffee());
        }

        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new JerkedSoda());
        }

        void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTea());
        }

        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new Water());
        }
    }
}
