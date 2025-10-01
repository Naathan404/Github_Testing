using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Converters;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_IT008_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    // Partial class giúp chia class MainWindow thành nhiều phần, mỗi phần trong một file khác nhau
    // Như trong đây là file MainWindow.xaml.cs và MainWindow.xaml để tách biệt UI và code behind
    // Điều này giúp việc quản lý code và xây dựng giao diện trở nên dễ dàng hơn
    public partial class MainWindow : Window //INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
           // this.DataContext = this; // ButtonName lấy dữ liệu từ DataContext của xaml, mà lúc đầu nó là null, nên phải gán DataContext = this để nó lấy dữ liệu từ code behind
            //ButtonName = "Binding data from code behind!";

            //Button button = new Button(); // Dùng để tạo button
            //button.Click += button_Click; // Thêm khai báo sự kiện click cho button
            //button.Content = "Click Me"; 
            //grid.Children.Add(button); // Thêm button vào grid


            //TextBlock txbl = new TextBlock(); // Thêm TextBlock
            //txbl.Text = "Hello, World!";
            //grid.Children.Add(txbl);
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    textBlock.Text = textBox.Text; // Gán nội dung của TextBox vào TextBlock khi ấn nút
        //    MessageBox.Show("Button Clicked");
        //}

        //public int DoubleValue(int value)
        //{
        //    return value * 2;
        //}
        //private void textChanged(object sender, TextChangedEventArgs e)
        //{
        //    int value;
        //    if (int.TryParse(textBox.Text, out value)) // Kiểm tra xem chuỗi có thể chuyển đổi thành số nguyên không (hoặc các kiểu khác như double, float)
        //    {
        //        textBlock.Text = DoubleValue(value).ToString(); // Gán giá trị gấp đôi vào TextBlock
        //    }
        //    else
        //    {
        //        textBlock.Text = "Invalid input"; // Thông báo lỗi nếu giá trị không hợp lệ
        //    }
        //}

        // BINDING CHO BUTTON

        //private string btnName;

        //public string ButtonName
        //{
        //    get { return btnName; }
        //    set
        //    {
        //        btnName = value;
        //        OnPropertyChanged("ButtonName");
        //    }
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void OnPropertyChanged(string propertyName) // OnpropertyChanged để thông báo khi thuộc tính thay đổi (name)
        //{
        //    if (PropertyChanged != null) // Tránh lỗi khi không có ai đăng ký sự kiện
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //        // truyền sender và name. do yêu cầu của .NET phải tách riêng sender và name nên đóng gói name vào PropertyChangedEventArgs
        //    }
        //}

        // CANVAS Z-INDEX
        //private void Button2_Click(object sender, RoutedEventArgs e)
        //{
        //    Canvas.SetZIndex(Button2, 1); // Đặt Button2 lên trên Button1
        //    Canvas.SetZIndex(Button1, 0); // Đặt Button1 xuống dưới Button2
        //}

        //private void Button1_Click(object sender, RoutedEventArgs e)
        //{
        //    Canvas.SetZIndex(Button1, 1); // Đặt Button1 lên trên Button2
        //    Canvas.SetZIndex(Button2, 0); // Đặt Button2 xuống dưới Button1
        //}


        //SCROLL VIEWER
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //scvMain.ScrollToBottom(); // Scroll đến cuối cùng

        //    //MessageBox.Show(scvMain.ContentVerticalOffset.ToString()); // Lấy vị trí hiện tại của thanh cuộn dọc

        //    //scvMain.ScrollToVerticalOffset(50); // Scroll ngang đến vị trí 50
        //}



        // CHECK BOX
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    if (checkBox.IsChecked == true)
        //    {
        //        MessageBox.Show("Checked");
        //    }
        //    else if (checkBox.IsChecked == false)
        //    {
        //        MessageBox.Show("Unchecked");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Indeterminate");
        //    }
        //}

        // ########## RADIO BUTTON ###############
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    // Nếu đang là hidden thì chuyển sang visible và ngược lại
        //    borderMain.Visibility = (borderMain.Visibility == Visibility.Hidden) ? Visibility.Visible : Visibility.Hidden;
        //}

    }
}
