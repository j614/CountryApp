using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RESTCountries.Models;
using RESTCountries.Services;
using System.Data.Entity;



namespace CountryApp
{
    public partial class CountryAppForm : Form
    {
    
        void FindCountryComboBox_AddItem()
        {
            List<string> CountryList = new List<string>();
            string writePath = @"CountryList.txt";
            try
            {
                using (StreamReader sr = new StreamReader(writePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        CountryList.Add(line);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            FindCountryComboBox.DataSource = File.ReadAllLines(writePath);
        }

        public CountryAppForm()
        {
            InitializeComponent();
            FindCountryComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            FindCountryComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            FindCountryComboBox_AddItem();

        }
        void LoadDB()
        {
            try
            {
                List<string[]> data = new List<string[]>();
                using (var context = new CountryDBContext())
                {
                    foreach (CountryDb countries in context.countries.Include(c => c.city).Include(r => r.region))
                        data.Add(new string[] { countries.name, countries.code, countries?.city.name, countries.area.ToString(), countries.population.ToString(), countries?.region.name });
                }

                foreach (string[] s in data)
                    this.dataGridView.Rows.Add(s);
            }
            catch
            {
                MessageBox.Show("Ошибка в загрузке данных");
            }


        }
        void WriteinDB(Country rc)
        {
            try
            {
                using (var context = new CountryDBContext())
                {
                    var addcity = new City();
                    City FindCity = context.cities.FirstOrDefault(c => c.name == rc.Capital);
                    if (FindCity == null)
                    {
                        Console.WriteLine("нет такого города");
                        Console.ReadLine();
                        addcity.name = rc.Capital;
                        context.cities.Add(addcity);
                    }
                    else
                    {
                        Console.WriteLine("есть город");
                        addcity.id = FindCity.id;
                    }
                    context.SaveChanges();




                    var addregion = new Region();
                    Region FindRegion = context.regions.FirstOrDefault(r => r.name == rc.Region);
                    if (FindRegion == null)
                    {
                        Console.WriteLine("нет такого региона");
                        Console.ReadLine();
                        addregion.name = rc.Region;
                        context.regions.Add(addregion);
                    }
                    else
                    {
                        Console.WriteLine("есть регион");
                        addregion.id = FindRegion.id;
                    }
                    context.SaveChanges();


                    var usercountry = new CountryDb();
                    CountryDb CheckCountry = context.countries.FirstOrDefault(c => c.code == rc.Alpha2Code);
                    if (CheckCountry == null)
                    {
                        usercountry.name = rc.Name;
                        usercountry.code = rc.Alpha2Code;
                        usercountry.area = (float)rc.Area;
                        usercountry.population = rc.Population;
                        usercountry.cityId = addcity.id;
                        usercountry.regionId = addregion.id;
                        context.countries.Add(usercountry);
                    }
                    else
                    {
                        usercountry.id = CheckCountry.id;
                        usercountry.name = rc.Name;
                        usercountry.code = rc.Alpha2Code;
                        usercountry.area = (float)rc.Area;
                        usercountry.population = rc.Population;
                        usercountry.cityId = addcity.id;
                        usercountry.regionId = addregion.id;
                    }
                    context.SaveChanges();
                    this.dataGridView.Rows.Clear();
                    MessageBox.Show("Сохранение прошло успешно");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }
        }
        
        async void requestRest(string userNameCountry)
        {

                Country restCountry = await RESTCountriesAPI.GetCountryByFullNameAsync(userNameCountry);
                CountryTextBox.Text = ($"Название: {restCountry.Name}\n" +
                                    $"Код: {restCountry.Alpha2Code}\n" +
                                    $"Площадь: {restCountry.Area}\n" +
                                    $"Население: {restCountry.Population}\n" +
                                    $"Столица: {restCountry.Capital}\n" +
                                    $"Регион: {restCountry.Region}");
                DialogResult result = MessageBox.Show(
                    "Сохранить страну в базу?",
                    "Сохранение",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Information,
                     MessageBoxDefaultButton.Button1,
                     MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    WriteinDB(restCountry);
                }

        }
        private void FindCountryButton_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                requestRest(FindCountryComboBox.SelectedItem.ToString());
            }
            catch
            {
                MessageBox.Show("Нет такой страны");
            }
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            LoadDB();
        }

    }
}
