using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace RadialMenu 
{
    public partial class MainPage : ContentPage 
    {
        public MainPage() 
        {
            InitializeComponent();
           this.BindingContext = new BookInfoRepository();

        }       
        private void listView_ItemTapped_1(object sender, Syncfusion.Maui.ListView.ItemTappedEventArgs e) 
        {
            radial_Menu.TranslationX = e.Position.X - (radial_Menu.Width);
            radial_Menu.TranslationY = e.Position.Y - (radial_Menu.Height);
            radial_Menu.IsOpen = true;
            radial_Menu.IsVisible = true;
        }

        private void radial_Menu_Closing_1(object sender, Syncfusion.Maui.RadialMenu.ClosingEventArgs e) {
            radial_Menu.IsVisible = false;
        }
    }

    public class BookInfo : INotifyPropertyChanged {
        private string bookName;
        private string bookDesc;

        public string BookName {
            get { return bookName; }
            set {
                bookName = value;
                OnPropertyChanged("BookName");
            }
        }

        public string BookDescription {
            get { return bookDesc; }
            set {
                bookDesc = value;
                OnPropertyChanged("BookDescription");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name) {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }

    public class BookInfoRepository {
        private ObservableCollection<BookInfo> bookInfo;

        public ObservableCollection<BookInfo> BookInfo {
            get { return bookInfo; }
            set { this.bookInfo = value; }
        }

        public BookInfoRepository() {
            GenerateBookInfo();
        }

        internal void GenerateBookInfo() {
            bookInfo = new ObservableCollection<BookInfo>();
            bookInfo.Add(new BookInfo() { BookName = "Object-Oriented Programming in C#", BookDescription = "Object-oriented programming is a programming paradigm based on the concept of objects" });
            bookInfo.Add(new BookInfo() { BookName = "C# Code Contracts", BookDescription = "Code Contracts provide a way to convey code assumptions" });
            bookInfo.Add(new BookInfo() { BookName = "Machine Learning Using C#", BookDescription = "You will learn several different approaches to applying machine learning" });
            bookInfo.Add(new BookInfo() { BookName = "Neural Networks Using C#", BookDescription = "Neural networks are an exciting field of software development" });
            bookInfo.Add(new BookInfo() { BookName = "Visual Studio Code", BookDescription = "It is a powerful tool for editing code and serves for end-to-end programming" });
            bookInfo.Add(new BookInfo() { BookName = "Android Programming", BookDescription = "It provides a useful overview of the Android application life cycle" });
            bookInfo.Add(new BookInfo() { BookName = "iOS Succinctly", BookDescription = "It is for developers looking to step into frightening world of iPhone" });
            bookInfo.Add(new BookInfo() { BookName = "Visual Studio 2015", BookDescription = "The new version of the widely-used integrated development environment" });
            bookInfo.Add(new BookInfo() { BookName = "Xamarin.Forms", BookDescription = "It creates mappings from its C# classes and controls directly" });
            bookInfo.Add(new BookInfo() { BookName = "Windows Store Apps", BookDescription = "Windows Store apps present a radical shift in Windows development" });
        }
    }
}






