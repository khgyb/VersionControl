using ssp7wq_gyak08.Abstractions;
using ssp7wq_gyak08.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ssp7wq_gyak08
{
    public partial class Form1 : Form
    {
        private Toy _nextToy;

        private List<Toy> _toys = new List<Toy>();

        private IToyFactory _factory;

        public IToyFactory Factory
        {
            get { return _factory; }
            set 
            { 
                _factory = value;
                DisplayNext();
            }
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = Factory.Createnew();
            _toys.Add(toy);
            toy.Left = -toy.Width;
            mainPanel.Controls.Add(toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var ball in _toys)
            {
                ball.MoveToy();
                if (ball.Left > maxPosition)
                    maxPosition = ball.Left;
            }

            if (maxPosition>1000)
            {
                var oldestBall = _toys[0];
                mainPanel.Controls.Remove(oldestBall);
                _toys.Remove(oldestBall);
            }
        }

        private void btn_car_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void btn_ball_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory();
        }
        private void DisplayNext()
        {
            if (_nextToy != null)
                Controls.Remove(_nextToy);
            _nextToy = Factory.Createnew();
            _nextToy.Top = lbl_next.Top + 10;
            _nextToy.Left = lbl_next.Left + 20;
            Controls.Add(_nextToy);
        }
    }
}
