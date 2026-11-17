using System.Collections;
using System.Windows;

namespace ArrayList
{
    public partial class MainWindow : Window
    {
        System.Collections.ArrayList arrayList;

        public MainWindow()
        {
            InitializeComponent();
            arrayList = new System.Collections.ArrayList();

            arrayList.Add(30);
            arrayList.Add(10);
            arrayList.Add(20);
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            int number = int.Parse(txtNumber.Text);
            arrayList.Add(number);

            txtNumber.Clear();
            MessageBox.Show("เพิ่มเลข " + number + " เรียบร้อยแล้ว");
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            int number = int.Parse(txtNumber.Text);

            if (arrayList.Contains(number))
            {
                arrayList.Remove(number);
                MessageBox.Show("ลบเลข " + number + " เรียบร้อยแล้ว");
            }
            else
            {
                MessageBox.Show("ไม่พบเลข " + number + " ในรายการ");
            }

            txtNumber.Clear();
        }

        private void BtnShowAll_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Sort();

            foreach (int data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }
        }
    }
}