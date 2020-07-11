using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TabSwitcherRE
{
    /// <summary>
    /// Логика взаимодействия для TabSwitcherControl.xaml
    /// </summary>
    public partial class TabSwitcherControl : UserControl
    {
        public TabSwitcherControl()
        {
            InitializeComponent();
            btnPrevious.Click += BtnPrevious_Click;
            btnNext.Click += BtnNext_Click;
        }

        public static readonly DependencyProperty PrevTextProperty = DependencyProperty.Register("PrevText",
            typeof(string), typeof(TabSwitcherControl), new PropertyMetadata("Prev", new PropertyChangedCallback
                (OnPrevChanged)));

        private static void OnPrevChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            TextBlock myTextBlock = (TextBlock)(sender as UserControl).FindName("tbPrev");
            if (myTextBlock != null)
                myTextBlock.Text = e.NewValue.ToString();
        }

        public string PrevText
        {
            get
            {
                return (string)GetValue(PrevTextProperty);
            }
            set
            {
                SetValue(PrevTextProperty, value);
            }
        }

        public static readonly RoutedEvent btnPrevClickEvent = EventManager.RegisterRoutedEvent
            ("btnPreviousClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TabSwitcherControl));

        public event RoutedEventHandler btnPreviousClick
        {
            add { AddHandler(btnPrevClickEvent, value); }
            remove { RemoveHandler(btnPrevClickEvent, value); }
        }


        private void BtnPrevious_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            RoutedEventArgs args = new RoutedEventArgs(btnPrevClickEvent);
            RaiseEvent(args);
        }

        protected override void OnContentChanged(object oldContent, object newContent)
        {
            if (oldContent != null)
                throw new InvalidOperationException("You can't change Content!");
        }


        //NextClick


        public static readonly DependencyProperty NextTextProperty = DependencyProperty.Register("NextText",
    typeof(string), typeof(TabSwitcherControl), new PropertyMetadata("Next", new PropertyChangedCallback
        (OnNextChanged)));

        private static void OnNextChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            TextBlock myTextBlock = (TextBlock)(sender as UserControl).FindName("tbNext");
            if (myTextBlock != null)
                myTextBlock.Text = e.NewValue.ToString();
        }

        public string NextText
        {
            get
            {
                return (string)GetValue(NextTextProperty);
            }
            set
            {
                SetValue(NextTextProperty, value);
            }
        }

        public static readonly RoutedEvent btnNextClickEvent = EventManager.RegisterRoutedEvent
            ("btnNextClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TabSwitcherControl));

        public event RoutedEventHandler btnNextClick
        {
            add { AddHandler(btnNextClickEvent, value); }
            remove { RemoveHandler(btnNextClickEvent, value); }
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            RoutedEventArgs args = new RoutedEventArgs(btnNextClickEvent);
            RaiseEvent(args);
        }
    }
}
