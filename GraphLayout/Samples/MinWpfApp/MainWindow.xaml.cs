using System.Windows;
using Microsoft.Msagl.Drawing;

namespace MinWpfApp {
    public partial class MainWindow {

        public MainWindow() {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e) {

            Graph graph = new Graph();

            graph.AddNode("entrance");
            graph.AddNode("plaza");
            graph.AddNode("ride1area");
            graph.AddNode("ride1");
            graph.AddNode("ride1shop");
            graph.AddNode("ride2");
            graph.AddNode("ride3");
            graph.AddNode("ride3area");
            graph.AddNode("ride3shop");
            graph.AddNode("restaurant1");
            graph.AddNode("restaurant2");
            graph.AddNode("ride4");

            graph.AddEdge("entrance", "plaza");
            graph.AddEdge("entrance", "restaurant1");
            graph.AddEdge("plaza", "restaurant1");
            graph.AddEdge("plaza", "ride1area");
            graph.AddEdge("ride1area", "ride1");
            graph.AddEdge("ride1area", "ride2");
            graph.AddEdge("ride1area", "ride1shop");
            graph.AddEdge("plaza", "ride3area");
            graph.AddEdge("ride3area", "ride3");
            graph.AddEdge("ride3area", "ride4");
            graph.AddEdge("ride3area", "ride3shop");
            graph.AddEdge("ride3area", "restaurant2");


            //graph.FindNode("Box").Attr.Shape = Shape.Box;
            //graph.FindNode("House").Attr.Shape = Shape.House;
            //graph.FindNode("InvHouse").Attr.Shape = Shape.InvHouse;
            //graph.FindNode("Diamond").Attr.Shape = Shape.Diamond;
            //graph.FindNode("Octagon").Attr.Shape = Shape.Octagon;
            //graph.FindNode("Hexagon").Attr.Shape = Shape.Hexagon;
            //graph.FindNode("2 Circle").Attr.Shape = Shape.DoubleCircle;

            graph.Attr.LayerDirection = LayerDirection.BT;

            graphControl.Graph = graph;
        }
    }
}