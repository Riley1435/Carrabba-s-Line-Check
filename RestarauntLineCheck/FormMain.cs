using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestarauntLineCheck
{
   public partial class FormMain : Form
   {
      //
      // COMBO BOX VALUES
      //
      private string[] foodTables = { "PizzaFood", "AppFood", "SaladFood", "DessertFood", "GrillFood", "MakeupFood", "SauteeFood" };
      private string[] pizza = { "Sliced Roma Tomatoes", "Spiedino Breading", "Stuffed Mushrooms", "Basil Leaves Whole", "Calabrian Peppers",
      "Parsley Sprigs Stemmed", "Salt and Black Peppers", "E-P Oil", "Flour", "Pizza Dough", "Grated Romano", "Pepperoni", "Sundried Tomatoes",
      "Fresh Milk Mozzarella", "Sicilian Butter", "Sugo Rosa Sauce", "Pizza Sauce", "Pomodoro Sauce", "Crumbled Sausage", "Gorgonzola Sauce",
      "Shredded Mozzarella", "Mushrooms", "Prepped Wings", "Apple Crostata", "Sanitizer Bucket" };
      private string[] app = { "Chopped Basil", "Lemon Wedges", "Salt and Black Pepper", "Prepped Sketa Bread", "Chicken Fingers", "Zucchini",
      "Calamario", "Calamari Batter", "Milk", "Ketchup", "Ricotta Salata", "Roasted Garlic Aioli", "Pomodori Siciliani", "Mezzi Tubetti",
      "Minestrone Soup", "Chicken Soup", "Sausage and Lentil Soup", "Marinara", "Mozzarella Marinara", "Sanitizer Bucket"};
      private string[] desserts = { "Mint Spring Stemmed", "Powdered Sugar", "Cocoa Powerder", "Cannoli Shells", "Pistachios",
      "John Cole Nuts", "Salted Caramel", "Chocolate Shavings", "Chocolate Sauce", "Cannoli Filling", "Vanilla Ice Cream", "Strawberry Sauce",
      "Cheesecake", "Sogno", "Tiramisu"};
      private string[] salad = {"Roasted Red Pepper", "Chopped Basil", "Red Onions", "Sliced Carrots", "Red Cabbage", "Salt and Black Pepper",
      "Balsamic Glaze", "Pepperoncini", "Grated Romano", "Burrata", "Whipped Butter", "Romaine", "Salad Mix", "Kalamata Olives", "Shredded Parmesan",
      "Arugula", "Red/Yellow Grap Tom", "Croutons", "Gorgonzola Cheese", "Parmesan Dressing", "Caesar Dressing", "vinaitgrette Dressing",
      "Balsamic Vinaigrette", "Lemon Vinaigrette", "Sanitizer Bucket"};
      private string[] grill = { "Spiedino Breading", "P-S Line Oil", "Soybean Oil", "Salt and White Pepper", "Asparagus with Prosciutto",
      "Chicken 8 oz", "Prepped Rosa", "Pork Tenderloin 2.5 oz", "Filet 9 oz", "Sirloin 6 and 9 oz", "Ribeye 13 oz", "Pork Chop 8 oz", "Salmon 8 oz",
      "Tilapia 7-9 oz", "Scallops 13/15", "Shrimp 21/25", "Spiedinos", "Grill Baste", "Grill Seasoning", "Goat Cheese Slices", "Capers",
      "Dilusso Peppers Prep", "Lamb Chops", "Bourban Mint Glaze", "Zucchini and Peppers", "Prima Veg Kits", "Grilled Vegetables", "Roasted Tomatoes",
      "Sanitizer Bucket"};
      private string[] makeup = { "Grilled Lemons", "Chopped Basil", "Fettuccine", "Whole Grain Spag", "Cappellini", "Gluten Free Past", "Dill",
      "Balsamic Glaze", "Parsley", "Sliced Garlic", "E-P Oil", "Salt and Black Pepper", "Salt for Water", "Spinach", "Roasted Tomatoes", "Shaved Parmesan",
      "Asparagus", "Cetriolini", "Broccoli", "Sundried Tomatoes", "Grated Romano", "Spicy Sicilian Butter", "Alfredo Base", "Pomodoro Sauce", "Pic Pac Sauce",
      "Sauteed Mushrooms", "Linguini Fini", "Cavatappi/Penne", "Lemon Butter", "Mushroom Basil LB", "Marsala", "Mushroom Marsala", "Port Wine Fig Sauce",
      "Garlic Mash", "Gorgonzola Sauce", "Sanitizer Bucket"};
      private string[] sautee = { "Clarified Butter", "Lemon Halves", "Chopped Garlic", "Green Onions", "Chopped Basil", "Parsley", "Vodka",
      "Mamas Breading", "Panko Breading", "P-S Line Oil", "Salt and Black Pepper", "Lobster Ravioli", "Cheese Ravioli", "Mezzaluna Ravioli",
      "Shrimp 21/25", "Mussels", "Scallops 13/15", "Sausage Links, Raw", "Egg Wash", "Peas", "Chicken Parmesan", "Veal Pounded Thin", "Panko Chicken",
      "Anise Base", "Ricotta Cheese", "Grated Romano", "Linguini Fini", "Spaghetti", "Rigatoni", "Lasagne", "Meatballs", "Pomodoro Sauce (Hot)",
      "Lemon Butter", "Chicken Stock", "Mozzarella Sliced", "Goat Cheese Slices", "Alfredo Base", "Sugo Rosa", "Marinara", "Pomodoro Sauce",
      "Meat Sauce", "Lobster Cream Sauce", "Diced Roma Tomatoes", "Campagnolo", "Sauteed Mushrooms", "Sanitizer Bucket"};

      private string[] equipmentTables = { "PizzaMisc", "AppMisc", "SaladMisc", "GrillMisc", "MakeupMisc", "SauteeMisc" };
      private string[] pizzaMisc = { "Pizza Over 590° - 610°", "Pizza Cooler 40° or below", "Pizza Paddles: 10in circles", "Thermometer",
      "Cast Iron Skillet", "Ash Bucket with Lid", "Wood", "Pizza Brush"};
      private string[] appMisc = {"Fryers 350°", "App Oven 500°", "Steam Wells 150°", "App Coolers 40° or Below", "Thermometer", "Fryer Baskets",
      "Mesh Skimmer", "Oil Tester"};
      private string[] saladMisc = {"Salad Cooler - 40° or Below", "Salad Freezer - Visible Ice", "Freezer Fully Stocked - Plates", "Thermometer" };
      private string[] grillMisc = {"Grill 550°", "Grill Thermometer", "Wood, Water in Grates", "Cutting Board", "Cutting Glove", "Grill Brush", "Knife" };
      private string[] makeupMisc = {"Make Up Cooler 40°", "Steam Wells 150°", "Thermometer", "Clean Boiling Salted Water", "Hot Plates" };
      private string[]sauteeMisc = {"Steam Wells 150°", "Lasagne Drawer 150°", "Salamander", "Thermometer", "GF Turbo Pot", "GF Strainer", "Yellow Handle Spoon" };

      private string[] selectData = {"Equipment", "Ingredients" };
      private string[] xmlSprocs = { "AllFood", "AllMisc" };
      public FormMain()
      {
         InitializeComponent();
      }
      public FormMain(string user)
      {
         InitializeComponent();
         toolStripStatusMain.Text = user;

         comboBoxFoodTable.SelectedIndexChanged += comboBoxFoodTable_SelectedIndexChanged;
         comboBoxFoodTable.Items.AddRange(foodTables);

         comboBoxMiscTable.SelectedIndexChanged += comboBoxMiscTable_SelectedIndexChanged;
         comboBoxMiscTable.Items.AddRange(equipmentTables);

         comboBoxData.Items.AddRange(selectData);

         comboBoxXmlSprocs.Items.AddRange(xmlSprocs);

         labelWelcome.Text = "Welcome: " + user;
         DatabaseConnector dc = new DatabaseConnector();
            DateTime d = DateTime.Today;
            string date = d.ToString("d");
            if (dc.LineCheckExists(date))
            {
                labelDatabaseUpdate.Text = "";
                labelDatabaseUpdate.Text = $"Line check has been completed for today, {date}";
            }
         

      }
      private void FormMain_Load(object sender, EventArgs e)
      {
         DateTime date = DateTime.Today;
         labelDateHeader.Text = "";
         labelDateHeader.Text = date.ToString("D");
      }

      private void buttonExit_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void buttonExit_Click_1(object sender, EventArgs e)
      {
            DateTime d = DateTime.Today;
            string date = d.ToString("d");
            DatabaseConnector dc = new DatabaseConnector();
            Application.Exit();
      }

      private void buttonLineCheck_Click(object sender, EventArgs e)
      {
         DateTime d = DateTime.Today;
         string date = d.ToString("d");
         DatabaseConnector dc = new DatabaseConnector();
         if (!(dc.LineCheckExists(date)))
         {
            MessageBox.Show($"New line check is being created for {date}");
            tabControlMain.SelectedIndex = 1;
         }
         else
         {
            MessageBox.Show($"Line check has been created for {date}.");
         }
      }
   
      //
      //
      // NAVIGATION BETWEEN FORMS
      //
      //
      //
      private void buttonAddPizza_Click(object sender, EventArgs e)
      {
         tabControlMain.SelectedIndex = 2;
         
      }
      private void buttonPrevApp_Click(object sender, EventArgs e)
      {
         tabControlMain.SelectedIndex = 1;
      }

      private void buttonNextApp_Click(object sender, EventArgs e)
      {
         tabControlMain.SelectedIndex = 3;
      }

      private void buttonPrevDesserts_Click(object sender, EventArgs e)
      {
         tabControlMain.SelectedIndex = 2;
      }

      private void buttonNextDesserts_Click(object sender, EventArgs e)
      {
         tabControlMain.SelectedIndex = 4;
      }

      private void buttonPrevSalad_Click(object sender, EventArgs e)
      {
         tabControlMain.SelectedIndex = 3;
      }

      private void buttonNextSalad_Click(object sender, EventArgs e)
      {
         tabControlMain.SelectedIndex = 5;
      }

      private void buttonPrevGrill_Click(object sender, EventArgs e)
      {
         tabControlMain.SelectedIndex = 4;
      }

      private void buttonNextGrill_Click(object sender, EventArgs e)
      {
         tabControlMain.SelectedIndex = 6;
      }

      private void buttonPrevMakeUp_Click(object sender, EventArgs e)
      {
         tabControlMain.SelectedIndex = 5;
      }

      private void buttonNextMakeUp_Click(object sender, EventArgs e)
      {
         tabControlMain.SelectedIndex = 7;
      }

      private void buttonPrevSautee_Click(object sender, EventArgs e)
      {
         tabControlMain.SelectedIndex = 6;
      }

      private void buttonFinishSautee_Click(object sender, EventArgs e)
      {
         Label[] labelPizza = {labelPizza1, labelPizza2, labelPizza3, labelPizza4, labelPizza5, labelPizza6,
         labelPizza7, labelPizza8, labelPizza9, labelPizza10, labelPizza11, labelPizza12, labelPizza13, labelPizza14, labelPizza15, labelPizza16,
         labelPizza17, labelPizza18, labelPizza19, labelPizza20, labelPizza21, labelPizza22, labelPizza23, labelPizza24, labelPizza25};
         CheckBox[] cbAppearance = {cbAppearance1, cbAppearance2, cbAppearance3, cbAppearance4, cbAppearance5, cbAppearance6,
         cbAppearance7, cbAppearance8, cbAppearance9, cbAppearance10, cbAppearance11, cbAppearance12, cbAppearance13,
         cbAppearance14, cbAppearance15, cbAppearance16, cbAppearance17, cbAppearance18, cbAppearance19, cbAppearance20,
         cbAppearance21, cbAppearance22, cbAppearance23,cbAppearance24, cbAppearance25};
         CheckBox[] cbTaste = {cbTaste1, cbTaste2, cbTaste3, cbTaste4, cbTaste5, cbTaste6,
         cbTaste7, cbTaste8, cbTaste9, cbTaste10, cbTaste11, cbTaste12, cbTaste13,
         cbTaste14, cbTaste15, cbTaste16, cbTaste17, cbTaste18, cbTaste19, cbTaste20,
         cbTaste21, cbTaste22, cbTaste23,cbTaste24, cbTaste25};
         CheckBox[] cbTemp = {cbTemp1, cbTemp2, cbTemp3, cbTemp4, cbTemp5, cbTemp6,
         cbTemp7, cbTemp8, cbTemp9, cbTemp10, cbTemp11, cbTemp12, cbTemp13,
         cbTemp14, cbTemp15, cbTemp16, cbTemp17, cbTemp18, cbTemp19, cbTemp20,
         cbTemp21, cbTemp22, cbTemp23,cbTemp24, cbTemp25};
         Label[] labelPizzaMisc = {labelPizzaMisc1, labelPizzaMisc2, labelPizzaMisc3, labelPizzaMisc4, labelPizzaMisc5, labelPizzaMisc6, labelPizzaMisc7,
         labelPizzaMisc8 };
         CheckBox[] cbMisc = {cbMisc1, cbMisc2, cbMisc3, cbMisc4, cbMisc5, cbMisc6,
         cbMisc7, cbMisc8 };

         Label[] labelApp = {labelApp1, labelApp2, labelApp3, labelApp4, labelApp5, labelApp6, labelApp7,
         labelApp8, labelApp9, labelApp10, labelApp11, labelApp12, labelApp13, labelApp14, labelApp15, labelApp16, labelApp17,
         labelApp18, labelApp19, labelApp20};
         CheckBox[] cbAppAppearance = {cbAppAppearance1, cbAppAppearance2, cbAppAppearance3, cbAppAppearance4, cbAppAppearance5, cbAppAppearance6,
         cbAppAppearance7, cbAppAppearance8, cbAppAppearance9, cbAppAppearance10, cbAppAppearance11, cbAppAppearance12, cbAppAppearance13,
         cbAppAppearance14, cbAppAppearance15, cbAppAppearance16, cbAppAppearance17, cbAppAppearance18, cbAppAppearance19, cbAppAppearance20 };
         CheckBox[] cbAppTaste = {cbAppTaste1, cbAppTaste2, cbAppTaste3, cbAppTaste4, cbAppTaste5, cbAppTaste6,
         cbAppTaste7, cbAppTaste8, cbAppTaste9, cbAppTaste10, cbAppTaste11, cbAppTaste12, cbAppTaste13,
         cbAppTaste14, cbAppTaste15, cbAppTaste16, cbAppTaste17, cbAppTaste18, cbAppTaste19, cbAppTaste20 };
         CheckBox[] cbAppTemp = {cbAppTemp1, cbAppTemp2, cbAppTemp3, cbAppTemp4, cbAppTemp5, cbAppTemp6,
         cbAppTemp7, cbAppTemp8, cbAppTemp9, cbAppTemp10, cbAppTemp11, cbAppTemp12, cbAppTemp13,
         cbAppTemp14, cbAppTemp15, cbAppTemp16, cbAppTemp17, cbAppTemp18, cbAppTemp19, cbAppTemp20 };
         Label[] labelAppMisc = {labelAppMisc1, labelAppMisc2, labelAppMisc3, labelAppMisc4, labelAppMisc5, labelAppMisc6, labelAppMisc7,
         labelAppMisc8 };
         CheckBox[] cbAppMisc = {cbAppMisc1, cbAppMisc2, cbAppMisc3, cbAppMisc4, cbAppMisc5, cbAppMisc6,
         cbAppMisc7, cbAppMisc8 };

         Label[] labelDesserts = {labelDesserts1, labelDesserts2, labelDesserts3, labelDesserts4, labelDesserts5, labelDesserts6, labelDesserts7,
         labelDesserts8, labelDesserts9, labelDesserts10, labelDesserts11, labelDesserts12, labelDesserts13, labelDesserts14, labelDesserts15 };
         CheckBox[] cbDessertsAppearance = {cbDessertsAppearance1, cbDessertsAppearance2, cbDessertsAppearance3, cbDessertsAppearance4,
         cbDessertsAppearance5, cbDessertsAppearance6, cbDessertsAppearance7, cbDessertsAppearance8, cbDessertsAppearance9,
         cbDessertsAppearance10, cbDessertsAppearance11, cbDessertsAppearance12, cbDessertsAppearance13,
         cbDessertsAppearance14, cbDessertsAppearance15 };
         CheckBox[] cbDessertsTaste = {cbDessertsTaste1, cbDessertsTaste2, cbDessertsTaste3, cbDessertsTaste4, cbDessertsTaste5, cbDessertsTaste6,
         cbDessertsTaste7, cbDessertsTaste8, cbDessertsTaste9, cbDessertsTaste10, cbDessertsTaste11, cbDessertsTaste12, cbDessertsTaste13,
         cbDessertsTaste14, cbDessertsTaste15 };
         CheckBox[] cbDessertsTemp = {cbDessertsTemp1, cbDessertsTemp2, cbDessertsTemp3, cbDessertsTemp4, cbDessertsTemp5, cbDessertsTemp6,
         cbDessertsTemp7, cbDessertsTemp8, cbDessertsTemp9, cbDessertsTemp10, cbDessertsTemp11, cbDessertsTemp12, cbDessertsTemp13,
         cbDessertsTemp14, cbDessertsTemp15 };

         Label[] labelSalad = {labelSalad1, labelSalad2, labelSalad3, labelSalad4, labelSalad5, labelSalad6, labelSalad7,
         labelSalad8, labelSalad9, labelSalad10, labelSalad11, labelSalad12, labelSalad13, labelSalad14, labelSalad15,
         labelSalad16 , labelSalad17 , labelSalad18 , labelSalad19 , labelSalad20, labelSalad21, labelSalad22,
         labelSalad23, labelSalad24, labelSalad25, labelSalad26};
         CheckBox[] cbSaladAppearance = {cbSaladAppearance1, cbSaladAppearance2, cbSaladAppearance3, cbSaladAppearance4,
         cbSaladAppearance5, cbSaladAppearance6, cbSaladAppearance7, cbSaladAppearance8, cbSaladAppearance9,
         cbSaladAppearance10, cbSaladAppearance11, cbSaladAppearance12, cbSaladAppearance13,
         cbSaladAppearance14, cbSaladAppearance15, cbSaladAppearance16, cbSaladAppearance17, cbSaladAppearance18, cbSaladAppearance19,
         cbSaladAppearance20, cbSaladAppearance21, cbSaladAppearance22, cbSaladAppearance23, cbSaladAppearance24, cbSaladAppearance25, cbSaladAppearance26};
         CheckBox[] cbSaladTaste = {cbSaladTaste1, cbSaladTaste2, cbSaladTaste3, cbSaladTaste4, cbSaladTaste5, cbSaladTaste6,
         cbSaladTaste7, cbSaladTaste8, cbSaladTaste9, cbSaladTaste10, cbSaladTaste11, cbSaladTaste12, cbSaladTaste13,
         cbSaladTaste14, cbSaladTaste15, cbSaladTaste16, cbSaladTaste17, cbSaladTaste18, cbSaladTaste19, cbSaladTaste20,
         cbSaladTaste21, cbSaladTaste22, cbSaladTaste23, cbSaladTaste24, cbSaladTaste25, cbSaladTaste26, };
         CheckBox[] cbSaladTemp = {cbSaladTemp1, cbSaladTemp2, cbSaladTemp3, cbSaladTemp4, cbSaladTemp5, cbSaladTemp6,
         cbSaladTemp7, cbSaladTemp8, cbSaladTemp9, cbSaladTemp10, cbSaladTemp11, cbSaladTemp12, cbSaladTemp13,
         cbSaladTemp14, cbSaladTemp15, cbSaladTaste16, cbSaladTaste17, cbSaladTaste18, cbSaladTaste19,  cbSaladTemp20,
         cbSaladTemp21, cbSaladTemp22, cbSaladTemp23, cbSaladTemp24, cbSaladTemp25, cbSaladTemp26, };
         Label[] labelSaladMisc = { labelSaladMisc1, labelSaladMisc2, labelSaladMisc3, labelSaladMisc4 };
         CheckBox[] cbSaladMisc = { cbSaladMisc1, cbSaladMisc2, cbSaladMisc3, cbSaladMisc4 };

         Label[] labelGrill = {labelGrill1, labelGrill2, labelGrill3, labelGrill4, labelGrill5, labelGrill6, labelGrill7,
         labelGrill8, labelGrill9, labelGrill10, labelGrill11, labelGrill12, labelGrill13, labelGrill14, labelGrill15,
         labelGrill16 , labelGrill17 , labelGrill18 , labelGrill19 , labelGrill20, labelGrill21, labelGrill22,
         labelGrill23, labelGrill24, labelGrill5, labelGrill26, labelGrill27, labelGrill28, labelGrill29 };
         CheckBox[] cbGrillAppearance = {cbGrillAppearance1, cbGrillAppearance2, cbGrillAppearance3, cbGrillAppearance4,
         cbGrillAppearance5, cbGrillAppearance6, cbGrillAppearance7, cbGrillAppearance8, cbGrillAppearance9,
         cbGrillAppearance10, cbGrillAppearance11, cbGrillAppearance12, cbGrillAppearance13,
         cbGrillAppearance14, cbGrillAppearance15, cbGrillAppearance16, cbGrillAppearance17, cbGrillAppearance18, cbGrillAppearance19,
         cbGrillAppearance20, cbGrillAppearance21, cbGrillAppearance22, cbGrillAppearance23, cbGrillAppearance24, cbGrillAppearance25, cbGrillAppearance26,
         cbGrillAppearance27, cbGrillAppearance28, cbGrillAppearance29 };
         CheckBox[] cbGrillTaste = {cbGrillTaste1, cbGrillTaste2, cbGrillTaste3, cbGrillTaste4,
         cbGrillTaste5, cbGrillTaste6, cbGrillTaste7, cbGrillTaste8, cbGrillTaste9,
         cbGrillTaste10, cbGrillTaste11, cbGrillTaste12, cbGrillTaste13,
         cbGrillTaste14, cbGrillTaste15, cbGrillTaste16, cbGrillTaste17, cbGrillTaste18, cbGrillTaste19,
         cbGrillTaste20, cbGrillTaste21, cbGrillTaste22, cbGrillTaste23, cbGrillTaste24, cbGrillTaste25, cbGrillTaste26,
         cbGrillTaste27, cbGrillTaste28, cbGrillTaste29 };
         CheckBox[] cbGrillTemp = {cbGrillTemp1, cbGrillTemp2, cbGrillTemp3, cbGrillTemp4,
         cbGrillTemp5, cbGrillTemp6, cbGrillTemp7, cbGrillTemp8, cbGrillTemp9,
         cbGrillTemp10, cbGrillTemp11, cbGrillTemp12, cbGrillTemp13,
         cbGrillTemp14, cbGrillTemp15, cbGrillTemp16, cbGrillTemp17, cbGrillTemp18, cbGrillTemp19,
         cbGrillTemp20, cbGrillTemp21, cbGrillTemp22, cbGrillTemp23, cbGrillTemp24, cbGrillTemp25, cbGrillTemp26,
         cbGrillTemp27, cbGrillTemp28, cbGrillTemp29 };
         Label[] labelGrillMisc = { labelGrillMisc1, labelGrillMisc2, labelGrillMisc3, labelGrillMisc4, labelGrillMisc5, labelGrillMisc6, labelGrillMisc7 };
         CheckBox[] cbGrillMisc = {cbGrillMisc1, cbGrillMisc2, cbGrillMisc3, cbGrillMisc4,
         cbGrillMisc5, cbGrillMisc6, cbGrillMisc7 };

         Label[] labelMakeUp = {labelMakeUp1, labelMakeUp2, labelMakeUp3, labelMakeUp4, labelMakeUp5, labelMakeUp6, labelMakeUp7,
         labelMakeUp8, labelMakeUp9, labelMakeUp10, labelMakeUp11, labelMakeUp12, labelMakeUp13, labelMakeUp14, labelMakeUp15,
         labelMakeUp16 , labelMakeUp17 , labelMakeUp18 , labelMakeUp19 , labelMakeUp20, labelMakeUp21, labelMakeUp22,
         labelMakeUp23, labelMakeUp24, labelMakeUp5, labelMakeUp26, labelMakeUp27, labelMakeUp28, labelMakeUp29, labelMakeUp30, labelMakeUp31, labelMakeUp32, labelMakeUp33,
         labelMakeUp34, labelMakeUp35, labelMakeUp36 };
         CheckBox[] cbMakeUpAppearance = {cbMakeUpAppearance1, cbMakeUpAppearance2, cbMakeUpAppearance3, cbMakeUpAppearance4,
         cbMakeUpAppearance5, cbMakeUpAppearance6, cbMakeUpAppearance7, cbMakeUpAppearance8, cbMakeUpAppearance9,
         cbMakeUpAppearance10, cbMakeUpAppearance11, cbMakeUpAppearance12, cbMakeUpAppearance13,
         cbMakeUpAppearance14, cbMakeUpAppearance15, cbMakeUpAppearance16, cbMakeUpAppearance17, cbMakeUpAppearance18, cbMakeUpAppearance19,
         cbMakeUpAppearance20, cbMakeUpAppearance21, cbMakeUpAppearance22, cbMakeUpAppearance23, cbMakeUpAppearance24, cbMakeUpAppearance25, cbMakeUpAppearance26,
         cbMakeUpAppearance27, cbMakeUpAppearance28, cbMakeUpAppearance29, cbMakeUpAppearance30,
         cbMakeUpAppearance31, cbMakeUpAppearance32, cbMakeUpAppearance33, cbMakeUpAppearance34, cbMakeUpAppearance35,
         cbMakeUpAppearance36 };
         CheckBox[] cbMakeUpTaste = {cbMakeUpTaste1, cbMakeUpTaste2, cbMakeUpTaste3, cbMakeUpTaste4,
         cbMakeUpTaste5, cbMakeUpTaste6, cbMakeUpTaste7, cbMakeUpTaste8, cbMakeUpTaste9,
         cbMakeUpTaste10, cbMakeUpTaste11, cbMakeUpTaste12, cbMakeUpTaste13,
         cbMakeUpTaste14, cbMakeUpTaste15, cbMakeUpTaste16, cbMakeUpTaste17, cbMakeUpTaste18, cbMakeUpTaste19,
         cbMakeUpTaste20, cbMakeUpTaste21, cbMakeUpTaste22, cbMakeUpTaste23, cbMakeUpTaste24, cbMakeUpTaste25, cbMakeUpTaste26,
         cbMakeUpTaste27, cbMakeUpTaste28, cbMakeUpTaste29, cbMakeUpTaste30,
         cbMakeUpTaste31, cbMakeUpTaste32, cbMakeUpTaste33, cbMakeUpTaste34, cbMakeUpTaste35,
         cbMakeUpTaste36 };
         CheckBox[] cbMakeUpTemp = {cbMakeUpTemp1, cbMakeUpTemp2, cbMakeUpTemp3, cbMakeUpTemp4,
         cbMakeUpTemp5, cbMakeUpTemp6, cbMakeUpTemp7, cbMakeUpTemp8, cbMakeUpTemp9,
         cbMakeUpTemp10, cbMakeUpTemp11, cbMakeUpTemp12, cbMakeUpTemp13,
         cbMakeUpTemp14, cbMakeUpTemp15, cbMakeUpTemp16, cbMakeUpTemp17, cbMakeUpTemp18, cbMakeUpTemp19,
         cbMakeUpTemp20, cbMakeUpTemp21, cbMakeUpTemp22, cbMakeUpTemp23, cbMakeUpTemp24, cbMakeUpTemp25, cbMakeUpTemp26,
         cbMakeUpTemp27, cbMakeUpTemp28, cbMakeUpTemp29, cbMakeUpTemp30,
         cbMakeUpTemp31, cbMakeUpTemp32, cbMakeUpTemp33, cbMakeUpTemp34, cbMakeUpTemp35,
         cbMakeUpTemp36 };
         Label[] labelMakeUpMisc = { labelMakeUpMisc1, labelMakeUpMisc2, labelMakeUpMisc3, labelMakeUpMisc4, labelMakeUpMisc5 };
         CheckBox[] cbMakeUpMisc = {cbMakeUpMisc1, cbMakeUpMisc2, cbMakeUpMisc3, cbMakeUpMisc4,
         cbMakeUpMisc5 };

         Label[] labelSautee = {labelSautee1, labelSautee2, labelSautee3, labelSautee4, labelSautee5, labelSautee6, labelSautee7,
         labelSautee8, labelSautee9, labelSautee10, labelSautee11, labelSautee12, labelSautee13, labelSautee14, labelSautee15,
         labelSautee16 , labelSautee17 , labelSautee18 , labelSautee19 , labelSautee20, labelSautee21, labelSautee22,
         labelSautee23, labelSautee24, labelSautee5, labelSautee26, labelSautee27, labelSautee28, labelSautee29, labelSautee30, labelSautee31, labelSautee32, labelSautee33,
         labelSautee34, labelSautee35, labelSautee36, labelSautee37, labelSautee38, labelSautee39, labelSautee40, labelSautee41,
         labelSautee42 , labelSautee43 , labelSautee44 , labelSautee45 , labelSautee46};
         CheckBox[] cbSauteeAppearance = {cbSauteeAppearance1, cbSauteeAppearance2, cbSauteeAppearance3, cbSauteeAppearance4,
         cbSauteeAppearance5, cbSauteeAppearance6, cbSauteeAppearance7, cbSauteeAppearance8, cbSauteeAppearance9,
         cbSauteeAppearance10, cbSauteeAppearance11, cbSauteeAppearance12, cbSauteeAppearance13,
         cbSauteeAppearance14, cbSauteeAppearance15, cbSauteeAppearance16, cbSauteeAppearance17, cbSauteeAppearance18, cbSauteeAppearance19,
         cbSauteeAppearance20, cbSauteeAppearance21, cbSauteeAppearance22, cbSauteeAppearance23, cbSauteeAppearance24, cbSauteeAppearance25, cbSauteeAppearance26,
         cbSauteeAppearance27, cbSauteeAppearance28, cbSauteeAppearance29, cbSauteeAppearance30,
         cbSauteeAppearance31, cbSauteeAppearance32, cbSauteeAppearance33, cbSauteeAppearance34, cbSauteeAppearance35,
         cbSauteeAppearance36, cbSauteeAppearance37, cbSauteeAppearance38, cbSauteeAppearance39,
         cbSauteeAppearance40, cbSauteeAppearance41, cbSauteeAppearance42, cbSauteeAppearance43, cbSauteeAppearance44, cbSauteeAppearance45,
         cbSauteeAppearance46};
         CheckBox[] cbSauteeTaste = {cbSauteeTaste1, cbSauteeTaste2, cbSauteeTaste3, cbSauteeTaste4,
         cbSauteeTaste5, cbSauteeTaste6, cbSauteeTaste7, cbSauteeTaste8, cbSauteeTaste9,
         cbSauteeTaste10, cbSauteeTaste11, cbSauteeTaste12, cbSauteeTaste13,
         cbSauteeTaste14, cbSauteeTaste15, cbSauteeTaste16, cbSauteeTaste17, cbSauteeTaste18, cbSauteeTaste19,
         cbSauteeTaste20, cbSauteeTaste21, cbSauteeTaste22, cbSauteeTaste23, cbSauteeTaste24, cbSauteeTaste25, cbSauteeTaste26,
         cbSauteeTaste27, cbSauteeTaste28, cbSauteeTaste29, cbSauteeTaste30,
         cbSauteeTaste31, cbSauteeTaste32, cbSauteeTaste33, cbSauteeTaste34, cbSauteeTaste35,
         cbSauteeTaste36, cbSauteeTaste37, cbSauteeTaste38, cbSauteeTaste39,
         cbSauteeTaste40, cbSauteeTaste41, cbSauteeTaste42, cbSauteeTaste43, cbSauteeTaste44, cbSauteeTaste45, cbSauteeTaste46};
         CheckBox[] cbSauteeTemp = {cbSauteeTemp1, cbSauteeTemp2, cbSauteeTemp3, cbSauteeTemp4,
         cbSauteeTemp5, cbSauteeTemp6, cbSauteeTemp7, cbSauteeTemp8, cbSauteeTemp9,
         cbSauteeTemp10, cbSauteeTemp11, cbSauteeTemp12, cbSauteeTemp13,
         cbSauteeTemp14, cbSauteeTemp15, cbSauteeTemp16, cbSauteeTemp17, cbSauteeTemp18, cbSauteeTemp19,
         cbSauteeTemp20, cbSauteeTemp21, cbSauteeTemp22, cbSauteeTemp23, cbSauteeTemp24, cbSauteeTemp25, cbSauteeTemp26,
         cbSauteeTemp27, cbSauteeTemp28, cbSauteeTemp29, cbSauteeTemp30,
         cbSauteeTemp31, cbSauteeTemp32, cbSauteeTemp33, cbSauteeTemp34, cbSauteeTemp35,
         cbSauteeTemp36, cbSauteeTemp37, cbSauteeTemp38, cbSauteeTemp39,
         cbSauteeTemp40, cbSauteeTemp41, cbSauteeTemp42, cbSauteeTemp43, cbSauteeTemp44, cbSauteeTemp45, cbSauteeTemp46};
         Label[] labelSauteeMisc = { labelSauteeMisc1, labelSauteeMisc2, labelSauteeMisc3, labelSauteeMisc4, labelSauteeMisc5, labelSauteeMisc6, labelSauteeMisc7 };
         CheckBox[] cbSauteeMisc = {cbSauteeMisc1, cbSauteeMisc2, cbSauteeMisc3, cbSauteeMisc4,
         cbSauteeMisc5, cbSauteeMisc6, cbSauteeMisc7 };

         DateTime d = DateTime.Today;
         string date = d.ToString("d");

         //PIZZA
         for (int i = 0; i < 25; i++)
         {
            DatabaseConnector dc = new DatabaseConnector();
            if (!(cbAppearance[i].Checked))
               dc.Appearance = "O";
            if (!(cbTaste[i].Checked))
               dc.Taste = "O";
            if (!(cbTemp[i].Checked))
               dc.Temp = "O";
            dc.InsertLineCheck("[LineCheck].[uspNewLineCheckPizzaFood]", date, labelPizza[i].Text, toolStripStatusMain.Text);
         }
         for (int i = 0; i < 8; i++)
         {
            DatabaseConnector dc = new DatabaseConnector();
            if (!(cbMisc[i].Checked))
               dc.Present = "O";
            dc.InsertLineCheckMisc("[LineCheck].[uspNewLineCheckPizzaMisc]", date, labelPizzaMisc[i].Text, toolStripStatusMain.Text);
         }
         //APPS
         for (int i = 0; i < 20; i++)
         {
            DatabaseConnector dc = new DatabaseConnector();
            if (!(cbAppAppearance[i].Checked))
               dc.Appearance = "O";
            if (!(cbAppTaste[i].Checked))
               dc.Taste = "O";
            if (!(cbAppTemp[i].Checked))
               dc.Temp = "O";
            dc.InsertLineCheck("[LineCheck].[uspNewLineCheckAppFood]", date, labelApp[i].Text, toolStripStatusMain.Text);
         }
         for (int i = 0; i < 8; i++)
         {
            DatabaseConnector dc = new DatabaseConnector();
            if (!(cbAppMisc[i].Checked))
               dc.Present = "O";
            dc.InsertLineCheckMisc("[LineCheck].[uspNewLineCheckAppMisc]", date, labelAppMisc[i].Text, toolStripStatusMain.Text);
         }
         //DESSERTS
         for (int i = 0; i < 15; i++)
         {
            DatabaseConnector dc = new DatabaseConnector();
            if (!(cbDessertsAppearance[i].Checked))
               dc.Appearance = "O";
            if (!(cbDessertsTaste[i].Checked))
               dc.Taste = "O";
            if (!(cbDessertsTemp[i].Checked))
               dc.Temp = "O";
            dc.InsertLineCheck("[LineCheck].[uspNewLineCheckDessertFood]", date, labelDesserts[i].Text, toolStripStatusMain.Text);
         }
         //SALAD
         for (int i = 0; i < 26; i++)
         {
            DatabaseConnector dc = new DatabaseConnector();
            if (!(cbSaladAppearance[i].Checked))
               dc.Appearance = "O";
            if (!(cbSaladTaste[i].Checked))
               dc.Taste = "O";
            if (!(cbSaladTemp[i].Checked))
               dc.Temp = "O";
            dc.InsertLineCheck("[LineCheck].[uspNewLineCheckSaladFood]", date, labelSalad[i].Text, toolStripStatusMain.Text);
         }
         for (int i = 0; i < 4; i++)
         {
            DatabaseConnector dc = new DatabaseConnector();
            if (!(cbSaladMisc[i].Checked))
               dc.Present = "O";
            dc.InsertLineCheckMisc("[LineCheck].[uspNewLineCheckSaladMisc]", date, labelSaladMisc[i].Text, toolStripStatusMain.Text);
         }
         //GRILL
         for (int i = 0; i < 29; i++)
         {
            DatabaseConnector dc = new DatabaseConnector();
            if (!(cbGrillAppearance[i].Checked))
               dc.Appearance = "O";
            if (!(cbGrillTaste[i].Checked))
               dc.Taste = "O";
            if (!(cbGrillTemp[i].Checked))
               dc.Temp = "O";
            dc.InsertLineCheck("[LineCheck].[uspNewLineCheckGrillFood]", date, labelGrill[i].Text, toolStripStatusMain.Text);
         }
         for (int i = 0; i < 7; i++)
         {
            DatabaseConnector dc = new DatabaseConnector();
            if (!(cbGrillMisc[i].Checked))
               dc.Present = "O";
            dc.InsertLineCheckMisc("[LineCheck].[uspNewLineCheckGrillMisc]", date, labelGrillMisc[i].Text, toolStripStatusMain.Text);
         }
         //MAKEUP
         for (int i = 0; i < 36; i++)
         {
            DatabaseConnector dc = new DatabaseConnector();
            if (!(cbMakeUpAppearance[i].Checked))
               dc.Appearance = "O";
            if (!(cbMakeUpTaste[i].Checked))
               dc.Taste = "O";
            if (!(cbMakeUpTemp[i].Checked))
               dc.Temp = "O";
            dc.InsertLineCheck("[LineCheck].[uspNewLineCheckMakeupFood]", date, labelMakeUp[i].Text, toolStripStatusMain.Text);
         }
         for (int i = 0; i < 5; i++)
         {
            DatabaseConnector dc = new DatabaseConnector();
            if (!(cbMakeUpMisc[i].Checked))
               dc.Present = "O";
            dc.InsertLineCheckMisc("[LineCheck].[uspNewLineCheckMakeupMisc]", date, labelMakeUpMisc[i].Text, toolStripStatusMain.Text);
         }
         //SAUTEE
         for (int i = 0; i < 46; i++)
         {
            DatabaseConnector dc = new DatabaseConnector();
            if (!(cbSauteeAppearance[i].Checked))
               dc.Appearance = "O";
            if (!(cbSauteeTaste[i].Checked))
               dc.Taste = "O";
            if (!(cbSauteeTemp[i].Checked))
               dc.Temp = "O";
            dc.InsertLineCheck("[LineCheck].[uspNewLineCheckSauteeFood]", date, labelSautee[i].Text, toolStripStatusMain.Text);
         }
         for (int i = 0; i < 7; i++)
         {
            DatabaseConnector dc = new DatabaseConnector();
            if (!(cbSauteeMisc[i].Checked))
               dc.Present = "O";
            dc.InsertLineCheckMisc("[LineCheck].[uspNewLineCheckSauteeMisc]", date, labelSauteeMisc[i].Text, toolStripStatusMain.Text);
         }

         labelDatabaseUpdate.Text = $"Line check has been completed for today, {date}";
         tabControlMain.SelectedIndex = 0;
         MessageBox.Show($"Line Check recorded for {date}");
         
      }
      private void buttonExport_Click(object sender, EventArgs e)
      {
         tabControlMain.SelectedIndex = 10;
      }

      private void buttonUpdate_Click(object sender, EventArgs e)
      {
            DateTime d = DateTime.Today;
            string date = d.ToString("d");
            DatabaseConnector dc = new DatabaseConnector();
            if (!(dc.LineCheckExists(date)))
            {
                MessageBox.Show($"Line check has not been created for {date}.");
            }
            else
            {              
                tabControlMain.SelectedIndex = 8;
            }    
        }
      private void buttonData_Click(object sender, EventArgs e)
      {
         tabControlMain.SelectedIndex = 9;
      }
      

     //
     //  UPDATE FOOD RECORD
     //
      private void comboBoxFoodTable_SelectedIndexChanged(object sender, EventArgs e)
      {
         string selected = comboBoxFoodTable.SelectedItem as string;

         switch (selected)
         {
            case "PizzaFood":
               comboBoxFood.Enabled = true;
               comboBoxFood.Items.Clear();
               comboBoxFood.Items.AddRange(pizza);
               break;
            case "AppFood":
               comboBoxFood.Enabled = true;
               comboBoxFood.Items.Clear();
               comboBoxFood.Items.AddRange(app);
               break;
            case "SaladFood":
               comboBoxFood.Enabled = true;
               comboBoxFood.Items.Clear();
               comboBoxFood.Items.AddRange(salad);
               break;
            case "DessertFood":
               comboBoxFood.Enabled = true;
               comboBoxFood.Items.Clear();
               comboBoxFood.Items.AddRange(desserts);
               break;
            case "GrillFood":
               comboBoxFood.Enabled = true;
               comboBoxFood.Items.Clear();
               comboBoxFood.Items.AddRange(grill);
               break;
            case "MakeupFood":
               comboBoxFood.Enabled = true;
               comboBoxFood.Items.Clear();
               comboBoxFood.Items.AddRange(makeup);
               break;
            case "SauteeFood":
               comboBoxFood.Enabled = true;
               comboBoxFood.Items.Clear();
               comboBoxFood.Items.AddRange(sautee);
               break;
         }
      }
      private void buttonUpdateFood_Click(object sender, EventArgs e)
      {
         if (comboBoxFood.SelectedIndex > -1 && comboBoxFoodTable.SelectedIndex > -1)
         {
            DateTime d = DateTime.Today;
            string date = d.ToString("d");
            DatabaseConnector dc = new DatabaseConnector();
            if (!(cbUpdateAppearance.Checked))
               dc.Appearance = "O";
            if (!(cbUpdateTaste.Checked))
               dc.Taste = "O";
            if (!(cbUpdateTemp.Checked))
               dc.Temp = "O";
            dc.UpdateLineCheck(comboBoxFoodTable.Text, date, comboBoxFood.Text, toolStripStatusMain.Text);
         }
         else
         {
            MessageBox.Show("Please select a station and an ingredient.");
         }
      }

      //
      // UPDATE EQUIPMENT RECORD
      //
      private void comboBoxMiscTable_SelectedIndexChanged(object sender, EventArgs e)
      {
         string selected = comboBoxMiscTable.SelectedItem as string;

         switch (selected)
         {
            case "PizzaMisc":
               comboBoxMisc.Enabled = true;
               comboBoxMisc.Items.Clear();
               comboBoxMisc.Items.AddRange(pizzaMisc);
               break;
            case "AppMisc":
               comboBoxMisc.Enabled = true;
               comboBoxMisc.Items.Clear();
               comboBoxMisc.Items.AddRange(appMisc);
               break;
            case "SaladMisc":
               comboBoxMisc.Enabled = true;
               comboBoxMisc.Items.Clear();
               comboBoxMisc.Items.AddRange(saladMisc);
               break;
            case "GrillMisc":
               comboBoxMisc.Enabled = true;
               comboBoxMisc.Items.Clear();
               comboBoxMisc.Items.AddRange(grillMisc);
               break;
            case "MakeupMisc":
               comboBoxMisc.Enabled = true;
               comboBoxMisc.Items.Clear();
               comboBoxMisc.Items.AddRange(makeupMisc);
               break;
            case "SauteeMisc":
               comboBoxMisc.Enabled = true;
               comboBoxMisc.Items.Clear();
               comboBoxMisc.Items.AddRange(sauteeMisc);
               break;
         }
      }
      private void buttonUpdateMisc_Click(object sender, EventArgs e)
      {
         if (comboBoxMiscTable.SelectedIndex > -1 && comboBoxMisc.SelectedIndex > -1)
         {
            DateTime d = DateTime.Today;
            string date = d.ToString("d");
            DatabaseConnector dc = new DatabaseConnector();
            if (!(cbUpdateMisc.Checked))
               dc.Present = "O";
            dc.UpdateMisc(comboBoxMiscTable.Text, date, comboBoxMisc.Text, toolStripStatusMain.Text);
         }
         else
         {
            MessageBox.Show("Please select a station and a piece of equipment.");
         }
      }

      private void buttonLoadData_Click(object sender, EventArgs e)
      {
         DateTime d = dtpData.Value; 
         string date = d.ToString("d") + " 12:00:00 AM";
         DatabaseConnector dc = new DatabaseConnector();
         if (dc.LineCheckExists(date) && comboBoxData.SelectedIndex > -1)
            {
                dc.SelectBad(comboBoxData.SelectedItem.ToString(), date, dataGridViewMain);
            }
            else
            {
                MessageBox.Show($"No record available for {date}");
                dtpData.ResetText();
            }
      }
      private void buttonXML_Click(object sender, EventArgs e)
      {
         DatabaseConnector dc = new DatabaseConnector();
         DateTime dMin = dtpExportMin.Value;
         string dateMin = dMin.ToString("d") + " 12:00:00 AM";
         DateTime dMax = dtpExportMax.Value;
         string dateMax = dMax.ToString("d") + " 12:00:00 AM";
            //switch statement between 3 selected indexes of combox

            if (dc.LineCheckExists(dateMin) && dc.LineCheckExists(dateMax))
            {
                string foodName = Application.StartupPath + "_" + toolStripStatusMain.Text + "Food.xml";
                string miscName = Application.StartupPath + "_" + toolStripStatusMain.Text + "Misc.xml";
                string selected = comboBoxXmlSprocs.SelectedItem as string;

                switch (selected)
                {
                    case "AllFood":
                        if (!System.IO.File.Exists(foodName))
                        {
                            List<FoodData> sqlFoods = dc.SelectXmlFood(dateMin, dateMax);
                            dc.CreateXmlFileFood(dateMin, dateMax, toolStripStatusMain.Text, sqlFoods);
                        }
                        else
                        {
                            MessageBox.Show("Xml file has already been created");
                        }
                        break;
                    case "AllMisc":
                        if (!System.IO.File.Exists(miscName))
                        {
                            List<FoodData> sqlMiscs = dc.SelectXmlMisc(dateMin, dateMax);
                            dc.CreateXmlFileMisc(dateMin, dateMax, toolStripStatusMain.Text, sqlMiscs);
                        }
                        else
                        {
                            MessageBox.Show("Xml file has alrady been created");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("No records exists for the selected dates");
            }
        }
      private void panel22_Paint(object sender, PaintEventArgs e)
      {

      }

      private void panelPizza_Paint(object sender, PaintEventArgs e)
      {

      }

      private void tabPage1_Click(object sender, EventArgs e)
      {

      }

      private void checkBox1_CheckedChanged(object sender, EventArgs e)
      {

      }

      private void labelAppearance_Click(object sender, EventArgs e)
      {

      }

      private void label5_Click(object sender, EventArgs e)
      {

      }

      private void label23_Click(object sender, EventArgs e)
      {

      }

      private void checkBox69_CheckedChanged(object sender, EventArgs e)
      {

      }

      private void checkBox57_CheckedChanged(object sender, EventArgs e)
      {

      }

      private void labelPizza1_Click(object sender, EventArgs e)
      {

      }
      private void pictureBox1_Click(object sender, EventArgs e)
      {

      }
      private void tabPageApp_Click(object sender, EventArgs e)
      {

      }

      private void tabPageSalad_Click(object sender, EventArgs e)
      {

      }

      private void checkBox127_CheckedChanged(object sender, EventArgs e)
      {

      }

      private void statusStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
      {

      }

      private void labelSautee1_Click(object sender, EventArgs e)
      {

      }

      private void button1_Click(object sender, EventArgs e)
      {

      }

      private void tabPageExport_Click(object sender, EventArgs e)
      {

      }

        private void comboBoxXmlSprocs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
