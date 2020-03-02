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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : OrderControl
    {
        List<string> items = new List<string>();

        public IEnumerable<string> Items => items.ToArray();

        public MenuItemSelectionControl()
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
            CowpokeChili Chili = new CowpokeChili();
            string chili = Chili.ToString();
            items.Add(chili);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            RustlersRibs Ribs = new RustlersRibs();
            string ribs = Ribs.ToString();
            items.Add(ribs);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            PecosPulledPork Pork = new PecosPulledPork();
            string pork = Pork.ToString();
            items.Add(pork);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            TrailBurger Burger = new TrailBurger();
            string burger = Burger.ToString();
            items.Add(burger);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        void OnAddDakotaDoubleButtonClicked(object sender, RoutedEventArgs e)
        {
            DakotaDoubleBurger Dakota = new DakotaDoubleBurger();
            string dakota = Dakota.ToString();
            items.Add(dakota);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        void OnAddTexasTripleButtonClicked(object sender, RoutedEventArgs e)
        {
            TexasTripleBurger Triple = new TexasTripleBurger();
            string triple = Triple.ToString();
            items.Add(triple);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            AngryChicken Chicken = new AngryChicken();
            string chicken = Chicken.ToString();
            items.Add(chicken);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            BakedBeans Beans = new BakedBeans();
            string beans = Beans.ToString();
            items.Add(beans);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            ChiliCheeseFries Fries = new ChiliCheeseFries();
            string fries = Fries.ToString();
            items.Add(fries);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            CornDodgers Corn = new CornDodgers();
            string corn = Corn.ToString();
            items.Add(corn);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            PanDeCampo Campo = new PanDeCampo();
            string campo = Campo.ToString();
            items.Add(campo);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            CowboyCoffee Coffee = new CowboyCoffee();
            string coffee = Coffee.ToString();
            items.Add(coffee);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            JerkedSoda Soda = new JerkedSoda();
            string soda = Soda.ToString();
            items.Add(soda);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            TexasTea Tea = new TexasTea();
            string tea = Tea.ToString();
            items.Add(tea);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            Water Water = new Water();
            string water = Water.ToString();
            items.Add(water);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
