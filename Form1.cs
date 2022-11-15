namespace Backpacker
{
    public partial class Form1 : Form
    {
        List<Item> items = new List<Item>();
        List<Receptical> bags = new List<Receptical>();

        public Form1()
        {
            InitializeComponent();
            TestCode(); //creates variables for items and packs

            for(int i = 0; i < items.Count; i++)
                checkedListBoxPackableItems.Items.Add(items[i].Name);

            for(int i = 0; i < bags.Count; i++)
                comboBoxBags.Items.Add(bags[i].Name);

        }

        private void TestCode() // Test code is metric, g, mm, mL(mm3/1000)
        {
            Item textbook = new Item("Text Book", 185, 40, 230, 1372);
            Item block = new Item();
            Item shirt = new Item("T-Shirt", 175, 75, 75, 200);            
            Item sparkelingWater = new Item("Sparkling Water", 235, 60, 60, 503);
            Item shoes = new Item("Sneaker(each)", 280, 110, 100, 340);
            Item sandwitch = new Item("Sandwich", 100, 100, 35, 200);
            Item bannana = new Item("Bannana",100, 35, 35, 120);
            Item cinderBlock = new Item("Cinder Block", 200, 200, 400, 16000);
            Item canOfNuts = new Item("Can-of-nuts", 160, 120, 120, 850);

            
            Receptical lunchBox = new Receptical(4370, "Lunch Box", 190,230, 100, 90);
            Receptical carryOn = new Receptical(56000, "Carry-On", 560,390,230, 3578.7);
            
            Receptical purse = new Receptical();
            Receptical suitCase = new Receptical();
            Receptical cardBoardBox = new Receptical();
            Receptical smPocket = new Receptical(1000, "Sm Pocket", 100, 100, 100, 50);
            Receptical medPocket = new Receptical(11200, "Med Pocket", 200, 200, 280, 75);

            Receptical[] bagPockets = new Receptical[2] {smPocket, medPocket};
            Receptical backPack = new Receptical(30000, 17800, bagPockets, "Backpack", 470, 300, 155, 390);

            items.Add(shoes);
            items.Add(sandwitch);
            items.Add(textbook);
            items.Add(cinderBlock);
            items.Add(canOfNuts);
            items.Add(sparkelingWater);
            items.Add(bannana);
            items.Add(shirt);

            bags.Add(lunchBox);
            bags.Add(carryOn);
            bags.Add(backPack);
        }

        //TODO crate update method to display changes when method called


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try//TODO check why this isn't working
            {
                //bags[comboBoxBags.SelectedIndex].AddItem(items[checkedListBoxPackableItems.SelectedIndex]);
                //listBoxPackedItems.Items.Clear();
                //bags[comboBoxBags.SelectedIndex].Contents.TrimExcess();
                //for (int i = 0; i < bags[comboBoxBags.SelectedIndex].Contents.Count; i++)
                //    listBoxPackedItems.Items.Add(bags[comboBoxBags.SelectedIndex].Contents[i].Name);
                //TODO bellow code will add items twice as top code isn't displaying as needed
                listBoxPackedItems.Items.Add(items[checkedListBoxPackableItems.SelectedIndex].Name);
                checkedListBoxPackableItems.ClearSelected();
            }
            catch (Exception ex)
            {
                //do something
            }
        }

        private void comboBoxBags_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelBagType.Text = bags[comboBoxBags.SelectedIndex].Name;
            labelBagHeight.Text = bags[comboBoxBags.SelectedIndex].Height.ToString();
            labelBagWidth.Text = bags[comboBoxBags.SelectedIndex].Width.ToString();
            labelBagLength.Text = bags[comboBoxBags.SelectedIndex].Depth.ToString();
            labelBagMinWeight.Text = bags[comboBoxBags.SelectedIndex].Weight.ToString();
            labelnumbPockts.Text = (bags[comboBoxBags.SelectedIndex].PocketsArray.Length + 1).ToString();
            labelWeight.Text = bags[comboBoxBags.SelectedIndex].CurrentWeight().ToString();
            labelSpaceA.Text = bags[comboBoxBags.SelectedIndex].SpaceA().ToString();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            listBoxPackedItems.Items.RemoveAt(listBoxPackedItems.SelectedIndex);

        }
    }
}