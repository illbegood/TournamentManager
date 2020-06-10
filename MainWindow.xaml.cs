using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace TournamentManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        void HidePanels()
        {
            playersGrid.Visibility = Visibility.Collapsed;
            teamsGrid.Visibility = Visibility.Collapsed;
            tournamentsGrid.Visibility = Visibility.Collapsed;
            BracketGrid.Visibility = Visibility.Collapsed;
        }
        //List<Player> players = new List<Player>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void playersMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HidePanels();
            new PlayerForm().ShowDialog();
        }

        private void teamsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HidePanels();
            new TeamForm().ShowDialog();
        }

        private void tournamentsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HidePanels();
            new TournamentForm().ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //playersListView.ItemsSource = players;
        }

        private void addPlayer_Click(object sender, RoutedEventArgs e)
        {
            TextBoxDialog tbd = new TextBoxDialog("Enter name");
            if ((bool)tbd.ShowDialog())
                if (Player.Add(tbd.Text))
                    MessageBox.Show("Success!");
                else
                    MessageBox.Show("Failure!");
        }

        private void ShowPlayers_Click(object sender, RoutedEventArgs e)
        {
            HidePanels();
            Dictionary<int, string> players = SQL.GetPlayers();
            if (players == null)
                return;
            List<IntString> list = new List<IntString>();
            foreach (var pair in players)
                list.Add(new IntString(pair.Key, pair.Value));
            playersLeftDataGrid.ItemsSource = list;
            playersGrid.Visibility = Visibility.Visible;
        }

        private void ShowTeams_Click(object sender, RoutedEventArgs e)
        {
            HidePanels();
            Dictionary<int, string> teams = SQL.GetTeams();
            if (teams == null)
                return;
            List<IntString> list = new List<IntString>();
            foreach (var pair in teams)
                list.Add(new IntString(pair.Key, pair.Value));
            teamsLeftDataGrid.ItemsSource = list;
            teamsGrid.Visibility = Visibility.Visible;
        }

        private void ShowTournaments_Click(object sender, RoutedEventArgs e)
        {
            HidePanels();
            List<object>[] t = SQL.GetTournaments();
            if (t == null)
                return;
            List<SeveralObjects> list = new List<SeveralObjects>();
            for (int i = 0; i < t[0].Count; ++i)
                list.Add(new SeveralObjects { O0 = t[0][i], O1 = t[1][i], O2 = t[2][i], O3 = t[3][i], O4 = t[4][i], O5 = t[5][i] });
            tournamentsLeftDataGrid.ItemsSource = list;
            tournamentsGrid.Visibility = Visibility.Visible;
        }

        private void playersTeamsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HidePanels();
            new PlayersTeamsForm().ShowDialog();
        }

        private void playersLeftDataGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            IntString x = (IntString)playersLeftDataGrid.SelectedItem;
            playersRightDataGrid.ItemsSource = null;
            if (x == null)
                return;
            Dictionary<int, string> teams = SQL.GetPlayerTeams(x.I);
            if (teams == null)
                return;
            List<IntString> list = new List<IntString>();
            foreach (var pair in teams)
                list.Add(new IntString(pair.Key, pair.Value));
            playersRightDataGrid.ItemsSource = list;
        }

        private void teamsLeftDataGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            IntString x = (IntString)teamsLeftDataGrid.SelectedItem;
            teamsRightDataGrid.ItemsSource = null;
            if (x == null)
                return;
            Dictionary<int, string> players = SQL.GetTeamPlayers(x.I);
            if (players == null)
                return;
            List<IntString> list = new List<IntString>();
            foreach (var pair in players)
                list.Add(new IntString(pair.Key, pair.Value));
            teamsRightDataGrid.ItemsSource = list;
        }

        private void tournamentsLeftDataGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SeveralObjects x = (SeveralObjects)tournamentsLeftDataGrid.SelectedItem;
            tournamentsRightDataGrid.ItemsSource = null;
            matchesDataGrid.ItemsSource = null;
            if (x == null)
                return;
            Dictionary<int, string> teams = SQL.GetTournamentTeams((int)x.O0);
            if (teams == null)
                return;
            List<IntString> list = new List<IntString>();
            foreach (var pair in teams)
                list.Add(new IntString(pair.Key, pair.Value));
            tournamentsRightDataGrid.ItemsSource = list;
            List<object>[] t = SQL.GetMatches((int)x.O0);
            if (t == null)
                return;
            List<SeveralObjects> list2 = new List<SeveralObjects>();
            for (int i = 0; i < t[0].Count; ++i)
                list2.Add(new SeveralObjects
                {
                    O0 = t[0][i],
                    O1 = t[1][i],
                    O2 = t[2][i],
                    O3 = t[3][i],
                    O4 = t[4][i],
                    O5 = t[5][i],
                    O6 = t[6][i],
                    O7 = t[7][i],
                    O8 = t[8][i],
                    O9 = t[9][i],
                    O10 = t[10][i]
                });
            matchesDataGrid.ItemsSource = list2;
        }

        private void tournamentsTeamsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HidePanels();
            new TournamentTeamForm().ShowDialog();
        }

        private void gamesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HidePanels();
            new GameForm().ShowDialog();
        }

        private void matchesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HidePanels();
            new MatchForm().ShowDialog();
        }

        private void matchesFormatsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HidePanels();
            new MatchFormatsForm().ShowDialog();
        }

        private void matchesCategoriesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HidePanels();
            new MatchCategories().ShowDialog();
        }

        private MatchNode tree(List<SeveralObjects> list, int count)
        {
            int bigCount = (int)Math.Pow(2, count - 1);
            List<MatchNode> lprev = null;
            MatchNode head = null;
            for (int i = 0; i < count; ++i)
            {
                List<SeveralObjects> l_ = new List<SeveralObjects>();
                foreach (var v in list)
                    if ((int)v.O9 == i + 1)
                        l_.Add(v);
                /*list.Where(x => (int)x.O9 == i + 1);*/
                List<MatchNode> l = new List<MatchNode>();
                foreach (var x in l_)
                    l.Add(new MatchNode((int)x.O1, (int)x.O2, (int)x.O3, (int)x.O5, (string)x.O4, (string)x.O6, count - (int)x.O9));
                    //l_.Select(x => new MatchNode((int)x.O1, (int)x.O2, (int)x.O3, (int)x.O5, (string)x.O4, (string)x.O6, count - (int)x.O9));
                foreach (var v in l)
                {
                    if (lprev == null)
                    {
                        head = v;
                        head.left = 0;
                        head.right = bigCount - 1;
                        continue;
                    }
                    foreach (var V in lprev)
                        if (v.p1id == V.p1id || v.p2id == V.p1id)
                        {
                            v.left = V.left;
                            v.right = V.left + (V.right - V.left) / 2;
                            V.child.Add(v);
                        }
                        else if (v.p1id == V.p2id || v.p2id == V.p2id)
                        {
                            v.left = V.left + (V.right - V.left) / 2 + 1;
                            v.right = V.right;
                            V.child.Add(v);
                        }
                }
                lprev = l;
            }
            return head;
        }

        private void bracketButton_Click(object sender, RoutedEventArgs e)
        {
            //0 - matches.id, 1 - matches.team1score, 2 - matches.team2score, 3 - matches.team1_id, 
            //4 - team1.name, 5 - matches.team2_id, 6 - team2.name, 7 - matchformats.id, 
            //8 - matchformats.name, 9 - l.id, 10 - matchcategories.name
            if (tournamentsLeftDataGrid.SelectedItem == null)
                return;
            HidePanels();
            try
            {
                BracketGrid.Children.Clear();
                BracketGrid.RowDefinitions.Clear();
                BracketGrid.ColumnDefinitions.Clear();
                BracketGrid.RowDefinitions.Add(new RowDefinition());
                List<SeveralObjects> list = ((List<SeveralObjects>)matchesDataGrid.ItemsSource);
                int count = (int)list.Select(x => x.O9).Max();
                int bigCount = (int)Math.Pow(2, count) / 2;
                for (int i = 0; i < count; ++i)
                {
                    BracketGrid.ColumnDefinitions.Add(new ColumnDefinition());
                    Label l = new Label();
                    var y = new List<SeveralObjects>(list.Where(x => (int)x.O9 == count - i));
                    l.Content = y[0].O10;
                    l.HorizontalAlignment = HorizontalAlignment.Center;
                    l.VerticalAlignment = VerticalAlignment.Center;
                    l.SetValue(Grid.ColumnProperty, i);
                    BracketGrid.Children.Add(l);
                }
                for (int i = 0; i < bigCount; ++i)
                    BracketGrid.RowDefinitions.Add(new RowDefinition());
                MatchNode head = tree(list, count);
                Queue<MatchNode> q = new Queue<MatchNode>();
                q.Enqueue(head);
                while (q.Count != 0)
                {
                    MatchNode mn = q.Dequeue();
                    foreach (var v in mn.child)
                        q.Enqueue(v);
                    StackPanel sp = new StackPanel();
                    sp.Orientation = Orientation.Vertical;
                    sp.HorizontalAlignment = HorizontalAlignment.Center;
                    sp.VerticalAlignment = VerticalAlignment.Center;
                    sp.SetValue(Grid.ColumnProperty, mn.col);
                    sp.SetValue(Grid.RowProperty, 1 + mn.left);
                    sp.SetValue(Grid.RowSpanProperty, mn.right - mn.left + 1);
                    int[] ar = { mn.p1score, mn.p2score };
                    string[] s = { mn.p1name, mn.p2name };
                    for (int j = 0; j < 2; ++j)
                    {
                        StackPanel sp1 = new StackPanel();
                        sp1.Orientation = Orientation.Horizontal;
                        sp1.FlowDirection = FlowDirection.RightToLeft;
                        sp.HorizontalAlignment = HorizontalAlignment.Center;
                        sp.VerticalAlignment = VerticalAlignment.Center;
                        TextBlock tb2 = new TextBlock();
                        tb2.Text = ar[j].ToString();
                        tb2.Padding = new Thickness(10);
                        //tb2.HorizontalAlignment = HorizontalAlignment.Right;
                        sp1.Children.Add(tb2);
                        TextBlock tb = new TextBlock();
                        tb.Text = s[j];
                        //tb.Padding = new Thickness(10);
                        sp1.Children.Add(tb);
                        sp.Children.Add(sp1);
                    }
                    BracketGrid.Children.Add(sp);
                }
                BracketGrid.Visibility = Visibility.Visible;
            }
            catch
            {
                HidePanels();
                ShowTournaments_Click(null, null);
            }
        }
    }

    class IntString
    {
        public int I { get; set; }
        public string S { get; set; }
        public IntString(int i, string s)
        {
            I = i;
            S = s;
        }
    }

    class SeveralObjects
    {
        public object O0 { get; set; }
        public object O1 { get; set; }
        public object O2 { get; set; }
        public object O3 { get; set; }
        public object O4 { get; set; }
        public object O5 { get; set; }
        public object O6 { get; set; }
        public object O7 { get; set; }
        public object O8 { get; set; }
        public object O9 { get; set; }
        public object O10 { get; set; }
    }
}

class MatchNode
{
    public int p1score, p2score;
    public int p1id, p2id;
    public List<MatchNode> child = new List<MatchNode>();
    public string p1name, p2name;
    public int left { get; set; }
    int _right;
    public int right;/*{ get { return _right; } set { _right = value; } }*/
    public int col;
    public MatchNode(int p1score, int p2score, int p1id, int p2id, string p1name, string p2name, int col)
    {
        this.p1name = p1name;
        this.p1score = p1score;
        this.p1id = p1id;
        this.p2id = p2id;
        this.p2name = p2name;
        this.p2score = p2score;
        this.col = col;
    }
}
